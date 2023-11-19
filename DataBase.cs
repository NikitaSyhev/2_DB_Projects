using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace _2_DB_Projects
{
    public abstract class DataBase
    {

        public DataBase(string constr) { connectionString = constr; } // конструктор

        //поля

        private string connectionString;
        public string ConnectionString { get { return connectionString; } set { connectionString = value; } }

        private DbConnection Connection;
        private DataAdapter adapter;
        private DbDataReader reader;


        //методы
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract DataTable ExecuteQuerry(string querry); // для SELECT
 

    }
}
