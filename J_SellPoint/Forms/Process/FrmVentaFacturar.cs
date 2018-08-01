using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J_SellPoint.Classes;
using J_SellPoint.Models;
using J_SellPoint.Properties;

namespace J_SellPoint.Forms.Process
{
    public partial class FrmVentaFacturar : Form
    {
        Sale sale = new Sale();
        Product selectedProduct = new Product();
        List<Sale> saleList = new List<Sale>();
        List<saleDetail> saleDetailsList = new List<saleDetail>();


        public FrmVentaFacturar()
        {
            InitializeComponent();
        }

        private void FrmVentaFacturar_Load(object sender, EventArgs e)
        {
            FillCmbProducts();
        }

        void FillCmbProducts() {
            CmbProducts.DataSource = selectedProduct.GetAllProducts();
            CmbProducts.DisplayMember = "Description";
            CmbProducts.DisplayMember = "Id";
        }

        private void CmdAddToProductList_Click(object sender, EventArgs e)
        {
            selectedProduct.Load(int.Parse(CmbProducts.SelectedValue.ToString()));

        }

        void addProductToSaleList(Product p)
        {
            sale = new Sale
            {
                IdProduct = p.Id,
                Date = DateTime.Now,
                UnitPrise = p.Price,
                Units = 1,
                Total = (p.Price * 1)
            };
            saleList.Add(sale);

        }
        void parseSalesToDetails()
        {
            foreach (var sale in saleList)
            {
                Product p = new Product();
                p.Load(sale.IdProduct);
                var saleDetail = new saleDetail
                {
                    //
                }
            }
        }
    }

    class saleDetail
    {
        string product;
        decimal unitPrice;
        int quantity;
        decimal total;
    }
}
