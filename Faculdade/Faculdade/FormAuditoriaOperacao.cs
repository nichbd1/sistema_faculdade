using Faculdade.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
  public partial class FormAuditoriaOperacao : Form
  {
    FaculdadeUtils.Funcao funcao;
    public FormAuditoriaOperacao()
    {
      InitializeComponent();
      this.funcao = (FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"]);
      DataTable auditorias = AuditoriaOperacaoDAO.GetAuditorias();
      this.gridAuditorias.DataSource = auditorias;
      gridAuditorias.Columns["id"].Visible = false;
    }  
  }
}
