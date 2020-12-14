using Faculdade.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Faculdade
{
  public partial class FormUsuario : Form
  {
    FaculdadeUtils.Funcao funcao;
    int addedrows = 0;
    public FormUsuario()
    {
      InitializeComponent();

      this.funcao = (FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"]);
     
      DataTable usuarios = UsuarioDAO.GetUsuarios("*", $"where id_instituicao = {LoginSession.usuario["id_instituicao"]}");
      usuarios.TableName = "usuario";

      this.gridUsuarios.DataSource = usuarios;
      
      this.gridUsuarios.UserAddedRow += GridUsuarios_UserAddedRow;
      this.gridUsuarios.CellEndEdit += GridUsuarios_CellEndEdit;
      this.gridUsuarios.Columns[0].Visible = false;
      this.gridUsuarios.Columns[11].Visible = false;

      if (Convert.ToBoolean(LoginSession.instituicao["principal"]))
      {
        if (usuarios.Rows.Count > 0)
        {
          if (funcao != FaculdadeUtils.Funcao.Diretor)
          {
            gridUsuarios.AllowUserToDeleteRows = false;
            gridUsuarios.Columns[0].ReadOnly = true;
            gridUsuarios.Columns[1].ReadOnly = true;
            gridUsuarios.Columns[2].ReadOnly = true;
            gridUsuarios.Columns[3].ReadOnly = true;
            gridUsuarios.Columns[4].ReadOnly = true;
            gridUsuarios.Columns[5].ReadOnly = true;
            gridUsuarios.Columns[6].ReadOnly = true;
            gridUsuarios.Columns[7].ReadOnly = true;
            gridUsuarios.Columns[9].ReadOnly = true;
            if (funcao != FaculdadeUtils.Funcao.Superintendente)
              gridUsuarios.Columns[8].ReadOnly = true;
          }
          else
          {
            gridUsuarios.Columns[8].ReadOnly = false;
          }
        }
      }
    }

    private void GridUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 1)
      {
        DataTable usuario = UsuarioDAO.GetUsuarios("*", $" where login = '{gridUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}'");        
        if (usuario.Rows.Count > 0)
        {
          MessageBox.Show("Já existe um usuário com esse login.");
          gridUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
        }
      }
    }

    private void GridUsuarios_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      addedrows++;
      gridUsuarios.Rows[e.Row.Index - 1].Cells[0].Value = InstituicaoDAO.GeraId() + addedrows;      
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      DataTable dataSourceAntigo = UsuarioDAO.GetUsuarios();
      if (UsuarioDAO.Update((DataTable)gridUsuarios.DataSource))
      {
        AuditoriaOperacaoDAO.UpdateAuditoria((DataTable)gridUsuarios.DataSource, dataSourceAntigo, "login", 12);
        MessageBox.Show("Alterações realizadas com sucesso.");
      }
    }

    private void FormUsuario_Load(object sender, EventArgs e)
    {
      // TODO: esta linha de código carrega dados na tabela 'faculdadeDataSet.instituicao'. Você pode movê-la ou removê-la conforme necessário.
      this.instituicaoTableAdapter.Fill(this.faculdadeDataSet.instituicao);
      // TODO: esta linha de código carrega dados na tabela 'faculdadeDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
      this.usuarioTableAdapter.Fill(this.faculdadeDataSet.usuario);

    }
  }
}

