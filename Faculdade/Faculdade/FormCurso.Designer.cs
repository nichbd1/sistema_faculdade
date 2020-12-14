namespace Faculdade
{
  partial class FormCurso
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
      this.gridCursos = new System.Windows.Forms.DataGridView();
      this.buttonSave = new System.Windows.Forms.Button();
      this.faculdadeDataSet = new Faculdade.faculdadeDataSet();
      this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cursoTableAdapter = new Faculdade.faculdadeDataSetTableAdapters.cursoTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.grauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.codigoMECDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.autorizaçãoDOUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataautorizacaoDOUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.reconhecimentoDOUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.datareconhecimentoDOUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.renovacaoDOUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.datarenovacaoDOUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.observaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridCursos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridCursos
      // 
      this.gridCursos.AutoGenerateColumns = false;
      this.gridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.grauDataGridViewTextBoxColumn,
            this.codigoMECDataGridViewTextBoxColumn,
            this.autorizaçãoDOUDataGridViewTextBoxColumn,
            this.dataautorizacaoDOUDataGridViewTextBoxColumn,
            this.reconhecimentoDOUDataGridViewTextBoxColumn,
            this.datareconhecimentoDOUDataGridViewTextBoxColumn,
            this.renovacaoDOUDataGridViewTextBoxColumn,
            this.datarenovacaoDOUDataGridViewTextBoxColumn,
            this.observaçãoDataGridViewTextBoxColumn});
      this.gridCursos.DataSource = this.cursoBindingSource;
      this.gridCursos.Location = new System.Drawing.Point(12, 33);
      this.gridCursos.Name = "gridCursos";
      this.gridCursos.Size = new System.Drawing.Size(1044, 370);
      this.gridCursos.TabIndex = 0;
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(981, 409);
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
      // cursoBindingSource
      // 
      this.cursoBindingSource.DataMember = "curso";
      this.cursoBindingSource.DataSource = this.faculdadeDataSet;
      // 
      // cursoTableAdapter
      // 
      this.cursoTableAdapter.ClearBeforeFill = true;
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
      // grauDataGridViewTextBoxColumn
      // 
      this.grauDataGridViewTextBoxColumn.DataPropertyName = "grau";
      this.grauDataGridViewTextBoxColumn.HeaderText = "Grau";
      this.grauDataGridViewTextBoxColumn.Name = "grauDataGridViewTextBoxColumn";
      // 
      // codigoMECDataGridViewTextBoxColumn
      // 
      this.codigoMECDataGridViewTextBoxColumn.DataPropertyName = "codigo_MEC";
      this.codigoMECDataGridViewTextBoxColumn.HeaderText = "Código MEC";
      this.codigoMECDataGridViewTextBoxColumn.Name = "codigoMECDataGridViewTextBoxColumn";
      // 
      // autorizaçãoDOUDataGridViewTextBoxColumn
      // 
      this.autorizaçãoDOUDataGridViewTextBoxColumn.DataPropertyName = "autorização_DOU";
      this.autorizaçãoDOUDataGridViewTextBoxColumn.HeaderText = "Autorização DOU";
      this.autorizaçãoDOUDataGridViewTextBoxColumn.Name = "autorizaçãoDOUDataGridViewTextBoxColumn";
      // 
      // dataautorizacaoDOUDataGridViewTextBoxColumn
      // 
      this.dataautorizacaoDOUDataGridViewTextBoxColumn.DataPropertyName = "data_autorizacao_DOU";
      this.dataautorizacaoDOUDataGridViewTextBoxColumn.HeaderText = "Data Autorizacao DOU";
      this.dataautorizacaoDOUDataGridViewTextBoxColumn.Name = "dataautorizacaoDOUDataGridViewTextBoxColumn";
      // 
      // reconhecimentoDOUDataGridViewTextBoxColumn
      // 
      this.reconhecimentoDOUDataGridViewTextBoxColumn.DataPropertyName = "reconhecimento_DOU";
      this.reconhecimentoDOUDataGridViewTextBoxColumn.HeaderText = "Reconhecimento DOU";
      this.reconhecimentoDOUDataGridViewTextBoxColumn.Name = "reconhecimentoDOUDataGridViewTextBoxColumn";
      // 
      // datareconhecimentoDOUDataGridViewTextBoxColumn
      // 
      this.datareconhecimentoDOUDataGridViewTextBoxColumn.DataPropertyName = "data_reconhecimento_DOU";
      this.datareconhecimentoDOUDataGridViewTextBoxColumn.HeaderText = "Data Reconhecimento DOU";
      this.datareconhecimentoDOUDataGridViewTextBoxColumn.Name = "datareconhecimentoDOUDataGridViewTextBoxColumn";
      // 
      // renovacaoDOUDataGridViewTextBoxColumn
      // 
      this.renovacaoDOUDataGridViewTextBoxColumn.DataPropertyName = "renovacao_DOU";
      this.renovacaoDOUDataGridViewTextBoxColumn.HeaderText = "Renovacao DOU";
      this.renovacaoDOUDataGridViewTextBoxColumn.Name = "renovacaoDOUDataGridViewTextBoxColumn";
      // 
      // datarenovacaoDOUDataGridViewTextBoxColumn
      // 
      this.datarenovacaoDOUDataGridViewTextBoxColumn.DataPropertyName = "data_renovacao_DOU";
      this.datarenovacaoDOUDataGridViewTextBoxColumn.HeaderText = "Data Renovacao DOU";
      this.datarenovacaoDOUDataGridViewTextBoxColumn.Name = "datarenovacaoDOUDataGridViewTextBoxColumn";
      // 
      // observaçãoDataGridViewTextBoxColumn
      // 
      this.observaçãoDataGridViewTextBoxColumn.DataPropertyName = "observação";
      this.observaçãoDataGridViewTextBoxColumn.HeaderText = "Observação";
      this.observaçãoDataGridViewTextBoxColumn.Name = "observaçãoDataGridViewTextBoxColumn";
      // 
      // FormCurso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1070, 440);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.gridCursos);
      this.Name = "FormCurso";
      this.Text = "Cursos";
      this.Load += new System.EventHandler(this.FormCurso_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridCursos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.faculdadeDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridCursos;
    private System.Windows.Forms.Button buttonSave;
    private faculdadeDataSet faculdadeDataSet;
    private System.Windows.Forms.BindingSource cursoBindingSource;
    private faculdadeDataSetTableAdapters.cursoTableAdapter cursoTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn grauDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn codigoMECDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn autorizaçãoDOUDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataautorizacaoDOUDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn reconhecimentoDOUDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn datareconhecimentoDOUDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn renovacaoDOUDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn datarenovacaoDOUDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn observaçãoDataGridViewTextBoxColumn;
  }
}