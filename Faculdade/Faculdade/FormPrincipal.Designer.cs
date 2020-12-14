namespace Faculdade
{
  partial class FormPrincipal
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonInstituicaoValidadora = new System.Windows.Forms.Button();
      this.buttonUsuario = new System.Windows.Forms.Button();
      this.buttonInstituicoesParceiras = new System.Windows.Forms.Button();
      this.buttonCurso = new System.Windows.Forms.Button();
      this.buttonDiploma = new System.Windows.Forms.Button();
      this.buttonAuditoria = new System.Windows.Forms.Button();
      this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // buttonInstituicaoValidadora
      // 
      this.buttonInstituicaoValidadora.Location = new System.Drawing.Point(111, 78);
      this.buttonInstituicaoValidadora.Name = "buttonInstituicaoValidadora";
      this.buttonInstituicaoValidadora.Size = new System.Drawing.Size(220, 108);
      this.buttonInstituicaoValidadora.TabIndex = 0;
      this.buttonInstituicaoValidadora.Text = "Instituições Validadoras";
      this.buttonInstituicaoValidadora.UseVisualStyleBackColor = true;
      this.buttonInstituicaoValidadora.Click += new System.EventHandler(this.buttonInstituicaoValidadora_Click);
      // 
      // buttonUsuario
      // 
      this.buttonUsuario.Location = new System.Drawing.Point(391, 78);
      this.buttonUsuario.Name = "buttonUsuario";
      this.buttonUsuario.Size = new System.Drawing.Size(209, 108);
      this.buttonUsuario.TabIndex = 1;
      this.buttonUsuario.Text = "Usuários";
      this.buttonUsuario.UseVisualStyleBackColor = true;
      this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
      // 
      // buttonInstituicoesParceiras
      // 
      this.buttonInstituicoesParceiras.Location = new System.Drawing.Point(111, 222);
      this.buttonInstituicoesParceiras.Name = "buttonInstituicoesParceiras";
      this.buttonInstituicoesParceiras.Size = new System.Drawing.Size(220, 107);
      this.buttonInstituicoesParceiras.TabIndex = 2;
      this.buttonInstituicoesParceiras.Text = "Instituicões Parceiras";
      this.buttonInstituicoesParceiras.UseVisualStyleBackColor = true;
      this.buttonInstituicoesParceiras.Click += new System.EventHandler(this.buttonInstituicoesParceiras_Click);
      // 
      // buttonCurso
      // 
      this.buttonCurso.Location = new System.Drawing.Point(391, 222);
      this.buttonCurso.Name = "buttonCurso";
      this.buttonCurso.Size = new System.Drawing.Size(209, 107);
      this.buttonCurso.TabIndex = 3;
      this.buttonCurso.Text = "Cursos";
      this.buttonCurso.UseVisualStyleBackColor = true;
      this.buttonCurso.Click += new System.EventHandler(this.buttonCurso_Click);
      // 
      // buttonDiploma
      // 
      this.buttonDiploma.Location = new System.Drawing.Point(664, 78);
      this.buttonDiploma.Name = "buttonDiploma";
      this.buttonDiploma.Size = new System.Drawing.Size(205, 108);
      this.buttonDiploma.TabIndex = 4;
      this.buttonDiploma.Text = "Diplomas";
      this.buttonDiploma.UseVisualStyleBackColor = true;
      this.buttonDiploma.Click += new System.EventHandler(this.buttonDiploma_Click);
      // 
      // buttonAuditoria
      // 
      this.buttonAuditoria.Location = new System.Drawing.Point(664, 222);
      this.buttonAuditoria.Name = "buttonAuditoria";
      this.buttonAuditoria.Size = new System.Drawing.Size(205, 107);
      this.buttonAuditoria.TabIndex = 5;
      this.buttonAuditoria.Text = "Auditoria";
      this.buttonAuditoria.UseVisualStyleBackColor = true;
      this.buttonAuditoria.Click += new System.EventHandler(this.buttonAuditoria_Click);
      // 
      // linkLabelLogout
      // 
      this.linkLabelLogout.AutoSize = true;
      this.linkLabelLogout.Location = new System.Drawing.Point(958, 13);
      this.linkLabelLogout.Name = "linkLabelLogout";
      this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
      this.linkLabelLogout.TabIndex = 6;
      this.linkLabelLogout.TabStop = true;
      this.linkLabelLogout.Text = "Logout";
      this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
      // 
      // FormPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1049, 470);
      this.Controls.Add(this.linkLabelLogout);
      this.Controls.Add(this.buttonAuditoria);
      this.Controls.Add(this.buttonDiploma);
      this.Controls.Add(this.buttonCurso);
      this.Controls.Add(this.buttonInstituicoesParceiras);
      this.Controls.Add(this.buttonUsuario);
      this.Controls.Add(this.buttonInstituicaoValidadora);
      this.Name = "FormPrincipal";
      this.Text = "FormPrincipal";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonInstituicaoValidadora;
    private System.Windows.Forms.Button buttonUsuario;
    private System.Windows.Forms.Button buttonInstituicoesParceiras;
    private System.Windows.Forms.Button buttonCurso;
    private System.Windows.Forms.Button buttonDiploma;
    private System.Windows.Forms.Button buttonAuditoria;
    private System.Windows.Forms.LinkLabel linkLabelLogout;
  }
}