using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;
using System.Data.Sql;

namespace _2_DB_Projects
{
    public abstract class DataBase
    {

       

        //поля

        private string connectionString;
        public string ConnectionString { get; set; }

        private DbConnection Connection;
        private DbDataAdapter dataAdapter;
        private IDataReader reader;
        public string DataAdapter { get; set; }
        public IDataReader Reader { get; set; }
        
        //private DbDataTable DataTables;


        //методы
    
        public abstract DbConnection GetConnection();
        public abstract DbDataAdapter GetDataAdapter(string sql);

        public abstract bool HasTable(string tableName);

    }
}
