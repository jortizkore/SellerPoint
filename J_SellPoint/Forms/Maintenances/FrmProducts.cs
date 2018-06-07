using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J_SellPoint.Models;
using J_SellPoint.Models.Interfaces;

namespace J_SellPoint.Forms.Maintenances
{
    public partial class FrmProducts : Form
    {
        private IProduct prod;
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void TxtSave_Click(object sender, EventArgs e)
        {
            prod = new Product(
                TxtDescripcion.Text, decimal.Parse(TxtCosto.Text),
                decimal.Parse(TxtPrecio.Text));

            if (prod.Save())
            {
                Program.DisplayInfoMessage("Guardado");
            }
            else
            {
                Program.DisplayErrorMessage("Error al guardar");
            }
            
            Program.CleanFormText(this.tabControl1.SelectedTab.Controls);
        }

        private void TxtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void LoadRefreshProdGrid()
        {
            prod = new Product();
            GrdProduct.DataSource = prod.GetProductsTable();
            GrdProduct.Refresh();
            GrdProduct.Update();
        }

        void LoadRefreshProdGrid(string desc)
        {
            prod = new Product();
            GrdProduct.DataSource = prod.GetProductsByNameTable(desc);
            GrdProduct.Refresh();
            GrdProduct.Update();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadRefreshProdGrid();
        }

        private void RefreshProd_Click(object sender, EventArgs e)
        {
            LoadRefreshProdGrid();
        }

        private void TxtFilterProducts_TextChanged(object sender, EventArgs e)
        {
            LoadRefreshProdGrid(TxtFilterProducts.Text);
        }
    }
}
