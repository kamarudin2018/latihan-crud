namespace LatihanCRUD
{
    partial class Form1
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
            this.btnTesKoneksi = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.mskNpm1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAngkatan1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstMahasiswa = new System.Windows.Forms.ListBox();
            this.btnTampilkanData = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCari1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mskNpm2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAngkatan2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNama2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCari2 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.mskNpm3 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAngkatan3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNama3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTesKoneksi
            // 
            this.btnTesKoneksi.Location = new System.Drawing.Point(12, 12);
            this.btnTesKoneksi.Name = "btnTesKoneksi";
            this.btnTesKoneksi.Size = new System.Drawing.Size(75, 23);
            this.btnTesKoneksi.TabIndex = 0;
            this.btnTesKoneksi.Text = "Tes Koneksi";
            this.btnTesKoneksi.UseVisualStyleBackColor = true;
            this.btnTesKoneksi.Visible = false;
            this.btnTesKoneksi.Click += new System.EventHandler(this.btnTesKoneksi_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 233);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Controls.Add(this.mskNpm1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtAngkatan1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNama1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(15, 96);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // mskNpm1
            // 
            this.mskNpm1.Location = new System.Drawing.Point(71, 18);
            this.mskNpm1.Mask = "##.##.####";
            this.mskNpm1.Name = "mskNpm1";
            this.mskNpm1.Size = new System.Drawing.Size(62, 20);
            this.mskNpm1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Angkatan";
            // 
            // txtAngkatan1
            // 
            this.txtAngkatan1.Location = new System.Drawing.Point(71, 70);
            this.txtAngkatan1.Name = "txtAngkatan1";
            this.txtAngkatan1.Size = new System.Drawing.Size(100, 20);
            this.txtAngkatan1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // txtNama1
            // 
            this.txtNama1.Location = new System.Drawing.Point(71, 44);
            this.txtNama1.Name = "txtNama1";
            this.txtNama1.Size = new System.Drawing.Size(246, 20);
            this.txtNama1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NPM";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstMahasiswa);
            this.tabPage2.Controls.Add(this.btnTampilkanData);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstMahasiswa
            // 
            this.lstMahasiswa.FormattingEnabled = true;
            this.lstMahasiswa.Location = new System.Drawing.Point(10, 40);
            this.lstMahasiswa.Name = "lstMahasiswa";
            this.lstMahasiswa.Size = new System.Drawing.Size(321, 160);
            this.lstMahasiswa.TabIndex = 3;
            // 
            // btnTampilkanData
            // 
            this.btnTampilkanData.Location = new System.Drawing.Point(10, 10);
            this.btnTampilkanData.Name = "btnTampilkanData";
            this.btnTampilkanData.Size = new System.Drawing.Size(115, 23);
            this.btnTampilkanData.TabIndex = 2;
            this.btnTampilkanData.Text = "Tampilkan Data";
            this.btnTampilkanData.UseVisualStyleBackColor = true;
            this.btnTampilkanData.Click += new System.EventHandler(this.btnTampilkanData_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCari1);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.mskNpm2);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtAngkatan2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtNama2);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(337, 207);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCari1
            // 
            this.btnCari1.Location = new System.Drawing.Point(137, 11);
            this.btnCari1.Name = "btnCari1";
            this.btnCari1.Size = new System.Drawing.Size(75, 23);
            this.btnCari1.TabIndex = 11;
            this.btnCari1.Text = "Cari";
            this.btnCari1.UseVisualStyleBackColor = true;
            this.btnCari1.Click += new System.EventHandler(this.btnCari1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mskNpm2
            // 
            this.mskNpm2.Location = new System.Drawing.Point(69, 13);
            this.mskNpm2.Mask = "##.##.####";
            this.mskNpm2.Name = "mskNpm2";
            this.mskNpm2.Size = new System.Drawing.Size(62, 20);
            this.mskNpm2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Angkatan";
            // 
            // txtAngkatan2
            // 
            this.txtAngkatan2.Location = new System.Drawing.Point(69, 65);
            this.txtAngkatan2.Name = "txtAngkatan2";
            this.txtAngkatan2.Size = new System.Drawing.Size(100, 20);
            this.txtAngkatan2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nama";
            // 
            // txtNama2
            // 
            this.txtNama2.Location = new System.Drawing.Point(69, 39);
            this.txtNama2.Name = "txtNama2";
            this.txtNama2.Size = new System.Drawing.Size(254, 20);
            this.txtNama2.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "NPM";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCari2);
            this.tabPage4.Controls.Add(this.btnHapus);
            this.tabPage4.Controls.Add(this.mskNpm3);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtAngkatan3);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtNama3);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(337, 207);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Delete";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCari2
            // 
            this.btnCari2.Location = new System.Drawing.Point(136, 13);
            this.btnCari2.Name = "btnCari2";
            this.btnCari2.Size = new System.Drawing.Size(75, 23);
            this.btnCari2.TabIndex = 18;
            this.btnCari2.Text = "Cari";
            this.btnCari2.UseVisualStyleBackColor = true;
            this.btnCari2.Click += new System.EventHandler(this.btnCari2_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(12, 93);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 17;
            this.btnHapus.Text = "Delete";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // mskNpm3
            // 
            this.mskNpm3.Location = new System.Drawing.Point(68, 15);
            this.mskNpm3.Mask = "##.##.####";
            this.mskNpm3.Name = "mskNpm3";
            this.mskNpm3.Size = new System.Drawing.Size(62, 20);
            this.mskNpm3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Angkatan";
            // 
            // txtAngkatan3
            // 
            this.txtAngkatan3.Location = new System.Drawing.Point(68, 67);
            this.txtAngkatan3.Name = "txtAngkatan3";
            this.txtAngkatan3.Size = new System.Drawing.Size(62, 20);
            this.txtAngkatan3.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nama";
            // 
            // txtNama3
            // 
            this.txtNama3.Location = new System.Drawing.Point(68, 41);
            this.txtNama3.Name = "txtNama3";
            this.txtNama3.Size = new System.Drawing.Size(253, 20);
            this.txtNama3.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "NPM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 298);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnTesKoneksi);
            this.Name = "Form1";
            this.Text = "Latihan CRUD";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesKoneksi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.MaskedTextBox mskNpm1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAngkatan1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstMahasiswa;
        private System.Windows.Forms.Button btnTampilkanData;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCari1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MaskedTextBox mskNpm2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAngkatan2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNama2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCari2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.MaskedTextBox mskNpm3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAngkatan3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNama3;
        private System.Windows.Forms.Label label9;
    }
}

