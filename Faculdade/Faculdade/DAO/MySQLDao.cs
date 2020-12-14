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
  public class MySQLDao
  {
    private static readonly MySQLDao instanciaMySQL = new MySQLDao();

    private MySQLDao() { }

    public static MySQLDao getInstancia()
    {
      return instanciaMySQL;
    }

    public MySqlConnection getConexao()
    {
      string conn = ConfigurationManager.ConnectionStrings["faculdadeContext"].ToString();
      return new MySqlConnection(conn);
    }

    public static int GeraId(string table)
    {
      try
      {
        return Convert.ToInt32(MySQLDao.GetRegistros(table, " max(id) as id ").Rows[0]["id"]) + 1;
      }
      catch
      {
        return 1;
      }
    }

    public static DataTable GetRegistros(string table, string select = "*", string where = "")
    {
      using (MySqlConnection conexaoMySQL = MySQLDao.getInstancia().getConexao())
      {
        try
        {
          conexaoMySQL.Open();

          string mSQL = $"Select {select} from {table} {where}";

          MySqlCommand cmd = new MySqlCommand(mSQL, conexaoMySQL);
          MySqlDataAdapter da = new MySqlDataAdapter(cmd);

          DataTable dtUsuario = new DataTable();
          da.Fill(dtUsuario);

          return dtUsuario;
        }
        catch (MySqlException msqle)
        {
          MessageBox.Show("Erro de acesso ao MySQL : " + msqle.Message);
        }
        finally
        {
          conexaoMySQL.Close();
        }
        return null;
      }
    }

    public static bool Update(DataTable dataSource, string table)
    {
      using (MySqlConnection conexaoMySQL = MySQLDao.getInstancia().getConexao())
      {
        try
        {
          conexaoMySQL.Open();

          string mSQL = $"Select * from {table}";
          MySqlDataAdapter da = new MySqlDataAdapter(mSQL, conexaoMySQL);
          MySqlCommandBuilder cmd = new MySqlCommandBuilder(da);

          da.Update(dataSource);

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