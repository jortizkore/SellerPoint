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
        private Product prod;
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

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)

        {
            if(e.KeyChar == 13)
            {
                LoadProduct(int.Parse(TxtID.Text));
            }
        }

        private void LoadProduct(int id)
        {
            prod.Load(id);
            LblDesc.Text = prod.Description;
            LblCosto.Text = prod.Cost.ToString();
            TxtPriceDetails.Text = prod.Price.ToString();
            LblQuantity.Text = prod.Quantity.ToString();
        }

        private void CdmAddOne_Click(object sender, EventArgs e)
        {
            prod = new Product();
            prod.Load(int.Parse(TxtID.Text));
            if(prod != null)
            {
                prod.AddQuantity(prod.Id, 1);
            }
            RefreshAll();
        }

        void RefreshAll()
        {
            LoadProduct(prod.Id);
            LoadRefreshProdGrid();
        }

        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (UpdateProduct())
                {
                    Program.DisplayInfoMessage("Actualizado! :D");
                }
                else
                {
                    Program.DisplayErrorMessage("Error al actualizar :(");
                }
                RefreshAll();
            }
        }

        private bool UpdateProduct()
        {
            prod = new Product();
            prod.Load(int.Parse(TxtID.Text));
            prod.Price = decimal.Parse(TxtPriceDetails.Text);
            return prod.Update();
        }

        private void GrdProduct_CellMouseDoubleClick(object sender,
            DataGridViewCellMouseEventArgs e)
        {
            var productid = int.Parse(GrdProduct.Rows[e.RowIndex].Cells[0].Value.ToString());
            TxtID.Text = productid.ToString();
            LoadProduct(productid);
            tabControl1.SelectTab(2);
        }
    }
}
