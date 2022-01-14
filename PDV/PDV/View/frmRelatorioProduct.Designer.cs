
namespace PDV.View
{
    partial class frmRelatorioProduct
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pDVDataSet = new PDV.PDVDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetProduct = new PDV.DataSetProduct();
            this.productTableAdapter = new PDV.DataSetProductTableAdapters.ProductTableAdapter();
            this.productTableAdapter1 = new PDV.PDVDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.pDVDataSet;
            // 
            // pDVDataSet
            // 
            this.pDVDataSet.DataSetName = "PDVDataSet";
            this.pDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dtsProduct";
            reportDataSource2.Value = this.productBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PDV.Relatorios.Product.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(677, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetProduct
            // 
            this.dataSetProduct.DataSetName = "DataSetProduct";
            this.dataSetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // frmRelatorioProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.reportViewer1);
            this.MaximumSize = new System.Drawing.Size(693, 489);
            this.MinimumSize = new System.Drawing.Size(693, 489);
            this.Name = "frmRelatorioProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioProduct";
            this.Load += new System.EventHandler(this.frmRelatorioProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetProduct dataSetProduct;
        private DataSetProductTableAdapters.ProductTableAdapter productTableAdapter;
        private PDVDataSet pDVDataSet;
        private PDVDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}