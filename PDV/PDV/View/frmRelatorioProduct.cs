using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.View
{
    public partial class frmRelatorioProduct : Form
    {
        public frmRelatorioProduct()
        {
            InitializeComponent();
        }

        private void frmRelatorioProduct_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pDVDataSet.Product'. Você pode movê-la ou removê-la conforme necessário.
            this.productTableAdapter1.Fill(this.pDVDataSet.Product);
            // TODO: esta linha de código carrega dados na tabela 'dataSetProduct.Product'. Você pode movê-la ou removê-la conforme necessário.
            this.productTableAdapter.Fill(this.dataSetProduct.Product);

            this.reportViewer1.RefreshReport();
        }
    }
}
