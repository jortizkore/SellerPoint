namespace J_SellPoint
{
    partial class FrmDashboard
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
            this.DashboardMenu = new System.Windows.Forms.MenuStrip();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perdidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashboardMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardMenu
            // 
            this.DashboardMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.purchasesToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.perdidasToolStripMenuItem});
            this.DashboardMenu.Location = new System.Drawing.Point(0, 0);
            this.DashboardMenu.Name = "DashboardMenu";
            this.DashboardMenu.Size = new System.Drawing.Size(822, 24);
            this.DashboardMenu.TabIndex = 0;
            this.DashboardMenu.Text = "menuStrip1";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.Image = global::J_SellPoint.Properties.Resources._3;
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.accountsToolStripMenuItem.Text = "Cuentas";
            this.accountsToolStripMenuItem.Click += new System.EventHandler(this.accountsToolStripMenuItem_Click);
            // 
            // perdidasToolStripMenuItem
            // 
            this.perdidasToolStripMenuItem.Name = "perdidasToolStripMenuItem";
            this.perdidasToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.perdidasToolStripMenuItem.Text = "Perdidas";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Image = global::J_SellPoint.Properties.Resources._14;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.productsToolStripMenuItem.Text = "Productos";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Image = global::J_SellPoint.Properties.Resources._6;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.salesToolStripMenuItem.Text = "Ventas";
            // 
            // purchasesToolStripMenuItem
            // 
            this.purchasesToolStripMenuItem.Image = global::J_SellPoint.Properties.Resources._15;
            this.purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            this.purchasesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.purchasesToolStripMenuItem.Text = "Compra";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 482);
            this.Controls.Add(this.DashboardMenu);
            this.MainMenuStrip = this.DashboardMenu;
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.DashboardMenu.ResumeLayout(false);
            this.DashboardMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip DashboardMenu;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perdidasToolStripMenuItem;
    }
}

