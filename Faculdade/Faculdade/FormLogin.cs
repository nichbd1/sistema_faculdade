using MySql.Data.MySqlClient;
using Faculdade.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Faculdade
{
  public partial class FormLogin : Form
  {
    public FormLogin()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DataRow usuario = GetInformacoesUsuario();
      if (string.IsNullOrWhiteSpace(textBoxLogin.Text) || string.IsNullOrWhiteSpace(textBoxSenha.Text))
      {
        MessageBox.Show("É necessário digitar usuário e senha.");
        return;
      }
      else if (!VerificaUsuarioeSenha(usuario))
      {
        MessageBox.Show("Usuário ou senha inválidos.");
        return;
      }
      else if (!VerificaUsuarioAtivo(usuario))
      {
        MessageBox.Show("Usuário inativo.");
        return;
      }
      //else if (!VerificaHorario())
      //{
      //  MessageBox.Show("Sistema disponível apenas em horário comercial. (Seg à Sex de 8h às 18h)");
      //  return;
      //}
      else
      {
        LoginSession.usuario = usuario;
        LoginSession.instituicao = InstituicaoDAO.GetInstituicoes($" where id={usuario["id_instituicao"]}", "*").Rows[0];
        if(!Convert.ToBoolean(LoginSession.usuario["ativo"]))
        {
          MessageBox.Show("Usuário inativo. Contate o superintendente.");
          return;
        }
        else if (!Convert.ToBoolean(LoginSession.instituicao["acesso_liberado"]))
        {
          MessageBox.Show("Sua instituição não possui o acesso liberado. Caso o problema persista, contate a instituição validadora.");
          return;
        }
        this.Hide();
        FormPrincipal formPrincipal = new FormPrincipal();
        formPrincipal.ShowDialog();
      }
    }

    private bool VerificaHorario()
    {
      if (DateTime.Now.DayOfWeek >= DayOfWeek.Monday && DateTime.Now.DayOfWeek <= DayOfWeek.Friday && DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 18)
      {
        return true;
      }
      return false;
    }

    private bool VerificaUsuarioAtivo(DataRow usuario)
    {
      if (usuario != null && Convert.ToBoolean(usuario["ativo"]))
        return true;

      return false;
    }

    private bool VerificaUsuarioeSenha(DataRow usuario)
    {
      if (usuario != null && usuario["senha"].ToString() == textBoxSenha.Text)
        return true;

      return false;
    }

    private DataRow GetInformacoesUsuario()
    {
      DataRowCollection usuarios = UsuarioDAO.GetUsuarios("*", $"where login = '{textBoxLogin.Text}'").Rows;

      if (usuarios.Count > 0)
        return usuarios[0];

      return null;
    }

    private void linkRecuperaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      labelInformeLogin.Visible = false;
      if (string.IsNullOrEmpty(textBoxLogin.Text))
      {
        labelInformeLogin.Visible = true;
      }
      else
      {
        DataRow usuario = GetInformacoesUsuario();

        string codigo = (new Random().Next(10000, 99999)).ToString();
        UsuarioDAO.UpdateCodigoSenha(codigo, usuario["id"].ToString());
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
          Credentials = new NetworkCredential("sistemafaculdade.noreply@gmail.com", "sistemafaculdade*"),
          EnableSsl = true
        };
        client.Send("sistemafaculdade.noreply@gmail.com", usuario["email"].ToString(), "Recuperação de Senha - Sistema Faculdade", "Código para recuperação de senha: " + codigo);
        FormRecuperarSenha formRecuperarSenha = new FormRecuperarSenha();
        formRecuperarSenha.ShowDialog();
      }
    }
  }
}


