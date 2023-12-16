namespace Inventory_Hall
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            loginbtn = new Button();
            cancelarbtn = new Button();
            usuariolb = new Label();
            usuariotxt = new TextBox();
            maskedcon = new MaskedTextBox();
            passwordlb = new Label();
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(0, 192, 0);
            loginbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            loginbtn.Location = new Point(457, 349);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(129, 67);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Iniciar Sesion";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // cancelarbtn
            // 
            cancelarbtn.BackColor = Color.FromArgb(192, 0, 0);
            cancelarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelarbtn.ForeColor = Color.Black;
            cancelarbtn.Location = new Point(656, 349);
            cancelarbtn.Name = "cancelarbtn";
            cancelarbtn.Size = new Size(86, 67);
            cancelarbtn.TabIndex = 1;
            cancelarbtn.Text = "Cancelar";
            cancelarbtn.UseVisualStyleBackColor = false;
            cancelarbtn.Click += cancelarbtn_Click;
            // 
            // usuariolb
            // 
            usuariolb.AutoSize = true;
            usuariolb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usuariolb.Location = new Point(587, 40);
            usuariolb.Name = "usuariolb";
            usuariolb.Size = new Size(59, 17);
            usuariolb.TabIndex = 2;
            usuariolb.Text = "Usuario:";
            // 
            // usuariotxt
            // 
            usuariotxt.Location = new Point(492, 94);
            usuariotxt.Name = "usuariotxt";
            usuariotxt.Size = new Size(250, 23);
            usuariotxt.TabIndex = 4;
            // 
            // maskedcon
            // 
            maskedcon.Location = new Point(492, 259);
            maskedcon.Name = "maskedcon";
            maskedcon.PasswordChar = '*';
            maskedcon.Size = new Size(250, 23);
            maskedcon.TabIndex = 5;
            // 
            // passwordlb
            // 
            passwordlb.AutoSize = true;
            passwordlb.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            passwordlb.Location = new Point(578, 211);
            passwordlb.Name = "passwordlb";
            passwordlb.Size = new Size(81, 17);
            passwordlb.TabIndex = 6;
            passwordlb.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 450);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 50);
            label2.Name = "label2";
            label2.Size = new Size(254, 32);
            label2.TabIndex = 8;
            label2.Text = "INVENTORY HALL";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 283;
            iconPictureBox1.Location = new Point(45, 94);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(283, 290);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordlb);
            Controls.Add(maskedcon);
            Controls.Add(usuariotxt);
            Controls.Add(usuariolb);
            Controls.Add(cancelarbtn);
            Controls.Add(loginbtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CONTROL DE ACCESO";
            Load += frmlogin_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Button cancelarbtn;
        private Label usuariolb;
        private TextBox usuariotxt;
        private MaskedTextBox maskedcon;
        private Label passwordlb;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}