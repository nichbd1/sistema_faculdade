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
  public class InstituicaoDAO
  {

    public InstituicaoDAO(instituicao instituicao)
    {

    }

    public static DataTable GetInstituicoes(string where = "", string select = "*")
    {
      return MySQLDao.GetRegistros("instituicao", select, where);
    }

    public static int GeraId()
    {
      return MySQLDao.GeraId("instituicao");
    }

    public static bool Update(DataTable dataSource)
    {
      return MySQLDao.Update(dataSource, "instituicao");
    }
  }
}