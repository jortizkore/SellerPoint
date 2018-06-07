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
    public class Purchase : IPurchase
    {
        private Connection con = new Connection();
        public int ID_Purchase { get; set; }
        public int ID_Product { get; set; }
        public int Units { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public Purchase()
        {
            
        }

        public bool Save(Product p, int units)
        {
            con.Command.CommandText = "addLosse";
            con.Command.CommandType = CommandType.StoredProcedure;
            con.Command.Parameters.Add("@idProduct", SqlDbType.Int).Value = p.Id;
            con.Command.Parameters.Add("@Cost", SqlDbType.Decimal).Value = p.Cost;
            con.Command.Parameters.Add("@LostUnits", SqlDbType.Int).Value = units;
            con.Command.Parameters.Add("@Total_Lost", SqlDbType.Decimal).Value = p.Cost * units;
            con.Command.Parameters.Add("@Comment", SqlDbType.VarChar).Value = Comment;
            return con.ExecCommand();
        }

        public List<Purchase> GetPurchaseslList(int? month, int? year)
        {
            var addMonthOrYear = "WHERE 1 = 1";
            addMonthOrYear += month != null ? $" AND month(Purchase_Date) = {month}" : "";
            addMonthOrYear += year != null ? $" AND year(Purchase_Date) = {year}" : "";

            string selectcommand = $"SELECT * FROM Purchases {addMonthOrYear}";
            return GetListFromTable(con.GetData(selectcommand));
        }

        static List<Purchase> GetListFromTable(DataTable dt)
        {
            return (from DataRow row in dt.Rows
                select new Purchase()
                {
                    ID_Purchase = int.Parse(row["ID_loose"].ToString()), Comment = row["Comment"].ToString(),
                    Date = DateTime.Parse(row["Purchase_Date"].ToString()),
                    UnitCost = decimal.Parse(row["CostxUnit"].ToString()), ID_Product = int.Parse(row["ID_Product"].ToString()),
                    Units = int.Parse(row["Units"].ToString()), Total = decimal.Parse(row["Total_Cost"].ToString())
                }).ToList();
        }

        public DataTable GetPurchaseslTable(int? month, int? year)
        {
            var addMonthOrYear = "WHERE 1 = 1";
            addMonthOrYear += month != null ? $" AND month(Purchase_Date) = {month}" : "";
            addMonthOrYear += year != null ? $" AND year(Purchase_Date) = {year}" : "";

            string selectcommand = $"SELECT * FROM Purchases {addMonthOrYear}";
            return con.GetData(selectcommand);
        }
    }
}
