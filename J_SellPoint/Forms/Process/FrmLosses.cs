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

namespace J_SellPoint.Forms.Process
{
    public partial class FrmLosses : Form
    {
        Loss Lost = new Loss();
        Product prod = new Product();
        public FrmLosses()
        {
            InitializeComponent();
        }

        private void FrmLosses_Load(object sender, EventArgs e)
        {
            FillGridLosses();
            FillLossProductCombo();
        }

        void FillLossProductCombo()
        {
            prod = new Product();
            CmbProductosPerdidas.DataSource = prod.GetAllProducts();
            CmbProductosPerdidas.DisplayMember = "Description";
            CmbProductosPerdidas.ValueMember = "id";
        }

        void FillFormFromSelectedProd() {
            decimal total = 0;
            var Parseable = decimal.TryParse((prod.Cost * NumCantidadPerdida.Value).ToString(), out total);
            TxtCostoPerdida.Text = prod.Cost.ToString();
            TxtTotalPerdido.Text = total.ToString();
            LblCantidadEnStockPerdidas.Text = prod.Quantity.ToString();
        }

        void FillGridLosses()
        {
            Lost = new Loss();
            grdPerdiasConsulta.DataSource = Lost.GetLossesList(null, null);
            grdPerdiasConsulta.Refresh();
            tabControl1.SelectTab(0);
        }

        private void CmbProductosPerdidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                prod.Load(int.Parse(CmbProductosPerdidas.SelectedValue.ToString()));
                FillFormFromSelectedProd();
            }
            catch (Exception) { }
        }

        private void NumCantidadPerdida_ValueChanged(object sender, EventArgs e)
        {
            FillFormFromSelectedProd();
        }

        private void CmdGuardarPerdida_Click(object sender, EventArgs e)
        {
            Lost = new Loss();
            Lost.Comment = TxtComentarioPerdida.Text;
           if(Lost.Save(prod, int.Parse(NumCantidadPerdida.Value.ToString())))
            {
                Program.DisplayInfoMessage("Perdida registrada");
                Limpiar();
            }
            FillGridLosses();
        }

        void Limpiar()
        {
            Program.CleanFormText(tabControl1.SelectedTab.Controls);
            LblCantidadEnStockPerdidas.Text = "0";
            CmbProductosPerdidas.SelectedIndex = 0;
        }

        private void CmdCalcel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
