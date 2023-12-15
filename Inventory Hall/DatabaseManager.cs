﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Inventory_Hall
{
    public class DatabaseManager
    {
        private SqlConnection connection;
        public DatabaseManager()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryHall"].ConnectionString + ";Encrypt=True;TrustServerCertificate=True;"; connection = new SqlConnection(connectionString);

        }

        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, GetConnection()))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
