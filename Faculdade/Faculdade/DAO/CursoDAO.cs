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
  public class CursoDAO
  {

    public CursoDAO(curso curso)
    {

    }

    public static DataTable GetCursos(string select = "*", string where = "")
    {      
        return MySQLDao.GetRegistros("curso", select, where);     
    }

    public static int GeraId()
    {
      return MySQLDao.GeraId("curso");
    }
    public static bool Update(DataTable dataSource)
    {
      return MySQLDao.Update(dataSource, "curso");
    }
  }
}