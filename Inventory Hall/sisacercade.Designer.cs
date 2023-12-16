namespace Inventory_Hall
{
    partial class sisacercade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sisacercade));
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = SystemColors.ActiveCaptionText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Items.AddRange(new object[] { "Este software fue creado por: Jesus Acevedo 2020-2551, Steven Vasquez 2022-2125 y Michael Zorrilla 2022-2135.", "", "Las Herramientas fueron: SQL version 2019, IDE: Visual Studio version 2022 community, Frameworks: .NET7, lenguaje: C#.", "", "Este programa esta basado en un control de inventario que puede realizar entrada de productos,suplidores y empeleados", "", "al mismo tiempo podemos ver la distribucion de productos y se puede modificar la seccion del mismo y hacer la consulta de todos estos.", "", "Fue creado con el objetivo de proyecto final de la materia Programacion basica(ISW-122-50)" });
            listBox1.Location = new Point(47, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1180, 526);
            listBox1.TabIndex = 0;
            // 
            // sisacercade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 599);
            Controls.Add(listBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "sisacercade";
            Text = "Acerca De";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
    }
}