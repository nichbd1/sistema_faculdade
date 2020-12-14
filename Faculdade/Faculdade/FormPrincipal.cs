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
  public partial class FormPrincipal : Form
  {
    public FaculdadeUtils.Funcao funcao;

    public FormPrincipal()
    {
      InitializeComponent();
      this.funcao = (FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"]);
      if (funcao == FaculdadeUtils.Funcao.Funcionario)
      {
        buttonAuditoria.Enabled = false;
      }
      if (!(funcao == FaculdadeUtils.Funcao.Diretor || funcao == FaculdadeUtils.Funcao.Superintendente))
      {
        buttonUsuario.Enabled = false;
      }
    }

    private void buttonInstituicaoValidadora_Click(object sender, EventArgs e)
    {          
      FormInstituicaoValidadora formInstituicaoValidadora = new FormInstituicaoValidadora();
      formInstituicaoValidadora.ShowDialog();
    }

    private void buttonUsuario_Click(object sender, EventArgs e)
    {
      FormUsuario formUsuario = new FormUsuario();
      formUsuario.ShowDialog();
    }

    private void buttonInstituicoesParceiras_Click(object sender, EventArgs e)
    {
      FormInstituicaoParceira formInstituicaoParceira = new FormInstituicaoParceira();
      formInstituicaoParceira.ShowDialog();
    }

    private void buttonCurso_Click(object sender, EventArgs e)
    {
      FormCurso formCurso = new FormCurso();
      formCurso.ShowDialog();
    }

    private void buttonDiploma_Click(object sender, EventArgs e)
    {
      FormDiploma formDiploma = new FormDiploma();
      formDiploma.ShowDialog();
    }

    private void buttonAuditoria_Click(object sender, EventArgs e)
    {
      FormAuditoriaOperacao formAuditoriaOperacao = new FormAuditoriaOperacao();
      formAuditoriaOperacao.ShowDialog();
    }

    private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.Hide();
      LoginSession.usuario = null;
      FormLogin formLogin = new FormLogin();
      formLogin.ShowDialog();
    }
  }
}
