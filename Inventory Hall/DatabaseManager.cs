using Microsoft.Data.SqlClient;
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
        public DatabaseManager()    // Constructor de la clase DatabaseManager
        {   // Obtener la cadena de conexión desde la configuración
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryHall"].ConnectionString + ";Encrypt=True;TrustServerCertificate=True;"; connection = new SqlConnection(connectionString);

        }
        // Método para obtener la conexión a la base de datos
        public SqlConnection GetConnection() // Abrir la conexión si está cerrada
        {
            if (connection.State == System.Data.ConnectionState.Closed)     
            {
                connection.Open();
            }   
            return connection;
        }
        // Método para cerrar la conexión a la base de datos
        public void CloseConnection()
        {   // Cerrar la conexión si está abierta
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        // Método para ejecutar una consulta que no devuelve resultados (por ejemplo, INSERT, UPDATE, DELETE)
        public void ExecuteNonQuery(string query)
        {   // Utilizar un bloque using para asegurar que se liberen los recursos del comando y la conexión
            using (SqlCommand command = new SqlCommand(query, GetConnection()))
            {   // Ejecutar la consulta que no devuelve resultados
                command.ExecuteNonQuery();
            }
        }
    }
}
