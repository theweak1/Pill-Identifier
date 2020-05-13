using System;
using MySql.Data.MySqlClient;

namespace Pill_Identifier
{
    class PillDB
    {

        private MySqlConnection conn;

        public PillDB()
        {
            string cs = @"server=localhost;userid=root;password=111957;database=pharma";
            conn = new MySqlConnection(cs);
            conn.Open();
        }

    }
}
