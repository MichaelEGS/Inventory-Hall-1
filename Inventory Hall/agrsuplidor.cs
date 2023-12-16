using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Hall
{
    public partial class agrsuplidor : Form
    {
        private DatabaseManager databaseManager;
        public agrsuplidor()
        {
            InitializeComponent();

            databaseManager = new DatabaseManager();

        }

        private void insertarbtn_Click(object sender, EventArgs e)
        {
            nombretxt.Enabled = true;
            rnctxt.Enabled = true;
            direcciontxt.Enabled = true;
            emailtxt.Enabled = true;        // Habilitar la edición de campos al hacer clic en el botón "Insertar"
            telefonotxt.Enabled = true;
            descripciontxt.Enabled = true;

            nombretxt.BackColor = Color.White;
            rnctxt.BackColor = Color.White;
            direcciontxt.BackColor = Color.White;       // Restablecer el color de fondo de los campos a blanco
            emailtxt.BackColor = Color.White;
            telefonotxt.BackColor = Color.White;
            descripciontxt.BackColor = Color.White;
        }

        private void agrsuplidor_Load(object sender, EventArgs e)
        {

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si alguno de los campos requeridos está vacío
                if (string.IsNullOrWhiteSpace(nombretxt.Text) ||
                    string.IsNullOrWhiteSpace(GetUnmaskedText(rnctxt)) ||
                    string.IsNullOrWhiteSpace(direcciontxt.Text) ||
                    string.IsNullOrWhiteSpace(emailtxt.Text) ||
                    string.IsNullOrWhiteSpace(GetUnmaskedText(telefonotxt)) ||
                    string.IsNullOrWhiteSpace(descripciontxt.Text))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                    return; // Salir del método sin proceder a la inserción en la base de datos
                }

                // Consulta SQL para insertar datos en la tabla "suplidor"
                string insertQuery = "insert into suplidor (nombre, rnc, direccion, email, telefono, descripcion) " +
                    "VALUES (@nombre, @rnc, @direccion, @email, @telefono, @descripcion)";

                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    // Agregar parámetros utilizando AddWithValue
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    command.Parameters.AddWithValue("@direccion", direcciontxt.Text);
                    command.Parameters.AddWithValue("@email", emailtxt.Text);

                    string rnc = rnctxt.Text.Replace(" ", ""); // Eliminar espacios o cualquier otro formato del RNC
                    command.Parameters.AddWithValue("@rnc", rnc);

                    string phoneNumber = telefonotxt.Text.Replace("-", ""); // Eliminar guiones u otros formatos del número de teléfono
                    command.Parameters.AddWithValue("@telefono", phoneNumber);

                    command.Parameters.AddWithValue("@descripcion", descripciontxt.Text);

                    // Ejecutar el comando SQL
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data insertada correctamente.");

                nombretxt.Text = "";        // Limpiar los campos después de la inserción
                rnctxt.Text = "";
                direcciontxt.Text = "";
                emailtxt.Text = "";
                telefonotxt.Text = "";
                descripciontxt.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR HAS INSERTADO UN DATO MAL: " + ex.Message);
            }
        }
        // Manejador de eventos MaskInputRejected para maskedTextBox1
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        // Manejador de eventos MaskInputRejected para rnctxt
        private void rnctxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        // Método para obtener el texto sin formato de un MaskedTextBox
        private string GetUnmaskedText(MaskedTextBox maskedTextBox)
        {
            string unmaskedText = maskedTextBox.Text;
            foreach (char maskChar in maskedTextBox.Mask)
            {
                unmaskedText = unmaskedText.Replace(maskChar.ToString(), "");
            }
            return unmaskedText;
        }

    }
}
