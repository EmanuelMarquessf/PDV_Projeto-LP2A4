
namespace PDV.View
{
    partial class FrmConsultOrder
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
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pDVDataSet = new PDV.PDVDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new PDV.PDVDataSetTableAdapters.OrderTableAdapter();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGetReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.pDVDataSet;
            // 
            // pDVDataSet
            // 
            this.pDVDataSet.DataSetName = "PDVDataSet";
            this.pDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.pDVDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataMember = "Order";
            this.orderBindingSource2.DataSource = this.pDVDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.nameClientDataGridViewTextBoxColumn,
            this.dateOrderDataGridViewTextBoxColumn,
            this.amountOrderDataGridViewTextBoxColumn,
            this.payFormDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(-6, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(594, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderBindingSource3
            // 
            this.orderBindingSource3.DataMember = "Order";
            this.orderBindingSource3.DataSource = this.pDVDataSet;
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "Id_Order";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOrderDataGridViewTextBoxColumn.Width = 25;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "Id_Client";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameClientDataGridViewTextBoxColumn
            // 
            this.nameClientDataGridViewTextBoxColumn.DataPropertyName = "Name_Client";
            this.nameClientDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameClientDataGridViewTextBoxColumn.Name = "nameClientDataGridViewTextBoxColumn";
            this.nameClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameClientDataGridViewTextBoxColumn.Width = 165;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "Date_Order";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOrderDataGridViewTextBoxColumn
            // 
            this.amountOrderDataGridViewTextBoxColumn.DataPropertyName = "Amount_Order";
            this.amountOrderDataGridViewTextBoxColumn.HeaderText = "Valor (R$)";
            this.amountOrderDataGridViewTextBoxColumn.Name = "amountOrderDataGridViewTextBoxColumn";
            this.amountOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payFormDataGridViewTextBoxColumn
            // 
            this.payFormDataGridViewTextBoxColumn.DataPropertyName = "Pay_Form";
            this.payFormDataGridViewTextBoxColumn.HeaderText = "Forma de Pagamento";
            this.payFormDataGridViewTextBoxColumn.Name = "payFormDataGridViewTextBoxColumn";
            this.payFormDataGridViewTextBoxColumn.ReadOnly = true;
            this.payFormDataGridViewTextBoxColumn.Width = 143;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 217);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(480, 217);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(99, 27);
            this.btnGetReport.TabIndex = 2;
            this.btnGetReport.Text = "Gerar Relatório";
            this.btnGetReport.UseVisualStyleBackColor = true;
            this.btnGetReport.Click += new System.EventHandler(this.btnGetReport_Click);
            // 
            // FrmConsultOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 248);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(603, 287);
            this.MinimumSize = new System.Drawing.Size(603, 287);
            this.Name = "FrmConsultOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultOrder";
            this.Load += new System.EventHandler(this.FrmConsultOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PDVDataSet pDVDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private PDVDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payFormDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGetReport;
    }
}