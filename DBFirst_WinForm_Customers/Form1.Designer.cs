namespace DBFirst_WinForm_Customers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            txtSırketAdı = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSıl = new Button();
            dgvMusteriler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(132, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(266, 23);
            txtId.TabIndex = 0;
            // 
            // txtSırketAdı
            // 
            txtSırketAdı.Location = new Point(128, 78);
            txtSırketAdı.Name = "txtSırketAdı";
            txtSırketAdı.Size = new Size(270, 23);
            txtSırketAdı.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 2;
            label1.Text = "ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 84);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Sirket Adi: ";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(40, 128);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(184, 128);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 23);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GUNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSıl
            // 
            btnSıl.Location = new Point(323, 128);
            btnSıl.Name = "btnSıl";
            btnSıl.Size = new Size(75, 23);
            btnSıl.TabIndex = 6;
            btnSıl.Text = "SIL";
            btnSıl.UseVisualStyleBackColor = true;
            btnSıl.Click += btnSıl_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(35, 180);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowTemplate.Height = 25;
            dgvMusteriler.Size = new Size(741, 258);
            dgvMusteriler.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMusteriler);
            Controls.Add(btnSıl);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSırketAdı);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtSırketAdı;
        private Label label1;
        private Label label2;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSıl;
        private DataGridView dgvMusteriler;
    }
}