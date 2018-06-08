using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using J_SellPoint.Classes;
using J_SellPoint.Models.Interfaces;

namespace J_SellPoint.Models
{
    public class Product : IProduct
    {
        private Classes.Connection con = new Connection();
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string description, decimal cost, decimal price)
        {
            Description = description;
            Cost = cost;
            Price = price;
            Quantity = 0;
        }

        public Product(int id, string description, decimal cost, decimal price, int quantity)
        {
            Id = id;
            Description = description;
            Cost = cost;
            Price = price;
            Quantity = quantity;
        }

        public bool Save()
        {
            con.Command.CommandText = "addProduct";
            con.Command.CommandType = CommandType.StoredProcedure;
            con.Command.Parameters.Add("@ProductDescription", SqlDbType.VarChar, 300).Value = Description;
            con.Command.Parameters.Add("@Cost", SqlDbType.Decimal).Value = Cost;
            con.Command.Parameters.Add("@Price", SqlDbType.Decimal).Value = Price;

            return con.ExecCommand();
        }

        public void Load(int id)
        {
            DataTable table = new DataTable();
            string selectcommand = $"SELECT * FROM Products where id_product = {id}";
            table = con.GetData(selectcommand);

            Id = int.Parse(table.Rows[0]["id_product"].ToString());
            Description = table.Rows[0]["Product_Description"].ToString();
            Cost = decimal.Parse(table.Rows[0]["Cost"].ToString());
            Price = decimal.Parse(table.Rows[0]["Price"].ToString());
            Quantity = Int32.Parse(table.Rows[0]["Stock_Quantity"].ToString());

        }

        public bool Update()
        {
            con.Command.CommandText = "updateProduct";
            con.Command.CommandType = CommandType.StoredProcedure;
            con.Command.Parameters.Add("@id", SqlDbType.Decimal).Value = this.Id;
            con.Command.Parameters.Add("@ProductDescription", SqlDbType.VarChar, 300).Value = Description;
            con.Command.Parameters.Add("@Cost", SqlDbType.Decimal).Value = Cost;
            con.Command.Parameters.Add("@Price", SqlDbType.Decimal).Value = Price;
            con.Command.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity;

            return con.ExecCommand();
        }

        public bool AddQuantity(int id, int plus)
        {
            if (plus <= 0)
            {
                return false;
            }
            con.Command.CommandText = "addProductQuantity";
            con.Command.CommandType = CommandType.StoredProcedure;
            con.Command.Parameters.Add("@id", SqlDbType.Decimal).Value = id;
            con.Command.Parameters.Add("@plus", SqlDbType.Int).Value = plus;

            return con.ExecCommand();
        }

        public List<Product> GetAllProducts()
        {
            string selectcommand = "SELECT * FROM Products";
            return (from DataRow row in con.GetData(selectcommand).Rows select ProductFromRow(row)).ToList();
        }

        public DataTable GetProductsTable()
        {
            List<Product> returnList = new List<Product>();
            DataTable table = new DataTable();
            string selectcommand = "SELECT * FROM Products";
            table = con.GetData(selectcommand);

            return table;
        }

        private Product ProductFromRow(DataRow r)
        {
            var p = new Product(
                int.Parse(r["ID_Product"].ToString()),
                r["Product_Description"].ToString(),
                decimal.Parse(r["Cost"].ToString()),
                decimal.Parse(r["Price"].ToString()),
                int.Parse(r["Stock_Quantity"].ToString())
            );

            return p;
        }

        #region Filters for products Lists/Tables
        public List<Product> GetProductsByNameList(string desc)
        {
            List<Product> returnList = new List<Product>();
            string selectcommand = $"SELECT * FROM Products where Product_Description like '%{desc}%'";

            foreach (DataRow row in con.GetData(selectcommand).Rows)
            {
                returnList.Add(ProductFromRow(row));
            }

            return returnList;
        }
        public DataTable GetProductsByNameTable(string desc)
        {
            List<Product> returnList = new List<Product>();
            string selectcommand = $"SELECT * FROM Products where Product_Description like '%{desc}%'";
            return con.GetData(selectcommand);
        }
        //TODO implement price range filter
        public DataTable GetProductsByPriceRangeTable(string desc)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProductsByPriceRangeList(string desc)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
