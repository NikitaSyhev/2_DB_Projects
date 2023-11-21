using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace _2_DB_Projects
{
    public class MsSQL_DB:DataBase
    {
        private SqlConnection connection;
        private SqlDataAdapter _dataAdapter;
        private DbDataAdapter dataAdapter;

        public MsSQL_DB(string constr)
        {
           
                connection = new SqlConnection(constr);
                ConnectionString = connection.ConnectionString;      
        }

        public override DbConnection GetConnection()
        {
            connection = new SqlConnection(ConnectionString);
            return connection;
        }

        public override DbDataAdapter GetDataAdapter(string sql)
        {
            _dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter = _dataAdapter;
            return _dataAdapter;
        }

        public override bool HasTable(string tableName)
        {
           return true;
        }
    }

}

