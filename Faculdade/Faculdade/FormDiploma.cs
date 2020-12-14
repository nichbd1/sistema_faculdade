using Faculdade.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
  public partial class FormDiploma : Form
  {
    FaculdadeUtils.Funcao funcao;
    int addedrows = 0;
    public FormDiploma()
    {
      InitializeComponent();

      this.funcao = (FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"]);

      DataTable diplomas = DiplomaDAO.GetDiplomas();
      diplomas.TableName = "diploma";
      this.gridDiplomas.DataSource = diplomas;
      this.gridDiplomas.UserAddedRow += GridDiplomas_UserAddedRow;
      this.gridDiplomas.CellContentClick += GridDiplomas_CellContentClick;     
    }

    private void GridDiplomas_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 4)
        gridDiplomas.Rows[e.RowIndex].Cells[5].Value = LoginSession.usuario["id"];
    }

    private void GridDiplomas_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      gridDiplomas.Rows[e.Row.Index - 1].Cells[0].Value = DiplomaDAO.GeraId() + addedrows;
      gridDiplomas.Rows[e.Row.Index - 1].Cells[4].Value = false;
      addedrows++;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      DataTable dataSourceAntigo = DiplomaDAO.GetDiplomas();      
      if (DiplomaDAO.Update((DataTable)gridDiplomas.DataSource))
      {
        AuditoriaOperacaoDAO.UpdateAuditoria((DataTable)gridDiplomas.DataSource, dataSourceAntigo, "cpf_aluno", 7);
        MessageBox.Show("Alterações realizadas com sucesso.");
      }
    }
    private void FormDiploma_Load(object sender, EventArgs e)
    {
      // TODO: esta linha de código carrega dados na tabela 'faculdadeDataSet.instituicao'. Você pode movê-la ou removê-la conforme necessário.
      this.instituicaoTableAdapter.Fill(this.faculdadeDataSet.instituicao);
      // TODO: esta linha de código carrega dados na tabela 'faculdadeDataSet.diploma'. Você pode movê-la ou removê-la conforme necessário.
      this.diplomaTableAdapter.Fill(this.faculdadeDataSet.diploma);
    }
  }
}
