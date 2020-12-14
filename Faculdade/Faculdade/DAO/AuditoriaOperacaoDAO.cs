using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Faculdade.DAO
{
  /// <summary>
  /// Classe que usa o padrão Singleton para obter 
  /// uma instãncia da conexão com o MySQL
  /// </summary>
  public class AuditoriaOperacaoDAO
  {

    public AuditoriaOperacaoDAO(auditoria_operacao auditoria_operacao)
    {

    }

    public static DataTable GetAuditorias(string where = "")
    {
      return MySQLDao.GetRegistros("auditoria_operacao", "*", " where not (operacao = 'U' and coluna_alterada = 'diploma_validado' and ((date_sub({fn now()}, interval 40 year)) >= data_operacao))");
    }

    public static bool UpdateAuditoria(DataTable dataSource, DataTable dataSourceAntigo, string nome_registro, int qtdd_colunas)
    {
      int addedrows = 0;
      using (MySqlConnection conexaoMySQL = MySQLDao.getInstancia().getConexao())
      {
        try
        {
          conexaoMySQL.Open();          

          List<auditoria_operacao> listaAuditoria = new List<auditoria_operacao>();

          foreach (DataRow rowNova in dataSource.Rows)
          {
            dataSourceAntigo.PrimaryKey = new DataColumn[] { dataSourceAntigo.Columns["id"] };
            DataRow rowAntiga = dataSourceAntigo.Rows.Find(rowNova["id"]);
            if (rowAntiga == null)
            {
              //insert
              auditoria_operacao auditoria = new auditoria_operacao(MySQLDao.GeraId("auditoria_operacao") + addedrows,
                                                                    Convert.ToString(LoginSession.usuario["login"]),
                                                                    "I",
                                                                    DateTime.Now,
                                                                    null,
                                                                    null,
                                                                    Convert.ToInt32(rowNova["id"]),
                                                                    Convert.ToString(rowNova[nome_registro]),
                                                                    dataSource.TableName);
              listaAuditoria.Add(auditoria);
              addedrows++;
            }
            else //update
            {
              for (int i = 0; i < qtdd_colunas; i++)
              {
                if (!rowAntiga[i].Equals(rowNova[i]))
                {
                  auditoria_operacao auditoria = new auditoria_operacao(MySQLDao.GeraId("auditoria_operacao") + addedrows,
                                                                    Convert.ToString(LoginSession.usuario["login"]),
                                                                    "U",
                                                                    DateTime.Now,
                                                                    Convert.ToString(rowAntiga[i]),
                                                                    Convert.ToString(rowNova[i]),
                                                                    Convert.ToInt32(rowNova["id"]),
                                                                    Convert.ToString(rowNova[nome_registro]),
                                                                    dataSource.TableName + "_" + dataSource.Columns[i].ColumnName);
                  listaAuditoria.Add(auditoria);
                  addedrows++;
                }
              }
            }
          }
          foreach (DataRow rowAntiga in dataSourceAntigo.Rows)
          {
            dataSource.PrimaryKey = new DataColumn[] { dataSource.Columns["id"] };
            DataRow rowNova = dataSource.Rows.Find(rowAntiga["id"]);
            if (rowNova == null)
            {
              //delete
              auditoria_operacao auditoria = new auditoria_operacao(MySQLDao.GeraId("auditoria_operacao") + addedrows,
                                                                    Convert.ToString(LoginSession.usuario["login"]),
                                                                    "D",
                                                                    DateTime.Now,
                                                                   null,
                                                                   null,
                                                                    Convert.ToInt32(rowAntiga["id"]),
                                                                    Convert.ToString(rowAntiga[nome_registro]),
                                                                    dataSource.TableName);
              listaAuditoria.Add(auditoria);
              addedrows++;
            }
          }


          string sqlupd = @"INSERT INTO auditoria_operacao VALUES ";

          foreach (auditoria_operacao _auditoria in listaAuditoria)
          {
            string data_operacao = _auditoria.data_operacao.Year.ToString() + "/" + _auditoria.data_operacao.Month.ToString() + "/" + _auditoria.data_operacao.Day.ToString();
              
            sqlupd += $@"({_auditoria.id}, '{_auditoria.login_usuario}', '{_auditoria.operacao}', '{data_operacao}', '{_auditoria.valor_antigo}', '{_auditoria.valor_novo}', {_auditoria.id_registro_alterado}, '{_auditoria.nome_registro_alterado}', '{_auditoria.coluna_alterada}'),";
          }

          sqlupd = sqlupd.Substring(0, sqlupd.Length - 1);

          MySqlDataAdapter da = new MySqlDataAdapter();

          da.UpdateCommand = new MySqlCommand(sqlupd, conexaoMySQL);
          da.UpdateCommand.ExecuteNonQuery();

          return true;
        }
        catch (MySqlException msqle)
        {
          MessageBox.Show("Erro de acesso ao MySQL : " + msqle.Message);
        }
        finally
        {
          conexaoMySQL.Close();
        }
        return false;
      }
    }
  }
}