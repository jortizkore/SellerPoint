﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J_SellPoint.Forms.Maintenances;
using J_SellPoint.Forms.Process;

namespace J_SellPoint
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Maintenances.FrmProducts frm = new FrmProducts();
            frm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.Show();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void perdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLosses frmLosses = new FrmLosses();
            frmLosses.Show();
        }
    }
}
