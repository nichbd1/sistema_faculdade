namespace Faculdade
{
  partial class FormRecuperarSenha
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
      this.textBoxCodigo = new System.Windows.Forms.TextBox();
      this.textBoxNovaSenha = new System.Windows.Forms.TextBox();
      this.textBoxConfirmaNovaSenha = new System.Windows.Forms.TextBox();
      this.buttonSave = new System.Windows.Forms.Button();
      this.textBoxLogin = new System.Windows.Forms.TextBox();
      this.labelLogin = new System.Windows.Forms.Label();
      this.labelCodigo = new System.Windows.Forms.Label();
      this.labelNovaSenha = new System.Windows.Forms.Label();
      this.labelConfirmaNovaSenha = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBoxCodigo
      // 
      this.textBoxCodigo.Location = new System.Drawing.Point(185, 76);
      this.textBoxCodigo.Name = "textBoxCodigo";
      this.textBoxCodigo.Size = new System.Drawing.Size(167, 20);
      this.textBoxCodigo.TabIndex = 0;
      // 
      // textBoxNovaSenha
      // 
      this.textBoxNovaSenha.Location = new System.Drawing.Point(185, 116);
      this.textBoxNovaSenha.Name = "textBoxNovaSenha";
      this.textBoxNovaSenha.Size = new System.Drawing.Size(167, 20);
      this.textBoxNovaSenha.TabIndex = 1;
      // 
      // textBoxConfirmaNovaSenha
      // 
      this.textBoxConfirmaNovaSenha.Location = new System.Drawing.Point(185, 159);
      this.textBoxConfirmaNovaSenha.Name = "textBoxConfirmaNovaSenha";
      this.textBoxConfirmaNovaSenha.Size = new System.Drawing.Size(167, 20);
      this.textBoxConfirmaNovaSenha.TabIndex = 2;
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(362, 212);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 3;
      this.buttonSave.Text = "Alterar";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // textBoxLogin
      // 
      this.textBoxLogin.Location = new System.Drawing.Point(185, 41);
      this.textBoxLogin.Name = "textBoxLogin";
      this.textBoxLogin.Size = new System.Drawing.Size(167, 20);
      this.textBoxLogin.TabIndex = 4;
      // 
      // labelLogin
      // 
      this.labelLogin.AutoSize = true;
      this.labelLogin.Location = new System.Drawing.Point(132, 41);
      this.labelLogin.Name = "labelLogin";
      this.labelLogin.Size = new System.Drawing.Size(36, 13);
      this.labelLogin.TabIndex = 5;
      this.labelLogin.Text = "Login:";
      // 
      // labelCodigo
      // 
      this.labelCodigo.AutoSize = true;
      this.labelCodigo.Location = new System.Drawing.Point(125, 79);
      this.labelCodigo.Name = "labelCodigo";
      this.labelCodigo.Size = new System.Drawing.Size(43, 13);
      this.labelCodigo.TabIndex = 6;
      this.labelCodigo.Text = "Código:";
      // 
      // labelNovaSenha
      // 
      this.labelNovaSenha.AutoSize = true;
      this.labelNovaSenha.Location = new System.Drawing.Point(100, 119);
      this.labelNovaSenha.Name = "labelNovaSenha";
      this.labelNovaSenha.Size = new System.Drawing.Size(68, 13);
      this.labelNovaSenha.TabIndex = 7;
      this.labelNovaSenha.Text = "Nova senha:";
      // 
      // labelConfirmaNovaSenha
      // 
      this.labelConfirmaNovaSenha.AutoSize = true;
      this.labelConfirmaNovaSenha.Location = new System.Drawing.Point(55, 162);
      this.labelConfirmaNovaSenha.Name = "labelConfirmaNovaSenha";
      this.labelConfirmaNovaSenha.Size = new System.Drawing.Size(113, 13);
      this.labelConfirmaNovaSenha.TabIndex = 8;
      this.labelConfirmaNovaSenha.Text = "Confirmar nova senha:";
      // 
      // FormRecuperarSenha
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(512, 274);
      this.Controls.Add(this.labelConfirmaNovaSenha);
      this.Controls.Add(this.labelNovaSenha);
      this.Controls.Add(this.labelCodigo);
      this.Controls.Add(this.labelLogin);
      this.Controls.Add(this.textBoxLogin);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.textBoxConfirmaNovaSenha);
      this.Controls.Add(this.textBoxNovaSenha);
      this.Controls.Add(this.textBoxCodigo);
      this.Name = "FormRecuperarSenha";
      this.Text = "FormRecuperarSenha";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxCodigo;
    private System.Windows.Forms.TextBox textBoxNovaSenha;
    private System.Windows.Forms.TextBox textBoxConfirmaNovaSenha;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.TextBox textBoxLogin;
    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.Label labelCodigo;
    private System.Windows.Forms.Label labelNovaSenha;
    private System.Windows.Forms.Label labelConfirmaNovaSenha;
  }
}