using Microsoft.Data.SqlClient;
using System;
using System.Configuration;

namespace Inventory_Hall
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();

            KeyPreview = true; //Habilitar la vista previa de teclas para el formulario
            KeyDown += (sender, e) => { if (e.KeyCode == Keys.Escape) Dispose(); }; // Cerrar el formulario si se presiona la tecla Escape

        }



        
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Dispose(); // Liberar el formulario al hacer clic en el bot�n de cierre
        }
        //menustrip del menu principal (del primer form)
        private void cONSULTAToolStripMenuItem_Click(object sender, EventArgs e) // C�digo para manejar el clic en el elemento de men� CONSULTA
        {

        }
        
        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e) // Abrir el formulario 'agrproducto' para agregar un nuevo producto
        {
            using (agrproducto agrproducto = new agrproducto())
            {
                agrproducto.ShowDialog(); // Abrir el formulario como un cuadro de di�logo
            }
        }
        // Abrir el formulario 'agrempleado' para agregar un nuevo empleado
        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrempleado agrempleado = new agrempleado();
            agrempleado.ShowDialog(); 

        }
        // Abrir el formulario 'agrsuplidor' para ver la informaci�n del proveedor
        private void sUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrsuplidor agrsuplidor = new agrsuplidor();
            agrsuplidor.ShowDialog(); 
        }

        // Abrir el formulario 'conproducto' para ver la informaci�n del producto
        private void pRODUCTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conproducto conproducto = new conproducto();
            conproducto.ShowDialog();

        }
        // Abrir el formulario 'conempleado' para ver la informaci�n del empleado
        private void eMPLEADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            conempleado conempleado = new conempleado();
            conempleado.ShowDialog();
        }
        // Abrir el formulario 'consuplidor' para ver la informaci�n del proveedor
        private void sUPLIDORToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consuplidor consuplidor = new consuplidor();
            consuplidor.ShowDialog();
        }
        // Abrir el formulario 'prodistribucion' para la distribuci�n de categor�as
        private void dISTRIBUCIONDECATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodistribucion prodistribucion = new prodistribucion();
            prodistribucion.ShowDialog();
        }
        // Abrir el formulario 'sisacercade' para mostrar informaci�n sobre el sistema
        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sisacercade sisacercade = new sisacercade();
            sisacercade.ShowDialog();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }
    }
}

