﻿using Faculdade.DAO;
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
  public partial class FormInstituicaoValidadora : Form
  {
    FaculdadeUtils.Funcao funcao;
    int addedrows = 0;
    public FormInstituicaoValidadora()
    {
      InitializeComponent();
      this.funcao = (FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"]);
      gridInstituicoesValidadoras.UserAddedRow += GridInstituicoesValidadoras_UserAddedRow;
      DataTable instituicoes = InstituicaoDAO.GetInstituicoes("where principal = 1");
      instituicoes.TableName = "instituicao_validadora";
      this.gridInstituicoesValidadoras.DataSource = instituicoes;
      gridInstituicoesValidadoras.Columns[8].Visible = false;

      List<FaculdadeUtils.Funcao> inserirExcluir = new List<FaculdadeUtils.Funcao>();
      inserirExcluir.Add(FaculdadeUtils.Funcao.Superintendente);
      List<FaculdadeUtils.Funcao> alterar = new List<FaculdadeUtils.Funcao>();
      alterar.Add(FaculdadeUtils.Funcao.Superintendente);

      if (!inserirExcluir.Contains((FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"])))
      {
        gridInstituicoesValidadoras.AllowUserToDeleteRows = false;
        gridInstituicoesValidadoras.AllowUserToAddRows = false;
      }
      if (!alterar.Contains((FaculdadeUtils.Funcao)Convert.ToChar(LoginSession.usuario["funcao"])))
          gridInstituicoesValidadoras.ReadOnly = true;
    }
    private void GridInstituicoesValidadoras_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
      gridInstituicoesValidadoras.Rows[e.Row.Index - 1].Cells[0].Value = InstituicaoDAO.GeraId() + addedrows;
      gridInstituicoesValidadoras.Rows[e.Row.Index - 1].Cells[7].Value = true;
      gridInstituicoesValidadoras.Rows[e.Row.Index - 1].Cells[8].Value = true;
      addedrows++;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
      DataTable dataSourceAntigo = InstituicaoDAO.GetInstituicoes();
      if (InstituicaoDAO.Update((DataTable)gridInstituicoesValidadoras.DataSource))
      {
        AuditoriaOperacaoDAO.UpdateAuditoria((DataTable)gridInstituicoesValidadoras.DataSource, dataSourceAntigo, "nome", 9);
        MessageBox.Show("Alterações realizadas com sucesso.");
      }
    }

    private void FormInstituicaoValidadora_Load(object sender, EventArgs e)
    {
      // TODO: esta linha de código carrega dados na tabela 'faculdadeDataSet.instituicao'. Você pode movê-la ou removê-la conforme necessário.
      this.instituicaoTableAdapter.Fill(this.faculdadeDataSet.instituicao);

    }
  }
}
