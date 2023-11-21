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
using System.Data.Common;

namespace _2_DB_Projects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
      // SQLiteDB db = new SQLiteDB(connectionSQL); // объект класса создали


        private DataBase db; // создали объект абстрактного класса


        private void button1_Click(object sender, EventArgs e)
        {
            string choosenBD = cb_BD.SelectedItem.ToString();
            string filename;
            if (choosenBD == "SQLite")
            {
              
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    db = new SQLiteDB(filename);//
                }
                //db.OpenConnection();
                string sql = "select * from sqlite_master";
                DataTable DtProduct = new DataTable();
                DbDataAdapter adProduct = db.GetDataAdapter(sql);  // открыли через абстрактный класс
                adProduct.Fill(DtProduct);
                dataGridView1.DataSource = DtProduct;
            }
            if(choosenBD == "MS_SQL")
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    db = new SQLiteDB(filename);//
                }
                string sql = "SELECT * FROM master_table";
                DataTable DtProduct = new DataTable();
                DbDataAdapter adProduct = db.GetDataAdapter(sql);  // открыли через абстрактный класс
                adProduct.Fill(DtProduct);
                dataGridView1.DataSource = DtProduct;
            }
        }
    }
}
