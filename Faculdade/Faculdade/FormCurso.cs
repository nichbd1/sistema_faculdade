using Faculdade.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
  public partial class FormCurso : Form
  {
    FaculdadeUtils.Funcao funcao;
    int addedrows = 0;
    public FormCurso()
    {
      InitializeComponent();
      this.funcao = (FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"]);      
      gridCursos.UserAddedRow += GridCursos_UserAddedRow;

      DataTable cursos = CursoDAO.GetCursos();
      if (cursos != null)
      {
        cursos.TableName = "curso";
        this.gridCursos.DataSource = cursos;          
      }
      gridCursos.Columns[0].Visible = false;
    }
    private void GridCursos_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      gridCursos.Rows[e.Row.Index - 1].Cells[0].Value = CursoDAO.GeraId() + addedrows;
      addedrows++;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      DataTable dataSourceAntigo = CursoDAO.GetCursos();
      if (CursoDAO.Update((DataTable)gridCursos.DataSource))
      {
        AuditoriaOperacaoDAO.UpdateAuditoria((DataTable)gridCursos.DataSource, dataSourceAntigo, "nome", 11);
        MessageBox.Show("Alterações realizadas com sucesso.");
      }
    }

    private void FormCurso_Load(object sender, EventArgs e)
    {
      // TODO: esta linha de código carrega dados na tabela 'faculdadeDataSet.curso'. Você pode movê-la ou removê-la conforme necessário.
      this.cursoTableAdapter.Fill(this.faculdadeDataSet.curso);

    }
  }
}
