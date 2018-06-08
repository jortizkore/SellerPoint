using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J_SellPoint.Classes;
using J_SellPoint.Models.Interfaces;

namespace J_SellPoint.Models
{
    public class Sale : ISale
    {
        private Connection con = new Connection();
        public int IdSale { get; set; }
        public int IdProduct { get; set; }
        public decimal UnitPrise { get; set; }
        public int Units { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }


        public bool Save(Product p, int units)
        {
            con.Command.CommandText = "addSale";
            con.Command.CommandType = CommandType.StoredProcedure;
            con.Command.Parameters.Add("@ID_Product", SqlDbType.Int).Value = p.Id;
            con.Command.Parameters.Add("@Sell_Prise_per_Unit", SqlDbType.Decimal).Value = p.Price;
            con.Command.Parameters.Add("@Sold_Units", SqlDbType.Int).Value = units;
            con.Command.Parameters.Add("@Total_Sale", SqlDbType.Decimal).Value = p.Price * units;
            return con.ExecCommand();
        }

        public List<Sale> GetSalesList(int? prod, int? month, int? year)
        {
            var addMonthOrYear = prod == null ? "WHERE 1 = 1" : $"WHERE ID_Product = {prod}";
            addMonthOrYear += month != null ? $" AND month(Sale_Date) = {month}" : "";
            addMonthOrYear += year != null ? $" AND year(Sale_Date) = {year}" : "";

            string selectcommand = $"SELECT * FROM Sales {addMonthOrYear}";
            return GetListFromTable(con.GetData(selectcommand));
        }

        static List<Sale> GetListFromTable(DataTable dt)
        {
            return (from DataRow row in dt.Rows
                    select new Sale()
                    {
                        IdSale = int.Parse(row["ID_loose"].ToString()),
                        Date = DateTime.Parse(row["Sale_Date"].ToString()),
                        UnitPrise = decimal.Parse(row["Cost_x_Unit"].ToString()),
                        IdProduct = int.Parse(row["ID_Product"].ToString()),
                        Units = int.Parse(row["Units"].ToString()),
                        Total = decimal.Parse(row["Total_Sale"].ToString())
                    }).ToList();
        }

        public DataTable GetSalesTable(int? prod, int? month, int? year)
        {
            var addMonthOrYear = prod == null ? "WHERE 1 = 1" : $"WHERE ID_Product = {prod}";
            addMonthOrYear += month != null ? $" AND month(Sale_Date) = {month}" : "";
            addMonthOrYear += year != null ? $" AND year(Sale_Date) = {year}" : "";

            string selectcommand = $"SELECT * FROM Sales {addMonthOrYear}";
            return con.GetData(selectcommand);
        }
    }
}
