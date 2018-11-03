using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace LatihanCRUD
{
    public partial class Form1 : Form
    {
        // deklarasi objek _conn untuk menghandle
        // koneksi ke database
        private OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTesKoneksi_Click(object sender, EventArgs e)
        {
            var dbName = Directory.GetCurrentDirectory() + "\\DbPerpustakaan.mdb";

            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbName);

            _conn = GetOpenConnection(connectionString);

            if (_conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Koneksi ke database berhasil !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Koneksi ke database gagal !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
        }

        private OleDbConnection GetOpenConnection()
        {
            OleDbConnection conn = null;

            //try
            //{
                var dbName = Directory.GetCurrentDirectory() + "\\DbPerpustakaan.mdb";

                var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbName);

                conn = new OleDbConnection(connectionString);
                conn.Open();
            //}
            //catch
            //{
            //}

            return conn;
        }

        private OleDbConnection GetOpenConnection(string connectionString)
        {
            OleDbConnection conn = null;

            try
            {
                conn = new OleDbConnection(connectionString);
                conn.Open();
            }
            catch
            {
            }

            return conn;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi npm harus diisi
            if (!mskNpm1.MaskFull)
            {
                MessageBox.Show("NPM harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                mskNpm1.Focus();
                return;
            }

            // validasi nama harus diisi
            if (txtNama1.Text.Length == 0)
            {
                MessageBox.Show("Nama harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                txtNama1.Focus();
                return;
            }

            var sql = @"insert into mahasiswa (npm, nama, angkatan)
                        values (@npm, @nama, @angkatan)";

            using (var conn = GetOpenConnection())
            {
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@npm", mskNpm1.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNama1.Text);
                    cmd.Parameters.AddWithValue("@angkatan", txtAngkatan1.Text);

                    result = cmd.ExecuteNonQuery();
                }
            }            

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // reset form
                mskNpm1.Clear();
                txtNama1.Clear();
                txtAngkatan1.Clear();
                mskNpm1.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            lstMahasiswa.Items.Clear();

            var sql = @"select npm, nama, angkatan 
                        from mahasiswa 
                        order by nama";

            using (var conn = GetOpenConnection())
            {
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    using (var dtr = cmd.ExecuteReader())
                    {
                        var noUrut = 1;

                        while (dtr.Read())
                        {
                            var data = string.Format("{0}. {1}, {2}, {3}",
                                    noUrut, dtr["npm"].ToString(), dtr["nama"].ToString(),
                                    dtr["angkatan"].ToString());

                            lstMahasiswa.Items.Add(data);

                            noUrut++;
                        }
                    }
                }
            }            
        }

        private void btnCari1_Click(object sender, EventArgs e)
        {
            var sql = @"select npm, nama, angkatan
                        from mahasiswa 
                        where npm = @npm";

            using (var conn = GetOpenConnection())
            {
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@npm", mskNpm2.Text);

                    using (var dtr = cmd.ExecuteReader())
                    {
                        if (dtr.Read())
                        {
                            mskNpm2.Text = dtr["npm"].ToString();
                            txtNama2.Text = dtr["nama"].ToString();
                            txtAngkatan2.Text = dtr["angkatan"].ToString();
                        }
                        else
                            MessageBox.Show("Data mahasiswa tidak ditemukan !", "Informasi", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                }
            }            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi npm harus diisi
            if (!mskNpm2.MaskFull)
            {
                MessageBox.Show("NPM harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                mskNpm2.Focus();
                return;
            }

            // validasi nama harus diisi
            if (txtNama2.Text.Length == 0)
            {
                MessageBox.Show("Nama harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                txtNama2.Focus();
                return;
            }

            var sql = @"update mahasiswa set nama = @nama, angkatan = @angkatan
                        where npm = @npm";

            using (var conn = GetOpenConnection())
            {
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", txtNama2.Text);
                    cmd.Parameters.AddWithValue("@angkatan", txtAngkatan2.Text);
                    cmd.Parameters.AddWithValue("@npm", mskNpm2.Text);

                    result = cmd.ExecuteNonQuery();
                }
            }            

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil diupdate !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // reset form
                mskNpm2.Clear();
                txtNama2.Clear();
                txtAngkatan2.Clear();
                mskNpm2.Focus();
            }
            else
                MessageBox.Show("Data mahasiswa gagal diupdate !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
        }

        private void btnCari2_Click(object sender, EventArgs e)
        {
            var sql = @"select npm, nama, angkatan
                        from mahasiswa 
                        where npm = @npm";
            using (var conn = GetOpenConnection())
            {
                using (var cmd = new OleDbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@npm", mskNpm3.Text);

                    using (var dtr = cmd.ExecuteReader())
                    {
                        if (dtr.Read())
                        {
                            mskNpm3.Text = dtr["npm"].ToString();
                            txtNama3.Text = dtr["nama"].ToString();
                            txtAngkatan3.Text = dtr["angkatan"].ToString();
                        }
                        else
                            MessageBox.Show("Data mahasiswa tidak ditemukan !", "Informasi", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    }
                }
            }            
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var result = 0;

            var konfirmasi = MessageBox.Show("Apakah data mahasiswa ingin dihapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (konfirmasi == DialogResult.Yes)
            {
                var sql = @"delete from mahasiswa
                            where npm = @npm";
                using (var conn = GetOpenConnection())
                {
                    using (var cmd = new OleDbCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@npm", mskNpm3.Text);

                        result = cmd.ExecuteNonQuery();
                    }
                }                

                if (result > 0)
                {
                    MessageBox.Show("Data mahasiswa berhasil dihapus!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // reset form
                    mskNpm3.Clear();
                    txtNama3.Clear();
                    txtAngkatan3.Clear();
                    mskNpm3.Focus();
                }
                else
                    MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
            }
        }
    }
}
