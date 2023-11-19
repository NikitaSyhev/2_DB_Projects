using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace _2_DB_Projects
{
    public class SQLiteDB:DataBase
    {
        private SQLiteConnection connection = new SQLiteConnection(@"Data Source=Users.db;Version=3;");
        public string query = "";
        
        public SQLiteDB(string constr) : base(constr) 
        {
            
        }

        public override void OpenConnection() // безопасное открытие БД с проверкой состояния
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("Connection Open");
                
            }

        }
        


        public override void CloseConnection()
        {
            if (connection.State==ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public override DataTable ExecuteQuerry(string querry)
        {
            DataTable dataTable = new DataTable(); 
            try
            {
                OpenConnection();
                using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;

        }
      
    }
}
