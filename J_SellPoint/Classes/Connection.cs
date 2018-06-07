using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace J_SellPoint.Classes
{
    class Connection
    {
        string ConStr = "";
        public SqlConnection Con = new SqlConnection();
        public SqlCommand Command = new SqlCommand();
        public SqlDataAdapter Adapter = new SqlDataAdapter();
        public DataTable Table = new DataTable();

        public Connection()
        {
        }

        private void InitConnection()
        {
            Table = new DataTable();
            if (Con.State == ConnectionState.Open)
                Con.Close();

            Con.ConnectionString = ConfigurationSettings.AppSettings["ConStr"];
            Command.Connection = this.Con;
            Command.Connection.Open();
        }

        private void CloseConnection()
        {
            if (Command.Connection.State == ConnectionState.Closed)
                Command.Connection.Open();
        }

        public bool ExecCommand()
        {
            InitConnection();
            var canExecute = !string.IsNullOrEmpty(this.Command.CommandText);
            if (canExecute)
            {
                try
                {
                    this.Command.ExecuteNonQuery();
                }
                catch (Exception es)
                {
                    Program.DisplayErrorMessage(es.Message);
                    return false;
                }
                finally
                {
                    CloseConnection();
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public DataTable GetData(string comand)
        {
            try
            {
                InitConnection();
                Command.CommandText = comand;
                Command.CommandType = CommandType.Text;
                Adapter.SelectCommand = Command;
                Adapter.Fill(Table);
            }
            catch(Exception es)
            {
                Program.DisplayErrorMessage(es.Message);
            }
            finally
            {
                CloseConnection();
            }
            return Table;
        }

    }
}
