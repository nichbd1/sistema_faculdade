using Faculdade.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculdade
{
  public partial class FormRecuperarSenha : Form
  {
    public FormRecuperarSenha()
    {
      InitializeComponent();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      if ((textBoxNovaSenha.Text == textBoxConfirmaNovaSenha.Text))
      {
        if(string.IsNullOrEmpty(textBoxNovaSenha.Text)) {
          MessageBox.Show("Informe a nova senha.");
          return;
        }

        DataRow usuario = UsuarioDAO.GetUsuarios("*", $"where login = '{textBoxLogin.Text}'").Rows[0];

        if (textBoxCodigo.Text == usuario["codigo_recupera_senha"].ToString())
        {
          if (UsuarioDAO.UpdateSenha(textBoxNovaSenha.Text, usuario["id"].ToString()))
          {
            MessageBox.Show("Alterações realizadas com sucesso.");
          }
        }
        else
        {
          MessageBox.Show("Código inválido.");
        }
      }
      else
      {
        MessageBox.Show("As senhas informadas não são iguais.");
      }
    }
  }
}
