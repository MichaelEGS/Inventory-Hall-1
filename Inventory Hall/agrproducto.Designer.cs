﻿namespace Inventory_Hall
{
    partial class agrproducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrproducto));
            LBnombre = new Label();
            LBcategoria = new Label();
            LBdescripcion = new Label();
            LBstock = new Label();
            LBidsuplidor = new Label();
            LBseccion = new Label();
            insertarbtn = new Button();
            guardarbtn = new Button();
            nombretxt = new TextBox();
            descripciontxt = new TextBox();
            stocktxt = new TextBox();
            secciontxt = new TextBox();
            categoriabox = new ComboBox();
            idsuplidortxt = new ComboBox();
            entradadeproductosLB = new Label();
            SuspendLayout();
            // 
            // LBnombre
            // 
            LBnombre.AutoSize = true;
            LBnombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBnombre.Location = new Point(46, 81);
            LBnombre.Name = "LBnombre";
            LBnombre.Size = new Size(62, 17);
            LBnombre.TabIndex = 0;
            LBnombre.Text = "Nombre:";
            // 
            // LBcategoria
            // 
            LBcategoria.AutoSize = true;
            LBcategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBcategoria.Location = new Point(46, 120);
            LBcategoria.Name = "LBcategoria";
            LBcategoria.Size = new Size(71, 17);
            LBcategoria.TabIndex = 1;
            LBcategoria.Text = "Categoria:";
            // 
            // LBdescripcion
            // 
            LBdescripcion.AutoSize = true;
            LBdescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBdescripcion.Location = new Point(46, 169);
            LBdescripcion.Name = "LBdescripcion";
            LBdescripcion.Size = new Size(84, 17);
            LBdescripcion.TabIndex = 2;
            LBdescripcion.Text = "Descripcion:";
            // 
            // LBstock
            // 
            LBstock.AutoSize = true;
            LBstock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBstock.Location = new Point(63, 211);
            LBstock.Name = "LBstock";
            LBstock.Size = new Size(46, 17);
            LBstock.TabIndex = 3;
            LBstock.Text = "Stock:";
            // 
            // LBidsuplidor
            // 
            LBidsuplidor.AutoSize = true;
            LBidsuplidor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBidsuplidor.Location = new Point(48, 258);
            LBidsuplidor.Name = "LBidsuplidor";
            LBidsuplidor.Size = new Size(83, 17);
            LBidsuplidor.TabIndex = 4;
            LBidsuplidor.Text = "ID Suplidor:";
            // 
            // LBseccion
            // 
            LBseccion.AutoSize = true;
            LBseccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            LBseccion.Location = new Point(59, 306);
            LBseccion.Name = "LBseccion";
            LBseccion.Size = new Size(58, 17);
            LBseccion.TabIndex = 5;
            LBseccion.Text = "Seccion:";
            // 
            // insertarbtn
            // 
            insertarbtn.BackColor = Color.Blue;
            insertarbtn.Cursor = Cursors.Hand;
            insertarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertarbtn.ForeColor = SystemColors.ButtonFace;
            insertarbtn.Location = new Point(291, 394);
            insertarbtn.Name = "insertarbtn";
            insertarbtn.Size = new Size(80, 35);
            insertarbtn.TabIndex = 6;
            insertarbtn.Text = "Nuevo";
            insertarbtn.UseVisualStyleBackColor = false;
            insertarbtn.Click += insertarbtn_Click;
            // 
            // guardarbtn
            // 
            guardarbtn.AutoSize = true;
            guardarbtn.BackColor = Color.FromArgb(0, 192, 0);
            guardarbtn.Cursor = Cursors.Hand;
            guardarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guardarbtn.ForeColor = SystemColors.ButtonFace;
            guardarbtn.Location = new Point(465, 394);
            guardarbtn.Name = "guardarbtn";
            guardarbtn.Size = new Size(75, 35);
            guardarbtn.TabIndex = 7;
            guardarbtn.Text = "Guardar";
            guardarbtn.UseVisualStyleBackColor = false;
            guardarbtn.Click += guardarbtn_Click;
            // 
            // nombretxt
            // 
            nombretxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nombretxt.BackColor = SystemColors.ControlDark;
            nombretxt.Enabled = false;
            nombretxt.Location = new Point(134, 81);
            nombretxt.Name = "nombretxt";
            nombretxt.Size = new Size(237, 23);
            nombretxt.TabIndex = 8;
            // 
            // descripciontxt
            // 
            descripciontxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descripciontxt.BackColor = SystemColors.ControlDark;
            descripciontxt.Enabled = false;
            descripciontxt.Location = new Point(134, 169);
            descripciontxt.Name = "descripciontxt";
            descripciontxt.Size = new Size(237, 23);
            descripciontxt.TabIndex = 10;
            // 
            // stocktxt
            // 
            stocktxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stocktxt.BackColor = SystemColors.ControlDark;
            stocktxt.Enabled = false;
            stocktxt.Location = new Point(134, 217);
            stocktxt.Name = "stocktxt";
            stocktxt.Size = new Size(237, 23);
            stocktxt.TabIndex = 11;
            // 
            // secciontxt
            // 
            secciontxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            secciontxt.BackColor = SystemColors.ControlDark;
            secciontxt.Enabled = false;
            secciontxt.Location = new Point(134, 306);
            secciontxt.Name = "secciontxt";
            secciontxt.Size = new Size(237, 23);
            secciontxt.TabIndex = 13;
            // 
            // categoriabox
            // 
            categoriabox.BackColor = SystemColors.ScrollBar;
            categoriabox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoriabox.Enabled = false;
            categoriabox.FormattingEnabled = true;
            categoriabox.Location = new Point(134, 120);
            categoriabox.Name = "categoriabox";
            categoriabox.Size = new Size(237, 23);
            categoriabox.TabIndex = 9;
            categoriabox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // idsuplidortxt
            // 
            idsuplidortxt.BackColor = SystemColors.ScrollBar;
            idsuplidortxt.DropDownStyle = ComboBoxStyle.DropDownList;
            idsuplidortxt.Enabled = false;
            idsuplidortxt.FormattingEnabled = true;
            idsuplidortxt.Location = new Point(134, 258);
            idsuplidortxt.Name = "idsuplidortxt";
            idsuplidortxt.Size = new Size(237, 23);
            idsuplidortxt.TabIndex = 12;
            idsuplidortxt.SelectedIndexChanged += idsuplidortxt_SelectedIndexChanged;
            // 
            // entradadeproductosLB
            // 
            entradadeproductosLB.AutoSize = true;
            entradadeproductosLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            entradadeproductosLB.Location = new Point(297, 32);
            entradadeproductosLB.Name = "entradadeproductosLB";
            entradadeproductosLB.Size = new Size(209, 21);
            entradadeproductosLB.TabIndex = 14;
            entradadeproductosLB.Text = "ENTRADA DE PRODUCTOS";
            // 
            // agrproducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(entradadeproductosLB);
            Controls.Add(idsuplidortxt);
            Controls.Add(categoriabox);
            Controls.Add(secciontxt);
            Controls.Add(stocktxt);
            Controls.Add(descripciontxt);
            Controls.Add(nombretxt);
            Controls.Add(guardarbtn);
            Controls.Add(insertarbtn);
            Controls.Add(LBseccion);
            Controls.Add(LBidsuplidor);
            Controls.Add(LBstock);
            Controls.Add(LBdescripcion);
            Controls.Add(LBcategoria);
            Controls.Add(LBnombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "agrproducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada de Producto";
            Load += agrproducto_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBnombre;
        private Label LBcategoria;
        private Label LBdescripcion;
        private Label LBstock;
        private Label LBidsuplidor;
        private Label LBseccion;
        private Button insertarbtn;
        private Button guardarbtn;
        private TextBox nombretxt;
        private TextBox descripciontxt;
        private TextBox stocktxt;
        private TextBox secciontxt;
        private ComboBox categoriabox;
        private ComboBox idsuplidortxt;
        private Label entradadeproductosLB;
    }
}