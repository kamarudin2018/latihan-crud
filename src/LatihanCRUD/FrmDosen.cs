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

namespace LatihanCRUD
{
    public partial class FrmDosen : Form
    {
        // deklarasi objek _conn untuk menghandle
        // koneksi ke database
        private OleDbConnection _conn;

        public FrmDosen()
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

            // validasi isbn harus diisi
            if (txtIsbn1.Text.Length == 0)
            {
                MessageBox.Show("ISBN harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                txtIsbn1.Focus();
                return;
            }

            // validasi judul harus diisi
            if (txtJudul1.Text.Length == 0)
            {
                MessageBox.Show("Judul harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                txtJudul1.Focus();
                return;
            }

            var sql = @"insert into buku (isbn, judul, thn_terbit, bahasa)
                        values (@isbn, @judul, @thn_terbit, @bahasa)";

            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@isbn", txtIsbn1.Text);
                cmd.Parameters.AddWithValue("@judul", txtJudul1.Text);
                cmd.Parameters.AddWithValue("@thn_terbit", txtTahunTerbit1.Text);
                cmd.Parameters.AddWithValue("@bahasa", txtBahasa1.Text);

                result = cmd.ExecuteNonQuery();
            }

            if (result > 0)
            {
                MessageBox.Show("Data buku berhasil disimpan !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // reset form
                txtIsbn1.Clear();
                txtJudul1.Clear();
                txtTahunTerbit1.Clear();
                txtBahasa1.Clear();

                txtIsbn1.Focus();
            }
            else
                MessageBox.Show("Data buku gagal disimpan !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
        }

        private void btnTampilkanData_Click(object sender, EventArgs e)
        {
            lstDosen.Items.Clear();

            var sql = @"select isbn, judul, thn_terbit, bahasa
                        from buku
                        order by judul";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                using (var dtr = cmd.ExecuteReader())
                {
                    var noUrut = 1;

                    while (dtr.Read())
                    {
                        var data = string.Format("{0}. {1}, {2}, {3}, {4}",
                                noUrut, dtr["isbn"].ToString(), dtr["judul"].ToString(),
                                dtr["thn_terbit"].ToString(), dtr["bahasa"].ToString());

                        lstDosen.Items.Add(data);

                        noUrut++;
                    }
                }
            }
        }

        private void btnCari1_Click(object sender, EventArgs e)
        {
            var sql = @"select isbn, judul, thn_terbit, bahasa
                        from buku
                        where isbn = @isbn";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@isbn", txtIsbn2.Text);

                using (var dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        txtIsbn2.Text = dtr["isbn"].ToString();
                        txtJudul2.Text = dtr["judul"].ToString();
                        txtTahunTerbit2.Text = dtr["thn_terbit"].ToString();
                        txtBahasa2.Text = dtr["bahasa"].ToString();
                    }
                    else
                        MessageBox.Show("Data buku tidak ditemukan !", "Informasi", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi isbn harus diisi
            if (txtIsbn2.Text.Length == 0)
            {
                MessageBox.Show("ISBN harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                txtIsbn2.Focus();
                return;
            }

            // validasi judul harus diisi
            if (txtJudul2.Text.Length == 0)
            {
                MessageBox.Show("Judul harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                txtJudul2.Focus();
                return;
            }

            var sql = @"update buku set judul = @judul, thn_terbit = @thn_terbit, bahasa = @bahasa
                        where isbn = @isbn";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@judul", txtJudul2.Text);
                cmd.Parameters.AddWithValue("@thn_terbit", txtTahunTerbit2.Text);
                cmd.Parameters.AddWithValue("@bahasa", txtBahasa2.Text);
                cmd.Parameters.AddWithValue("@isbn", txtIsbn2.Text);

                result = cmd.ExecuteNonQuery();
            }

            if (result > 0)
            {
                MessageBox.Show("Data buku berhasil diupdate !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // reset form
                txtIsbn2.Clear();
                txtJudul2.Clear();
                txtTahunTerbit2.Clear();
                txtBahasa2.Clear();
                txtIsbn2.Focus();
            }
            else
                MessageBox.Show("Data buku gagal diupdate !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
        }

        private void btnCari2_Click(object sender, EventArgs e)
        {
            var sql = @"select isbn, judul, thn_terbit, bahasa
                        from buku
                        where isbn = @isbn";
            using (var cmd = new OleDbCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@isbn", txtIsbn3.Text);

                using (var dtr = cmd.ExecuteReader())
                {
                    if (dtr.Read())
                    {
                        txtIsbn3.Text = dtr["isbn"].ToString();
                        txtJudul3.Text = dtr["judul"].ToString();
                        txtTahunTerbit3.Text = dtr["thn_terbit"].ToString();
                        txtBahasa3.Text = dtr["bahasa"].ToString();
                    }
                    else
                        MessageBox.Show("Data buku tidak ditemukan !", "Informasi", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var result = 0;

            if (MessageBox.Show("Apakah data buku ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                var sql = @"delete from buku
                            where isbn = @isbn";
                using (var cmd = new OleDbCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", txtIsbn3.Text);

                    result = cmd.ExecuteNonQuery();
                }

                if (result > 0)
                {
                    MessageBox.Show("Data buku berhasil dihapus!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // reset form
                    txtIsbn3.Clear();
                    txtJudul3.Clear();
                    txtTahunTerbit3.Clear();
                    txtBahasa3.Clear();

                    txtIsbn3.Focus();
                }
                else
                    MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
            }
        }
    }
}
