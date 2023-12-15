namespace Inventory_Hall
{
    partial class consuplidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consuplidor));
            dataGridView1 = new DataGridView();
            buscarbtn = new Button();
            refreshbtn = new Button();
            buscartxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1058, 323);
            dataGridView1.TabIndex = 0;
            // 
            // buscarbtn
            // 
            buscarbtn.BackColor = Color.FromArgb(0, 192, 0);
            buscarbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buscarbtn.Image = Properties.Resources.seachx3;
            buscarbtn.ImageAlign = ContentAlignment.MiddleLeft;
            buscarbtn.Location = new Point(407, 415);
            buscarbtn.Name = "buscarbtn";
            buscarbtn.Size = new Size(91, 46);
            buscarbtn.TabIndex = 1;
            buscarbtn.Text = "Buscar";
            buscarbtn.TextAlign = ContentAlignment.MiddleRight;
            buscarbtn.UseVisualStyleBackColor = false;
            buscarbtn.Click += buscarbtn_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.BackColor = Color.Blue;
            refreshbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            refreshbtn.Image = Properties.Resources.refresh_icon;
            refreshbtn.ImageAlign = ContentAlignment.MiddleLeft;
            refreshbtn.Location = new Point(549, 415);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(94, 46);
            refreshbtn.TabIndex = 2;
            refreshbtn.Text = "Refresh";
            refreshbtn.TextAlign = ContentAlignment.MiddleRight;
            refreshbtn.UseVisualStyleBackColor = false;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // buscartxt
            // 
            buscartxt.Location = new Point(697, 415);
            buscartxt.Multiline = true;
            buscartxt.Name = "buscartxt";
            buscartxt.Size = new Size(166, 46);
            buscartxt.TabIndex = 3;
            buscartxt.TextChanged += buscartxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(495, 25);
            label1.Name = "label1";
            label1.Size = new Size(171, 21);
            label1.TabIndex = 4;
            label1.Text = "Consulta De Suplidor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(720, 386);
            label2.Name = "label2";
            label2.Size = new Size(106, 17);
            label2.TabIndex = 5;
            label2.Text = "Inserte Suplidor";
            label2.Click += label2_Click;
            // 
            // consuplidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1127, 473);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buscartxt);
            Controls.Add(refreshbtn);
            Controls.Add(buscarbtn);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "consuplidor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Suplidor";
            Load += consuplidor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buscarbtn;
        private Button refreshbtn;
        private TextBox buscartxt;
        private Label label1;
        private Label label2;
    }
}