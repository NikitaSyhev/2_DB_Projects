using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _2_DB_Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string connectionSQL = @"Data Source=WareHouse.db;Version=3;";
        SQLiteDB db = new SQLiteDB(connectionSQL); // объект класса создали


        private void openBTN_Click(object sender, EventArgs e)
        {
            string selectedDB = cb_BD.SelectedItem.ToString();

            if (selectedDB == "SQLite")
            {
                db.OpenConnection();
               
            }
            if (selectedDB == "MSSQL")
            {

            }
           
        }
    }
}
