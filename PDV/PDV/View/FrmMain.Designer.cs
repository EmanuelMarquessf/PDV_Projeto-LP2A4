
namespace PDV.View
{
    partial class FrmMain
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnProductMenuItem = new System.Windows.Forms.Button();
            this.btnClientMenuItem = new System.Windows.Forms.Button();
            this.btnAdmMenuItem = new System.Windows.Forms.Button();
            this.btnOrderMenuItem = new System.Windows.Forms.Button();
            this.btnReportMenuItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.LblTitle.Location = new System.Drawing.Point(161, 9);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(85, 37);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Menu";
            // 
            // BtnProductMenuItem
            // 
            this.BtnProductMenuItem.Location = new System.Drawing.Point(218, 69);
            this.BtnProductMenuItem.Name = "BtnProductMenuItem";
            this.BtnProductMenuItem.Size = new System.Drawing.Size(149, 37);
            this.BtnProductMenuItem.TabIndex = 1;
            this.BtnProductMenuItem.Text = "Produtos";
            this.BtnProductMenuItem.UseVisualStyleBackColor = true;
            this.BtnProductMenuItem.Click += new System.EventHandler(this.BtnProductMenuItem_Click);
            // 
            // btnClientMenuItem
            // 
            this.btnClientMenuItem.Location = new System.Drawing.Point(44, 69);
            this.btnClientMenuItem.Name = "btnClientMenuItem";
            this.btnClientMenuItem.Size = new System.Drawing.Size(149, 37);
            this.btnClientMenuItem.TabIndex = 2;
            this.btnClientMenuItem.Text = "Clientes";
            this.btnClientMenuItem.UseVisualStyleBackColor = true;
            this.btnClientMenuItem.Click += new System.EventHandler(this.btnClientMenuItem_Click);
            // 
            // btnAdmMenuItem
            // 
            this.btnAdmMenuItem.Location = new System.Drawing.Point(44, 131);
            this.btnAdmMenuItem.Name = "btnAdmMenuItem";
            this.btnAdmMenuItem.Size = new System.Drawing.Size(149, 37);
            this.btnAdmMenuItem.TabIndex = 3;
            this.btnAdmMenuItem.Text = "Administradores";
            this.btnAdmMenuItem.UseVisualStyleBackColor = true;
            this.btnAdmMenuItem.Click += new System.EventHandler(this.btnAdmMenuItem_Click);
            // 
            // btnOrderMenuItem
            // 
            this.btnOrderMenuItem.Location = new System.Drawing.Point(218, 131);
            this.btnOrderMenuItem.Name = "btnOrderMenuItem";
            this.btnOrderMenuItem.Size = new System.Drawing.Size(149, 37);
            this.btnOrderMenuItem.TabIndex = 4;
            this.btnOrderMenuItem.Text = "Pedidos";
            this.btnOrderMenuItem.UseVisualStyleBackColor = true;
            this.btnOrderMenuItem.Click += new System.EventHandler(this.btnOrderMenuItem_Click);
            // 
            // btnReportMenuItem
            // 
            this.btnReportMenuItem.Location = new System.Drawing.Point(44, 194);
            this.btnReportMenuItem.Name = "btnReportMenuItem";
            this.btnReportMenuItem.Size = new System.Drawing.Size(323, 37);
            this.btnReportMenuItem.TabIndex = 5;
            this.btnReportMenuItem.Text = "Voltar";
            this.btnReportMenuItem.UseVisualStyleBackColor = true;
            this.btnReportMenuItem.Click += new System.EventHandler(this.btnReportMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 264);
            this.Controls.Add(this.btnReportMenuItem);
            this.Controls.Add(this.btnOrderMenuItem);
            this.Controls.Add(this.btnAdmMenuItem);
            this.Controls.Add(this.btnClientMenuItem);
            this.Controls.Add(this.BtnProductMenuItem);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(424, 278);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnProductMenuItem;
        private System.Windows.Forms.Button btnClientMenuItem;
        private System.Windows.Forms.Button btnAdmMenuItem;
        private System.Windows.Forms.Button btnOrderMenuItem;
        private System.Windows.Forms.Button btnReportMenuItem;
    }
}