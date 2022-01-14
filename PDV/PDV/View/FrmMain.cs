using PDV.Model;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnProductMenuItem_Click(object sender, EventArgs e)
        {
            BtnProductMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultProduct product = new FrmConsultProduct();
            product.ShowDialog();

            BtnProductMenuItem.BackColor = Color.WhiteSmoke;


        }

        private void btnClientMenuItem_Click(object sender, EventArgs e)
        {
            btnClientMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultClient client = new FrmConsultClient();
            client.ShowDialog();

            btnClientMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void btnAdmMenuItem_Click(object sender, EventArgs e)
        {
            btnAdmMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultAdm adm = new FrmConsultAdm();
            adm.ShowDialog();

            btnAdmMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnClientMenuItem.BackColor = Color.DarkSeaGreen;

            this.Visible = false;
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            this.Visible = true;

            btnClientMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void btnOrderMenuItem_Click(object sender, EventArgs e)
        {
            btnClientMenuItem.BackColor = Color.DarkSeaGreen;

            FrmConsultOrder order = new FrmConsultOrder();
            order.ShowDialog();

            btnClientMenuItem.BackColor = Color.WhiteSmoke;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void btnReportMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
