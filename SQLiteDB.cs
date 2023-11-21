using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;

namespace _2_DB_Projects
{
    public class SQLiteDB:DataBase
    {
        private SQLiteConnection connection;
        private SQLiteDataAdapter _dataAdapter;
        private DbDataAdapter DataAdapter;
        public string query = "";  
        
        public SQLiteDB(string constr) 
        {
            connection = new SQLiteConnection("DataSource=" + constr);
            ConnectionString = connection.ConnectionString;
        }

        public override DbConnection GetConnection()
        {
            connection = new SQLiteConnection(ConnectionString);
            return connection;
        }

        public override DbDataAdapter GetDataAdapter(string sql)
        {
            _dataAdapter = new SQLiteDataAdapter(sql, connection);
            DataAdapter = _dataAdapter;
            return _dataAdapter;
        }


        
    }
}
