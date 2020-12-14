using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Faculdade.DAO
{
  /// <summary>
  /// Classe que usa o padrão Singleton para obter 
  /// uma instãncia da conexão com o MySQL
  /// </summary>
  public class UsuarioDAO
  {
    public UsuarioDAO(usuario usuario)
    {

    }

    public static DataTable GetUsuarios(string select = "*", string where = "")
    {
      return MySQLDao.GetRegistros("usuario", select, where);
    }

    public static bool Update(DataTable dataSource)
    {
      return MySQLDao.Update(dataSource, "usuario");
    }

    public static bool UpdateSenha(string novaSenha, string id)
    {
      using (MySqlConnection conexaoMySQL = MySQLDao.getInstancia().getConexao())
      {
        try
        {
          conexaoMySQL.Open();

          string sqlupd = $@"UPDATE usuario SET senha = '{novaSenha}' where id = {id}";

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

    public static bool UpdateCodigoSenha(string codigo, string id)
    {
      using (MySqlConnection conexaoMySQL = MySQLDao.getInstancia().getConexao())
      {
        try
        {
          conexaoMySQL.Open();

          string sqlupd = $@"UPDATE usuario SET codigo_recupera_senha = '{codigo}' where id = {id}";

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
