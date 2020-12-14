namespace Faculdade
{
  partial class FormInstituicaoParceira
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
      this.gridInstituicoesParceiras = new System.Windows.Forms.DataGridView();
      this.buttonSave = new System.Windows.Forms.Button();
      this.faculdadeDataSet = new Faculdade.faculdadeDataSet();
      this.instituicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.instituicaoTableAdapter = new Faculdade.faculdadeDataSetTableAdapters.instituicaoTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.credenciamentomecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mantenedoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.principalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.acessoliberadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridInstituicoesParceiras)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.instituicaoBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridInstituicoesParceiras
      // 
      this.gridInstituicoesParceiras.AutoGenerateColumns = false;
      this.gridInstituicoesParceiras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridInstituicoesParceiras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.credenciamentomecDataGridViewTextBoxColumn,
            this.mantenedoraDataGridViewTextBoxColumn,
            this.principalDataGridViewCheckBoxColumn,
            this.acessoliberadoDataGridViewCheckBoxColumn});
      this.gridInstituicoesParceiras.DataSource = this.instituicaoBindingSource;
      this.gridInstituicoesParceiras.Location = new System.Drawing.Point(12, 30);
      this.gridInstituicoesParceiras.Name = "gridInstituicoesParceiras";
      this.gridInstituicoesParceiras.Size = new System.Drawing.Size(746, 354);
      this.gridInstituicoesParceiras.TabIndex = 0;
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(681, 390);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(77, 23);
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
      // instituicaoBindingSource
      // 
      this.instituicaoBindingSource.DataMember = "instituicao";
      this.instituicaoBindingSource.DataSource = this.faculdadeDataSet;
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
      // nomeDataGridViewTextBoxColumn
      // 
      this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
      this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
      this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
      // 
      // enderecoDataGridViewTextBoxColumn
      // 
      this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
      this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereço";
      this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
      // 
      // cidadeDataGridViewTextBoxColumn
      // 
      this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
      this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
      this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
      // 
      // ufDataGridViewTextBoxColumn
      // 
      this.ufDataGridViewTextBoxColumn.DataPropertyName = "uf";
      this.ufDataGridViewTextBoxColumn.HeaderText = "UF";
      this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
      // 
      // credenciamentomecDataGridViewTextBoxColumn
      // 
      this.credenciamentomecDataGridViewTextBoxColumn.DataPropertyName = "credenciamento_mec";
      this.credenciamentomecDataGridViewTextBoxColumn.HeaderText = "Credenciamento MEC";
      this.credenciamentomecDataGridViewTextBoxColumn.Name = "credenciamentomecDataGridViewTextBoxColumn";
      // 
      // mantenedoraDataGridViewTextBoxColumn
      // 
      this.mantenedoraDataGridViewTextBoxColumn.DataPropertyName = "mantenedora";
      this.mantenedoraDataGridViewTextBoxColumn.HeaderText = "Mantenedora";
      this.mantenedoraDataGridViewTextBoxColumn.Name = "mantenedoraDataGridViewTextBoxColumn";
      // 
      // principalDataGridViewCheckBoxColumn
      // 
      this.principalDataGridViewCheckBoxColumn.DataPropertyName = "principal";
      this.principalDataGridViewCheckBoxColumn.HeaderText = "principal";
      this.principalDataGridViewCheckBoxColumn.Name = "principalDataGridViewCheckBoxColumn";
      this.principalDataGridViewCheckBoxColumn.Visible = false;
      // 
      // acessoliberadoDataGridViewCheckBoxColumn
      // 
      this.acessoliberadoDataGridViewCheckBoxColumn.DataPropertyName = "acesso_liberado";
      this.acessoliberadoDataGridViewCheckBoxColumn.HeaderText = "Acesso Liberado";
      this.acessoliberadoDataGridViewCheckBoxColumn.Name = "acessoliberadoDataGridViewCheckBoxColumn";
      // 
      // FormInstituicaoParceira
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(772, 421);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.gridInstituicoesParceiras);
      this.Name = "FormInstituicaoParceira";
      this.Text = "FormInstituicaoParceira";
      this.Load += new System.EventHandler(this.FormInstituicaoParceira_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridInstituicoesParceiras)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.instituicaoBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridInstituicoesParceiras;
    private System.Windows.Forms.Button buttonSave;
    private faculdadeDataSet faculdadeDataSet;
    private System.Windows.Forms.BindingSource instituicaoBindingSource;
    private faculdadeDataSetTableAdapters.instituicaoTableAdapter instituicaoTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn credenciamentomecDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn mantenedoraDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn principalDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn acessoliberadoDataGridViewCheckBoxColumn;
  }
}