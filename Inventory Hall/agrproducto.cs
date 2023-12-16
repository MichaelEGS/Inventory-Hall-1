using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Hall
{
    public partial class agrproducto : Form
    {
        private DatabaseManager databaseManager;
        public agrproducto()
        {
            InitializeComponent();

            // La instancia de DatabaseManager es privada porque solo se usa en este formulario. 
            // Esto significa que los datos ingresados aquí se mantienen en esta conexión SQL específica.

            databaseManager = new DatabaseManager();

            // Llenar el ComboBox con datos de la tabla "categoria" cuando se carga el formulario
            PopulateCategoriaComboBox();

            // Llenar el ComboBox de idsuplidortxt con datos de la tabla "suplidor" cuando se carga el formulario
            PopulateSuplidorComboBox();

        }
        // Método para llenar el ComboBox de categoría
        private void PopulateCategoriaComboBox()
        {
            // Assuming that comboBox1 is the name of your ComboBox
            categoriabox.Items.Clear(); // Limpiar cualquier elemento existente en el ComboBox

            string query = "SELECT id, tipo FROM categoria";

            using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string tipo = reader["tipo"].ToString();
                        string displayText = $"{id} - {tipo}"; // Combinar id y tipo
                        categoriabox.Items.Add(displayText);
                    }
                }
            }
        }
        // Método para llenar el ComboBox de idsuplidortxt
        private void PopulateSuplidorComboBox()
        {
            // Assuming that idsuplidortxt is the name of your ComboBox
            idsuplidortxt.Items.Clear(); // Limpiar cualquier elemento existente en el ComboBox
            string query = "SELECT id, nombre FROM suplidor";
            using (SqlCommand command = new SqlCommand(query, databaseManager.GetConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string nombre = reader["nombre"].ToString();
                        string displayText = $"{id} - {nombre}"; // Combine id and nombre
                        idsuplidortxt.Items.Add(displayText);
                    }
                }
            }
        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            descripciontxt.Enabled = true;
            stocktxt.Enabled = true;            // Habilitar la edición de campos y establecer el fondo en blanco
            idsuplidortxt.Enabled = true;
            secciontxt.Enabled = true;
            categoriabox.Enabled = true;

            nombretxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
            stocktxt.BackColor = Color.White;
            idsuplidortxt.BackColor = Color.White;
            secciontxt.BackColor = Color.White;
            categoriabox.BackColor = Color.White;
            // Ejecutar un comando SQL usando la clase DatabaseManager creada anteriormente

            // Además, llenar el ComboBox con datos de "categoria" cuando haces clic en el botón insertar
            PopulateCategoriaComboBox();

        }

        private void agrproducto_Load(object sender, EventArgs e)
        {
            // Llamar al método para llenar el ComboBox cuando el formulario se carga
            PopulateCategoriaComboBox();
            PopulateSuplidorComboBox();



        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si alguno de los campos obligatorios está vacío
                if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                    categoriabox.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(descripciontxt.Text) ||
                    string.IsNullOrWhiteSpace(stocktxt.Text) ||
                    idsuplidortxt.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(secciontxt.Text))
                {
                    MessageBox.Show("Favor completar el formulario. Todos los campos son obligatorios.");
                    return; // Salir del método si algún campo está vacío
                }

                // Verificar si el valor de stock es numérico
                if (!int.TryParse(stocktxt.Text, out _))
                {
                    MessageBox.Show("Favor introduzca un dato numérico en el campo Stock.");
                    return; // Salir del método si stock no es numérico
                }
                // Consulta SQL para insertar datos en la tabla 'producto'
                string insertQuery = "insert into producto (nombre, categoria, descripcion, stock, idsuplidor, seccion) " +
                    "VALUES (@nombre, @categoria, @descripcion, @stock, @idsuplidor, @seccion)";

                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    // Agregar parámetros utilizando AddWithValue
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    string selectedCategory = categoriabox.SelectedItem.ToString();
                    string[] parts = selectedCategory.Split(new[] { " - " }, StringSplitOptions.None);
                    string selectedCategoryId = parts[0]; // Extract the "id" part
                    command.Parameters.AddWithValue("@categoria", selectedCategoryId);

                    command.Parameters.AddWithValue("@descripcion", descripciontxt.Text);
                    command.Parameters.AddWithValue("@stock", stocktxt.Text);

                    string selectedSuplidor = idsuplidortxt.SelectedItem.ToString();
                    string[] suplidorParts = selectedSuplidor.Split(new[] { " - " }, StringSplitOptions.None);
                    string selectedSuplidorId = suplidorParts[0]; // Extract the "id" part
                    command.Parameters.AddWithValue("@idsuplidor", selectedSuplidorId);

                    command.Parameters.AddWithValue("@seccion", secciontxt.Text);

                    // Ejecutar el comando SQL
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data insertada correctamente.");

                categoriabox.SelectedIndex = -1;    // Restablecer los ComboBox a su estado inicial después de la inserción exitosa
                idsuplidortxt.SelectedIndex = -1;

                nombretxt.Text = "";
                categoriabox.Text = "";
                descripciontxt.Text = "";       // Limpiar los campos después de la inserción exitosa
                stocktxt.Text = "";
                idsuplidortxt.Text = "";
                secciontxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }



        // Manejador del evento de cambio de ítem seleccionado en el ComboBox de categoría
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Puedes acceder a la categoría seleccionada del ComboBox de esta manera:
            string selectedCategory = categoriabox.SelectedItem?.ToString();

            // Utilizar la categoría seleccionada según sea necesario en tu código
        }

        // Manejador del evento Load del formulario(posiblemente duplicado)
        private void idsuplidortxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSuplidor = idsuplidortxt.SelectedItem?.ToString();

        }

        private void agrproducto_Load_1(object sender, EventArgs e)
        {

        }
    }
}
