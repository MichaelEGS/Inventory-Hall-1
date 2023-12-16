using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Inventory_Hall
{
    public partial class agrempleado : Form
    {
        private DatabaseManager databaseManager; // Instancia de la clase DatabaseManager para la gestión de la base de datos

        public agrempleado()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager(); // Inicializar el gestor de base de datos
        }
        // Manejador del evento de clic en el botón "Nuevo"
        private void nuevobtn_Click(object sender, EventArgs e) 
        {
            nombretxt.Enabled = true;
            apellidotxt.Enabled = true;
            direcciontxt.Enabled = true;
            maskeddni.Enabled = true;
            emailtxt.Enabled = true;
            maskedtel.Enabled = true;
            maskedcel.Enabled = true;
            cargotxt.Enabled = true;

            nombretxt.BackColor = Color.White;
            apellidotxt.BackColor = Color.White;
            direcciontxt.BackColor = Color.White;
            maskeddni.BackColor = Color.White;
            emailtxt.BackColor = Color.White;
            maskedtel.BackColor = Color.White;
            maskedcel.BackColor = Color.White;
            cargotxt.BackColor = Color.White;
        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {

        }
        // Manejador del evento de clic en el botón "Guardar"
        private void guardarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si alguno de los campos requeridos está vacío
                if (string.IsNullOrWhiteSpace(nombretxt.Text) || string.IsNullOrWhiteSpace(apellidotxt.Text) ||
                    string.IsNullOrWhiteSpace(direcciontxt.Text) || string.IsNullOrWhiteSpace(GetUnmaskedText(maskeddni)) ||
                    string.IsNullOrWhiteSpace(emailtxt.Text) || string.IsNullOrWhiteSpace(GetUnmaskedText(maskedtel)) ||
                    string.IsNullOrWhiteSpace(GetUnmaskedText(maskedcel)) || string.IsNullOrWhiteSpace(cargotxt.Text))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                    return; // Salir del método sin continuar con la inserción en la base de datos
                }
                // Consulta SQL para insertar datos en la tabla 'empleado'
                string insertQuery = "INSERT INTO empleado (nombre, apellido, direccion, dni, email, telefono, celular, cargo) " +
                   "VALUES (@nombre, @apellido, @direccion, @dni, @email, @telefono, @celular, @cargo)";

                using (SqlCommand command = new SqlCommand(insertQuery, databaseManager.GetConnection()))
                {
                    // Agregar parámetros utilizando AddWithValue
                    command.Parameters.AddWithValue("@nombre", nombretxt.Text);
                    command.Parameters.AddWithValue("@apellido", apellidotxt.Text);
                    command.Parameters.AddWithValue("@direccion", direcciontxt.Text);

                    string dni = maskeddni.Text.Replace("-", " "); // Eliminar espacios u otros formatos
                    command.Parameters.AddWithValue("@dni", dni);

                    command.Parameters.AddWithValue("@email", emailtxt.Text);

                    string phoneNumber = maskedtel.Text.Replace("-", ""); // Eliminar guiones u otros formatos
                    command.Parameters.AddWithValue("@telefono", phoneNumber);

                    string cellphoneNumber = maskedcel.Text.Replace("-", ""); // Eliminar guiones u otros formatos
                    command.Parameters.AddWithValue("@celular", cellphoneNumber);

                    command.Parameters.AddWithValue("@cargo", cargotxt.Text);

                    // Ejecutar el comando SQL
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Data insertada correctamente.");

                nombretxt.Clear();
                apellidotxt.Clear();
                direcciontxt.Clear();           // Limpiar los campos después de la inserción exitosa
                maskeddni.Clear();
                emailtxt.Clear();
                maskedtel.Clear();
                maskedcel.Clear();
                cargotxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR HAS INSERTADO UN DATO MAL: " + ex.Message);
            }
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

        private void agrempleado_Load(object sender, EventArgs e)
        {

        }
    }
}
