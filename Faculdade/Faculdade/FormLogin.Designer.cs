namespace Faculdade
{
  partial class FormLogin
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.labelLogin = new System.Windows.Forms.Label();
      this.textBoxLogin = new System.Windows.Forms.TextBox();
      this.labelSenha = new System.Windows.Forms.Label();
      this.textBoxSenha = new System.Windows.Forms.TextBox();
      this.labelSistema = new System.Windows.Forms.Label();
      this.buttonEntrar = new System.Windows.Forms.Button();
      this.linkRecuperaSenha = new System.Windows.Forms.LinkLabel();
      this.labelInformeLogin = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelLogin
      // 
      this.labelLogin.AutoSize = true;
      this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelLogin.Location = new System.Drawing.Point(12, 59);
      this.labelLogin.Name = "labelLogin";
      this.labelLogin.Size = new System.Drawing.Size(52, 20);
      this.labelLogin.TabIndex = 0;
      this.labelLogin.Text = "Login:";
      // 
      // textBoxLogin
      // 
      this.textBoxLogin.Location = new System.Drawing.Point(81, 59);
      this.textBoxLogin.Name = "textBoxLogin";
      this.textBoxLogin.Size = new System.Drawing.Size(277, 20);
      this.textBoxLogin.TabIndex = 1;
      // 
      // labelSenha
      // 
      this.labelSenha.AutoSize = true;
      this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSenha.Location = new System.Drawing.Point(12, 101);
      this.labelSenha.Name = "labelSenha";
      this.labelSenha.Size = new System.Drawing.Size(60, 20);
      this.labelSenha.TabIndex = 2;
      this.labelSenha.Text = "Senha:";
      // 
      // textBoxSenha
      // 
      this.textBoxSenha.Location = new System.Drawing.Point(81, 101);
      this.textBoxSenha.Name = "textBoxSenha";
      this.textBoxSenha.PasswordChar = '*';
      this.textBoxSenha.Size = new System.Drawing.Size(277, 20);
      this.textBoxSenha.TabIndex = 3;
      // 
      // labelSistema
      // 
      this.labelSistema.AutoSize = true;
      this.labelSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelSistema.Location = new System.Drawing.Point(94, 18);
      this.labelSistema.Name = "labelSistema";
      this.labelSistema.Size = new System.Drawing.Size(237, 25);
      this.labelSistema.TabIndex = 4;
      this.labelSistema.Text = "SISTEMA FACULDADE";
      // 
      // buttonEntrar
      // 
      this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonEntrar.Location = new System.Drawing.Point(250, 134);
      this.buttonEntrar.Name = "buttonEntrar";
      this.buttonEntrar.Size = new System.Drawing.Size(108, 24);
      this.buttonEntrar.TabIndex = 5;
      this.buttonEntrar.Text = "Entrar";
      this.buttonEntrar.UseVisualStyleBackColor = true;
      this.buttonEntrar.Click += new System.EventHandler(this.button1_Click);
      // 
      // linkRecuperaSenha
      // 
      this.linkRecuperaSenha.AutoSize = true;
      this.linkRecuperaSenha.Location = new System.Drawing.Point(81, 134);
      this.linkRecuperaSenha.Name = "linkRecuperaSenha";
      this.linkRecuperaSenha.Size = new System.Drawing.Size(108, 13);
      this.linkRecuperaSenha.TabIndex = 6;
      this.linkRecuperaSenha.TabStop = true;
      this.linkRecuperaSenha.Text = "Esqueci minha senha";
      this.linkRecuperaSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecuperaSenha_LinkClicked);
      // 
      // labelInformeLogin
      // 
      this.labelInformeLogin.AutoSize = true;
      this.labelInformeLogin.ForeColor = System.Drawing.Color.Red;
      this.labelInformeLogin.Location = new System.Drawing.Point(84, 82);
      this.labelInformeLogin.Name = "labelInformeLogin";
      this.labelInformeLogin.Size = new System.Drawing.Size(76, 13);
      this.labelInformeLogin.TabIndex = 7;
      this.labelInformeLogin.Text = "Informe o login";
      this.labelInformeLogin.Visible = false;
      // 
      // FormLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(424, 173);
      this.Controls.Add(this.labelInformeLogin);
      this.Controls.Add(this.linkRecuperaSenha);
      this.Controls.Add(this.buttonEntrar);
      this.Controls.Add(this.labelSistema);
      this.Controls.Add(this.textBoxSenha);
      this.Controls.Add(this.labelSenha);
      this.Controls.Add(this.textBoxLogin);
      this.Controls.Add(this.labelLogin);
      this.Name = "FormLogin";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelLogin;
    private System.Windows.Forms.TextBox textBoxLogin;
    private System.Windows.Forms.Label labelSenha;
    private System.Windows.Forms.TextBox textBoxSenha;
    private System.Windows.Forms.Label labelSistema;
    private System.Windows.Forms.Button buttonEntrar;
    private System.Windows.Forms.LinkLabel linkRecuperaSenha;
    private System.Windows.Forms.Label labelInformeLogin;
  }
}

