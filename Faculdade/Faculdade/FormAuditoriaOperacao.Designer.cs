namespace Faculdade
{
  partial class FormAuditoriaOperacao
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
      this.gridAuditorias = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridAuditorias)).BeginInit();
      this.SuspendLayout();
      // 
      // gridAuditorias
      // 
      this.gridAuditorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridAuditorias.Location = new System.Drawing.Point(12, 24);
      this.gridAuditorias.Name = "gridAuditorias";
      this.gridAuditorias.Size = new System.Drawing.Size(760, 389);
      this.gridAuditorias.TabIndex = 0;
      // 
      // FormAuditoriaOperacao
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.gridAuditorias);
      this.Name = "FormAuditoriaOperacao";
      this.Text = "Auditoria";
      ((System.ComponentModel.ISupportInitialize)(this.gridAuditorias)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridAuditorias;
  }
}