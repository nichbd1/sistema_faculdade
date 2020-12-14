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
  public class DiplomaDAO
  {

    public DiplomaDAO(diploma diploma)
    {

    }

    public static DataTable GetDiplomas(string select = "*", string where = "")
    {      
        return MySQLDao.GetRegistros("diploma", select, where);     
    }

    public static int GeraId()
    {
      return MySQLDao.GeraId("diploma");
    }
    public static bool Update(DataTable dataSource)
    {
      return MySQLDao.Update(dataSource, "diploma");
    }
  }
}