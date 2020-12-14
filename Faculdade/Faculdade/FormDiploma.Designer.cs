namespace Faculdade
{
  partial class FormDiploma
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
      this.gridDiplomas = new System.Windows.Forms.DataGridView();
      this.instituicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.faculdadeDataSet = new Faculdade.faculdadeDataSet();
      this.diplomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.buttonSave = new System.Windows.Forms.Button();
      this.diplomaTableAdapter = new Faculdade.faculdadeDataSetTableAdapters.diplomaTableAdapter();
      this.instituicaoTableAdapter = new Faculdade.faculdadeDataSetTableAdapters.instituicaoTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nomealunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cpfalunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataemissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.validadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.idusuariovalidacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idinstituicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridDiplomas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.instituicaoBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.diplomaBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridDiplomas
      // 
      this.gridDiplomas.AutoGenerateColumns = false;
      this.gridDiplomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridDiplomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomealunoDataGridViewTextBoxColumn,
            this.cpfalunoDataGridViewTextBoxColumn,
            this.dataemissaoDataGridViewTextBoxColumn,
            this.validadoDataGridViewCheckBoxColumn,
            this.idusuariovalidacaoDataGridViewTextBoxColumn,
            this.idinstituicaoDataGridViewTextBoxColumn});
      this.gridDiplomas.DataSource = this.diplomaBindingSource;
      this.gridDiplomas.Location = new System.Drawing.Point(22, 27);
      this.gridDiplomas.Name = "gridDiplomas";
      this.gridDiplomas.Size = new System.Drawing.Size(745, 373);
      this.gridDiplomas.TabIndex = 0;
      // 
      // instituicaoBindingSource
      // 
      this.instituicaoBindingSource.DataMember = "instituicao";
      this.instituicaoBindingSource.DataSource = this.faculdadeDataSet;
      // 
      // faculdadeDataSet
      // 
      this.faculdadeDataSet.DataSetName = "faculdadeDataSet";
      this.faculdadeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // diplomaBindingSource
      // 
      this.diplomaBindingSource.DataMember = "diploma";
      this.diplomaBindingSource.DataSource = this.faculdadeDataSet;
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(692, 415);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 1;
      this.buttonSave.Text = "Salvar";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // diplomaTableAdapter
      // 
      this.diplomaTableAdapter.ClearBeforeFill = true;
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
      // nomealunoDataGridViewTextBoxColumn
      // 
      this.nomealunoDataGridViewTextBoxColumn.DataPropertyName = "nome_aluno";
      this.nomealunoDataGridViewTextBoxColumn.HeaderText = "Nome do Aluno";
      this.nomealunoDataGridViewTextBoxColumn.Name = "nomealunoDataGridViewTextBoxColumn";
      this.nomealunoDataGridViewTextBoxColumn.Width = 250;
      // 
      // cpfalunoDataGridViewTextBoxColumn
      // 
      this.cpfalunoDataGridViewTextBoxColumn.DataPropertyName = "cpf_aluno";
      this.cpfalunoDataGridViewTextBoxColumn.HeaderText = "CPF";
      this.cpfalunoDataGridViewTextBoxColumn.Name = "cpfalunoDataGridViewTextBoxColumn";
      // 
      // dataemissaoDataGridViewTextBoxColumn
      // 
      this.dataemissaoDataGridViewTextBoxColumn.DataPropertyName = "data_emissao";
      this.dataemissaoDataGridViewTextBoxColumn.HeaderText = "Data de Emissão";
      this.dataemissaoDataGridViewTextBoxColumn.Name = "dataemissaoDataGridViewTextBoxColumn";
      // 
      // validadoDataGridViewCheckBoxColumn
      // 
      this.validadoDataGridViewCheckBoxColumn.DataPropertyName = "validado";
      this.validadoDataGridViewCheckBoxColumn.HeaderText = "Validado";
      this.validadoDataGridViewCheckBoxColumn.Name = "validadoDataGridViewCheckBoxColumn";
      // 
      // idusuariovalidacaoDataGridViewTextBoxColumn
      // 
      this.idusuariovalidacaoDataGridViewTextBoxColumn.DataPropertyName = "id_usuario_validacao";
      this.idusuariovalidacaoDataGridViewTextBoxColumn.HeaderText = "id_usuario_validacao";
      this.idusuariovalidacaoDataGridViewTextBoxColumn.Name = "idusuariovalidacaoDataGridViewTextBoxColumn";
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
      this.idinstituicaoDataGridViewTextBoxColumn.Width = 150;
      // 
      // FormDiploma
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.gridDiplomas);
      this.Name = "FormDiploma";
      this.Text = "Diplomas";
      this.Load += new System.EventHandler(this.FormDiploma_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridDiplomas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.instituicaoBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.diplomaBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridDiplomas;
    private System.Windows.Forms.Button buttonSave;
    private faculdadeDataSet faculdadeDataSet;
    private System.Windows.Forms.BindingSource diplomaBindingSource;
    private faculdadeDataSetTableAdapters.diplomaTableAdapter diplomaTableAdapter;
    private System.Windows.Forms.BindingSource instituicaoBindingSource;
    private faculdadeDataSetTableAdapters.instituicaoTableAdapter instituicaoTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomealunoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cpfalunoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataemissaoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn validadoDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idusuariovalidacaoDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn idinstituicaoDataGridViewTextBoxColumn;
  }
}