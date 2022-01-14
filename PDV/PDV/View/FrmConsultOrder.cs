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
    public partial class FrmConsultOrder : Form
    {
        public FrmConsultOrder()
        {
            InitializeComponent();
        }

        private void pDVDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmConsultOrder_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'pDVDataSet.Order'. Você pode movê-la ou removê-la conforme necessário.
            this.orderTableAdapter.Fill(this.pDVDataSet.Order);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGetReport_Click(object sender, EventArgs e)
        {
            btnGetReport.BackColor = Color.DarkSeaGreen;

            FrmSelectDateOrder date = new FrmSelectDateOrder();
            date.ShowDialog();

            btnGetReport.BackColor = Color.WhiteSmoke;
        }
    }
}
