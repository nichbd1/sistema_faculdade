//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faculdade
{
  using System;
  using System.Collections.Generic;

  public partial class auditoria_operacao
  {
    public auditoria_operacao(
        decimal id,
        string login_usuario,
        string operacao,
        System.DateTime data_operacao,
        string valor_antigo,
        string valor_novo,
        Nullable<decimal> id_registro_alterado,
        string nome_registro_alterado,
        string coluna_alterada
      )
    {
      this.id = id;
      this.login_usuario = login_usuario;
      this.operacao = operacao;
      this.data_operacao = data_operacao;
      this.valor_antigo = valor_antigo;
      this.valor_novo = valor_novo;
      this.id_registro_alterado = id_registro_alterado;
      this.nome_registro_alterado = nome_registro_alterado;
      this.coluna_alterada = coluna_alterada;

    }
    public decimal id { get; set; }
    public string login_usuario { get; set; }
    public string operacao { get; set; }
    public System.DateTime data_operacao { get; set; }
    public string valor_antigo { get; set; }
    public string valor_novo { get; set; }
    public Nullable<decimal> id_registro_alterado { get; set; }
    public string nome_registro_alterado { get; set; }
    public string coluna_alterada { get; set; }
  }
}