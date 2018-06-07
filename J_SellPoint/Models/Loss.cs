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
    public class Loss : ILoss
    {
        private Classes.Connection con = new Connection();
        public int ID { get; set; }
        public int LossProduct { get; set; }
        public decimal Cost { get; set; }
        public int LostUnits { get; set; }
        public decimal TotalLost { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }

        public Loss ()
        {
            
        }

        public List<Loss> GetLossesFromAProductList(int prodid)
        {
            string selectcommand = $"SELECT * FROM Losses where ID_Product = {prodid}";
            return GetListFromTable(con.GetData(selectcommand));
        }

        public DataTable GetLossesFromAProductTable(int prodId)
        {
            string selectcommand = $"SELECT * FROM Losses where ID_Product = {prodId}";
            return con.GetData(selectcommand);
        }

        public List<Loss> GetLossesList(int? month, int? year)
        {
            var addMonthOrYear = "WHERE 1 = 1";
            addMonthOrYear += month != null ? $" AND month(Reported_Date) = {month}":"";
            addMonthOrYear += year != null ? $" AND year(Reported_Date) = {year}" : "";

            string selectcommand = $"SELECT * FROM Losses {addMonthOrYear}";
            return GetListFromTable(con.GetData(selectcommand));
        }

        static List<Loss> GetListFromTable(DataTable dt)
        {
            return (from DataRow row in dt.Rows
                select new Loss()
                {
                    ID = int.Parse(row["ID_loose"].ToString()), Comment = row["Comment"].ToString(),
                    Date = DateTime.Parse(row["Reported_Date"].ToString()), Cost = decimal.Parse(row["Cost"].ToString()),
                    LossProduct = int.Parse(row["Product_ID"].ToString()), LostUnits = int.Parse(row["LostUnits"].ToString()),
                    TotalLost = decimal.Parse(row["Total_Lost"].ToString())
                }).ToList();
        }

        public DataTable GetLossesTable(int? month, int? year)
        {
            var addMonthOrYear = "WHERE 1 = 1";
            addMonthOrYear += month != null ? $" AND month(Reported_Date) = {month}" : "";
            addMonthOrYear += year != null ? $" AND year(Reported_Date) = {year}" : "";

            string selectcommand = $"SELECT * FROM Losses {addMonthOrYear}";
            return con.GetData(selectcommand);
        }

        public void Load(int id)
        {
            string selectcommand = $"SELECT * FROM Losses where id_loose = {id}";
            var table = con.GetData(selectcommand);

            id = int.Parse(table.Rows[0]["id_loose"].ToString());
            LossProduct = id;
            Cost = decimal.Parse(table.Rows[0]["Cost"].ToString());
            LostUnits = int.Parse(table.Rows[0]["Lost_Units"].ToString());
            TotalLost = decimal.Parse(table.Rows[0]["Total_Lost"].ToString());
            Date = DateTime.Parse(table.Rows[0]["Reported_Date"].ToString());
            Comment = table.Rows[0]["Comment"].ToString();
        }

        public bool Save(Product p, int quantity)
        {
            con.Command.CommandText = "addLosse";
            con.Command.CommandType = CommandType.StoredProcedure;
            con.Command.Parameters.Add("@idProduct", SqlDbType.Int).Value = p.Id;
            con.Command.Parameters.Add("@Cost", SqlDbType.Decimal).Value = p.Cost;
            con.Command.Parameters.Add("@LostUnits", SqlDbType.Int).Value = quantity;
            con.Command.Parameters.Add("@Total_Lost", SqlDbType.Decimal).Value = p.Cost * quantity;
            con.Command.Parameters.Add("@Comment", SqlDbType.VarChar).Value = Comment;
            return con.ExecCommand();
        }
    }
}
