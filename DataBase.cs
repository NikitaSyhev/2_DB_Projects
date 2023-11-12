using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DB_Projects
{
    abstract class DataBase
    {
        public string connectionString;

        public abstract void OpenConnection();
        public abstract void CloseConnection();
      

    }
}
