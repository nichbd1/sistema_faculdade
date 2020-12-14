namespace Faculdade
{
  partial class FormUsuario
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
      this.components = new System.ComponentModel.Container();
      this.gridUsuarios = new System.Windows.Forms.DataGridView();
      this.buttonSave = new System.Windows.Forms.Button();
      this.faculdadeDataSet = new Faculdade.faculdadeDataSet();
      this.faculdadeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.usuarioTableAdapter = new Faculdade.faculdadeDataSetTableAdapters.usuarioTableAdapter();
      this.instituicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.instituicaoTableAdapter = new Faculdade.faculdadeDataSetTableAdapters.instituicaoTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sobrenomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.funcaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.idinstituicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.codigorecuperasenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSetBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.instituicaoBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridUsuarios
      // 
      this.gridUsuarios.AutoGenerateColumns = false;
      this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.sobrenomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.funcaoDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.idinstituicaoDataGridViewTextBoxColumn,
            this.codigorecuperasenhaDataGridViewTextBoxColumn});
      this.gridUsuarios.DataSource = this.usuarioBindingSource;
      this.gridUsuarios.Location = new System.Drawing.Point(12, 40);
      this.gridUsuarios.Name = "gridUsuarios";
      this.gridUsuarios.Size = new System.Drawing.Size(1045, 332);
      this.gridUsuarios.TabIndex = 0;
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(982, 378);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 1;
      this.buttonSave.Text = "Salvar";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // faculdadeDataSet
      // 
      this.faculdadeDataSet.DataSetName = "faculdadeDataSet";
      this.faculdadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // faculdadeDataSetBindingSource
      // 
      this.faculdadeDataSetBindingSource.DataSource = this.faculdadeDataSet;
      this.faculdadeDataSetBindingSource.Position = 0;
      // 
      // usuarioBindingSource
      // 
      this.usuarioBindingSource.DataMember = "usuario";
      this.usuarioBindingSource.DataSource = this.faculdadeDataSetBindingSource;
      // 
      // usuarioTableAdapter
      // 
      this.usuarioTableAdapter.ClearBeforeFill = true;
      // 
      // instituicaoBindingSource
      // 
      this.instituicaoBindingSource.DataMember = "instituicao";
      this.instituicaoBindingSource.DataSource = this.faculdadeDataSetBindingSource;
      // 
      // instituicaoTableAdapter
      // 
      this.instituicaoTableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
      this.idDataGridViewTextBoxColumn.HeaderText = "id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.Visible = false;
      // 
      // loginDataGridViewTextBoxColumn
      // 
      this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
      this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
      this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
      // 
      // nomeDataGridViewTextBoxColumn
      // 
      this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
      this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
      this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
      // 
      // sobrenomeDataGridViewTextBoxColumn
      // 
      this.sobrenomeDataGridViewTextBoxColumn.DataPropertyName = "sobrenome";
      this.sobrenomeDataGridViewTextBoxColumn.HeaderText = "Sobrenome";
      this.sobrenomeDataGridViewTextBoxColumn.Name = "sobrenomeDataGridViewTextBoxColumn";
      // 
      // cpfDataGridViewTextBoxColumn
      // 
      this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
      this.cpfDataGridViewTextBoxColumn.HeaderText = "CPF";
      this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
      // 
      // telefoneDataGridViewTextBoxColumn
      // 
      this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
      this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
      this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
      // 
      // emailDataGridViewTextBoxColumn
      // 
      this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
      this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
      this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
      // 
      // senhaDataGridViewTextBoxColumn
      // 
      this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
      this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
      this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
      // 
      // funcaoDataGridViewTextBoxColumn
      // 
      this.funcaoDataGridViewTextBoxColumn.DataPropertyName = "funcao";
      this.funcaoDataGridViewTextBoxColumn.HeaderText = "Função";
      this.funcaoDataGridViewTextBoxColumn.Name = "funcaoDataGridViewTextBoxColumn";
      // 
      // ativoDataGridViewCheckBoxColumn
      // 
      this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "ativo";
      this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
      this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
      // 
      // idinstituicaoDataGridViewTextBoxColumn
      // 
      this.idinstituicaoDataGridViewTextBoxColumn.DataPropertyName = "id_instituicao";
      this.idinstituicaoDataGridViewTextBoxColumn.DataSource = this.instituicaoBindingSource;
      this.idinstituicaoDataGridViewTextBoxColumn.DisplayMember = "nome";
      this.idinstituicaoDataGridViewTextBoxColumn.HeaderText = "Instituição";
      this.idinstituicaoDataGridViewTextBoxColumn.Name = "idinstituicaoDataGridViewTextBoxColumn";
      this.idinstituicaoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.idinstituicaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.idinstituicaoDataGridViewTextBoxColumn.ValueMember = "id";
      // 
      // codigorecuperasenhaDataGridViewTextBoxColumn
      // 
      this.codigorecuperasenhaDataGridViewTextBoxColumn.DataPropertyName = "codigo_recupera_senha";
      this.codigorecuperasenhaDataGridViewTextBoxColumn.HeaderText = "Código recupera senha";
      this.codigorecuperasenhaDataGridViewTextBoxColumn.Name = "codigorecuperasenhaDataGridViewTextBoxColumn";
      this.codigorecuperasenhaDataGridViewTextBoxColumn.Visible = false;
      // 
      // FormUsuario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1071, 410);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.gridUsuarios);
      this.Name = "FormUsuario";
      this.Text = "FormUsuario";
      this.Load += new System.EventHandler(this.FormUsuario_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSetBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.instituicaoBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridUsuarios;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.BindingSource faculdadeDataSetBindingSource;
    private faculdadeDataSet faculdadeDataSet;
    private System.Windows.Forms.BindingSource usuarioBindingSource;
    private faculdadeDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
    private System.Windows.Forms.BindingSource instituicaoBindingSource;
    private faculdadeDataSetTableAdapters.instituicaoTableAdapter instituicaoTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sobrenomeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn funcaoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn idinstituicaoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn codigorecuperasenhaDataGridViewTextBoxColumn;
  }
}