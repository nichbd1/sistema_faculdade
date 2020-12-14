using Faculdade.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
  public partial class FormInstituicaoParceira : Form
  {
    FaculdadeUtils.Funcao funcao;
    int addedrows = 0;
    public FormInstituicaoParceira()
    {
      InitializeComponent();
     
      this.funcao = (FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"]);
      gridInstituicoesParceiras.UserAddedRow += GridInstituicoesParceiras_UserAddedRow;

      DataTable instituicoes = InstituicaoDAO.GetInstituicoes("where principal = 0");
      if (instituicoes != null)
      {
        instituicoes.TableName = "instituicao_parceira";
        this.gridInstituicoesParceiras.DataSource = instituicoes;
       
        if (instituicoes.Rows.Count > 0)
        {
          if (funcao == FaculdadeUtils.Funcao.Dirigente)
          {
            gridInstituicoesParceiras.Columns[8].ReadOnly = true;
          }
          else 
          {
            gridInstituicoesParceiras.AllowUserToDeleteRows = false;
            gridInstituicoesParceiras.Columns[0].ReadOnly = true;
            gridInstituicoesParceiras.Columns[1].ReadOnly = true;
            gridInstituicoesParceiras.Columns[2].ReadOnly = true;
            gridInstituicoesParceiras.Columns[3].ReadOnly = true;
            gridInstituicoesParceiras.Columns[4].ReadOnly = true;
            gridInstituicoesParceiras.Columns[5].ReadOnly = true;
            gridInstituicoesParceiras.Columns[6].ReadOnly = true;
            gridInstituicoesParceiras.Columns[7].ReadOnly = true;
            if (funcao != FaculdadeUtils.Funcao.Superintendente)
              gridInstituicoesParceiras.Columns[8].ReadOnly = true;
          }
        }
      }      
    }    
    private void GridInstituicoesParceiras_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      gridInstituicoesParceiras.Rows[e.Row.Index - 1].Cells[0].Value = InstituicaoDAO.GeraId() + addedrows;
      gridInstituicoesParceiras.Rows[e.Row.Index - 1].Cells[7].Value = false;
      if (funcao == FaculdadeUtils.Funcao.Dirigente)
      {
        gridInstituicoesParceiras.Rows[e.Row.Index - 1].Cells[8].Value = false;
      }
      addedrows++;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      DataTable dataSourceAntigo = InstituicaoDAO.GetInstituicoes();
      if (InstituicaoDAO.Update((DataTable)gridInstituicoesParceiras.DataSource))
      {
        AuditoriaOperacaoDAO.UpdateAuditoria((DataTable)gridInstituicoesParceiras.DataSource, dataSourceAntigo, "nome", 9);
        MessageBox.Show("Alterações realizadas com sucesso.");
      }      
    }

    private void FormInstituicaoParceira_Load(object sender, EventArgs e)
    {
      // TODO: esta linha de código carrega dados na tabela 'faculdadeDataSet.instituicao'. Você pode movê-la ou removê-la conforme necessário.
      this.instituicaoTableAdapter.Fill(this.faculdadeDataSet.instituicao);

    }
  }
}
