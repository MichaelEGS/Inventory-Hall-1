﻿namespace Inventory_Hall
{
    partial class agrempleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrempleado));
            nombretxt = new TextBox();
            nuevobtn = new Button();
            nombreLB = new Label();
            apellidoLB = new Label();
            direccionLB = new Label();
            dniLB = new Label();
            emailLB = new Label();
            telefonoLB = new Label();
            celularLB = new Label();
            cargoLB = new Label();
            apellidotxt = new TextBox();
            direcciontxt = new TextBox();
            emailtxt = new TextBox();
            cargotxt = new TextBox();
            maskeddni = new MaskedTextBox();
            maskedtel = new MaskedTextBox();
            maskedcel = new MaskedTextBox();
            guardarbtn = new Button();
            entreadoempleadoLB = new Label();
            SuspendLayout();
            // 
            // nombretxt
            // 
            nombretxt.BackColor = SystemColors.ScrollBar;
            nombretxt.Enabled = false;
            nombretxt.Location = new Point(139, 138);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(204, 23);
            nombretxt.TabIndex = 10;
            nombretxt.TextChanged += nombretxt_TextChanged;
            // 
            // nuevobtn
            // 
            nuevobtn.BackColor = Color.FromArgb(0, 0, 192);
            nuevobtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nuevobtn.ForeColor = SystemColors.ButtonHighlight;
            nuevobtn.Location = new Point(273, 403);
            nuevobtn.Name = "nuevobtn";
            nuevobtn.Size = new Size(85, 35);
            nuevobtn.TabIndex = 18;
            nuevobtn.Text = "Nuevo";
            nuevobtn.UseVisualStyleBackColor = false;
            nuevobtn.Click += nuevobtn_Click;
            // 
            // nombreLB
            // 
            nombreLB.AutoSize = true;
            nombreLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            nombreLB.Location = new Point(66, 146);
            nombreLB.Name = "nombreLB";
            nombreLB.Size = new Size(62, 17);
            nombreLB.TabIndex = 2;
            nombreLB.Text = "Nombre:";
            // 
            // apellidoLB
            // 
            apellidoLB.AutoSize = true;
            apellidoLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            apellidoLB.Location = new Point(66, 196);
            apellidoLB.Name = "apellidoLB";
            apellidoLB.Size = new Size(64, 17);
            apellidoLB.TabIndex = 3;
            apellidoLB.Text = "Apellido:";
            // 
            // direccionLB
            // 
            direccionLB.AutoSize = true;
            direccionLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            direccionLB.Location = new Point(66, 240);
            direccionLB.Name = "direccionLB";
            direccionLB.Size = new Size(70, 17);
            direccionLB.TabIndex = 4;
            direccionLB.Text = "Direccion:";
            // 
            // dniLB
            // 
            dniLB.AutoSize = true;
            dniLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dniLB.Location = new Point(66, 289);
            dniLB.Name = "dniLB";
            dniLB.Size = new Size(36, 17);
            dniLB.TabIndex = 5;
            dniLB.Text = "DNI:";
            // 
            // emailLB
            // 
            emailLB.AutoSize = true;
            emailLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            emailLB.Location = new Point(381, 146);
            emailLB.Name = "emailLB";
            emailLB.Size = new Size(46, 17);
            emailLB.TabIndex = 6;
            emailLB.Text = "Email:";
            // 
            // telefonoLB
            // 
            telefonoLB.AutoSize = true;
            telefonoLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            telefonoLB.Location = new Point(381, 191);
            telefonoLB.Name = "telefonoLB";
            telefonoLB.Size = new Size(66, 17);
            telefonoLB.TabIndex = 7;
            telefonoLB.Text = "Telefono:";
            // 
            // celularLB
            // 
            celularLB.AutoSize = true;
            celularLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            celularLB.Location = new Point(381, 242);
            celularLB.Name = "celularLB";
            celularLB.Size = new Size(56, 17);
            celularLB.TabIndex = 8;
            celularLB.Text = "Celular:";
            // 
            // cargoLB
            // 
            cargoLB.AutoSize = true;
            cargoLB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cargoLB.Location = new Point(381, 287);
            cargoLB.Name = "cargoLB";
            cargoLB.Size = new Size(48, 17);
            cargoLB.TabIndex = 9;
            cargoLB.Text = "Cargo:";
            // 
            // apellidotxt
            // 
            apellidotxt.BackColor = SystemColors.ScrollBar;
            apellidotxt.Enabled = false;
            apellidotxt.Location = new Point(139, 188);
            apellidotxt.Name = "apellidotxt";
            apellidotxt.Size = new Size(204, 23);
            apellidotxt.TabIndex = 11;
            // 
            // direcciontxt
            // 
            direcciontxt.BackColor = SystemColors.ScrollBar;
            direcciontxt.Enabled = false;
            direcciontxt.Location = new Point(139, 232);
            direcciontxt.Name = "direcciontxt";
            direcciontxt.Size = new Size(204, 23);
            direcciontxt.TabIndex = 12;
            // 
            // emailtxt
            // 
            emailtxt.BackColor = SystemColors.ScrollBar;
            emailtxt.Enabled = false;
            emailtxt.Location = new Point(453, 140);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(204, 23);
            emailtxt.TabIndex = 14;
            // 
            // cargotxt
            // 
            cargotxt.BackColor = SystemColors.ScrollBar;
            cargotxt.Enabled = false;
            cargotxt.Location = new Point(453, 281);
            cargotxt.Name = "cargotxt";
            cargotxt.Size = new Size(190, 23);
            cargotxt.TabIndex = 17;
            // 
            // maskeddni
            // 
            maskeddni.BackColor = SystemColors.ScrollBar;
            maskeddni.Enabled = false;
            maskeddni.Location = new Point(139, 281);
            maskeddni.Mask = "000-0000000-0";
            maskeddni.Name = "maskeddni";
            maskeddni.Size = new Size(80, 23);
            maskeddni.TabIndex = 13;
            // 
            // maskedtel
            // 
            maskedtel.BackColor = SystemColors.ScrollBar;
            maskedtel.Enabled = false;
            maskedtel.Location = new Point(453, 185);
            maskedtel.Mask = "0-(999)-000-0000";
            maskedtel.Name = "maskedtel";
            maskedtel.Size = new Size(100, 23);
            maskedtel.TabIndex = 15;
            // 
            // maskedcel
            // 
            maskedcel.BackColor = SystemColors.ScrollBar;
            maskedcel.Enabled = false;
            maskedcel.Location = new Point(453, 234);
            maskedcel.Mask = "(999)-000-0000";
            maskedcel.Name = "maskedcel";
            maskedcel.Size = new Size(100, 23);
            maskedcel.TabIndex = 16;
            // 
            // guardarbtn
            // 
            guardarbtn.BackColor = Color.FromArgb(0, 192, 0);
            guardarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guardarbtn.ForeColor = SystemColors.ButtonHighlight;
            guardarbtn.Location = new Point(404, 403);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(78, 35);
            guardarbtn.TabIndex = 19;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // entreadoempleadoLB
            // 
            entreadoempleadoLB.AutoSize = true;
            entreadoempleadoLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            entreadoempleadoLB.Location = new Point(273, 60);
            entreadoempleadoLB.Name = "entreadoempleadoLB";
            entreadoempleadoLB.Size = new Size(209, 21);
            entreadoempleadoLB.TabIndex = 20;
            entreadoempleadoLB.Text = "ENTRADA DE EMPLEADOS";
            // 
            // agrempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(entreadoempleadoLB);
            Controls.Add(guardarbtn);
            Controls.Add(maskedcel);
            Controls.Add(maskedtel);
            Controls.Add(maskeddni);
            Controls.Add(cargotxt);
            Controls.Add(emailtxt);
            Controls.Add(direcciontxt);
            Controls.Add(apellidotxt);
            Controls.Add(cargoLB);
            Controls.Add(celularLB);
            Controls.Add(telefonoLB);
            Controls.Add(emailLB);
            Controls.Add(dniLB);
            Controls.Add(direccionLB);
            Controls.Add(apellidoLB);
            Controls.Add(nombreLB);
            Controls.Add(nuevobtn);
            Controls.Add(nombretxt);
            Cursor = Cursors.No;
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "agrempleado";
            Text = "Entrada de Empleado";
            Load += agrempleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombretxt;
        private Button nuevobtn;
        private Label nombreLB;
        private Label apellidoLB;
        private Label direccionLB;
        private Label dniLB;
        private Label emailLB;
        private Label telefonoLB;
        private Label celularLB;
        private Label cargoLB;
        private TextBox apellidotxt;
        private TextBox direcciontxt;
        private TextBox emailtxt;
        private TextBox cargotxt;
        private MaskedTextBox maskeddni;
        private MaskedTextBox maskedtel;
        private MaskedTextBox maskedcel;
        private Button guardarbtn;
        private Label entreadoempleadoLB;
    }
}