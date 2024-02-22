using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PAS_CRUD
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            bind_data();
        }

        SqlConnection conn = new SqlConnection("Data Source=YASKRAZ\\SQLEXPRESS;Initial Catalog=crudyasapas;Integrated Security=True;");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select kodeobat, namaobat, kategoriobat, hargaobat, deskripsiobat, stockobat , tanggalkadaluwarsa from data_apotik", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textboxKeterangan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (calendar.Visible == false)
            {
                calendar.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Pastikan sel valid
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                tb_kode.Text = selectedRow.Cells[0].Value.ToString();
                tb_nama.Text = selectedRow.Cells[1].Value.ToString();

                var kategoriObat = selectedRow.Cells[2].Value.ToString();
                rb_bebas.Checked = kategoriObat == "Obat Bebas";
                rb_resep.Checked = kategoriObat == "Obat Resep";

                cb_harga.Text = selectedRow.Cells[3].Value.ToString();
                tb_desc.Text = selectedRow.Cells[4].Value.ToString();

                var stockObat = selectedRow.Cells[5].Value.ToString();
                cb_ada.Checked = stockObat == "Ada";
                cb_kosong.Checked = stockObat == "Kosong";

                tb_tanggal.Text = selectedRow.Cells[6].Value.ToString();
            }
        }



        private void btn_insert_Click(object sender, EventArgs e)
        {

            string kategoriObat = rb_bebas.Checked ? rb_bebas.Text : rb_resep.Checked ? rb_resep.Text : "";

            string stockObat = cb_ada.Checked ? cb_ada.Text : cb_kosong.Checked ? cb_kosong.Text : "";

            SqlCommand cmdCheck = new SqlCommand("SELECT COUNT(*) FROM data_apotik WHERE kodeobat = @kodeobat", conn);
            cmdCheck.Parameters.AddWithValue("@kodeobat", tb_kode.Text);

            conn.Open();
            int count = (int)cmdCheck.ExecuteScalar(); // Mengeksekusi query dan mendapatkan jumlah hasil

            if (count > 0) // Jika jumlah hasil lebih dari 0, berarti kode obat sudah ada
            {
                MessageBox.Show("Kode obat sudah ada dalam database. Silakan masukkan kode obat yang berbeda.", "Duplicate Kode Obat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                SqlCommand cmdInsert = new SqlCommand("INSERT INTO data_apotik(kodeobat, namaobat, kategoriobat, hargaobat, deskripsiobat, stockobat, tanggalkadaluwarsa) VALUES(@kodeobat, @namaobat, @kategoriobat, @hargaobat, @deskripsi, @stockobat, @tanggalkadaluwarsa)", conn);
                cmdInsert.Parameters.AddWithValue("@kodeobat", tb_kode.Text);
                cmdInsert.Parameters.AddWithValue("@namaobat", tb_nama.Text);
                cmdInsert.Parameters.AddWithValue("@kategoriobat", kategoriObat);
                cmdInsert.Parameters.AddWithValue("@hargaobat", cb_harga.Text);
                cmdInsert.Parameters.AddWithValue("@deskripsi", tb_desc.Text);
                cmdInsert.Parameters.AddWithValue("@stockobat", stockObat); 
                cmdInsert.Parameters.AddWithValue("@tanggalkadaluwarsa", tb_tanggal.Text);

                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil disimpan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
            bind_data();
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            tb_kode.Text = "";
            tb_nama.Text = "";
            rb_bebas.Checked = false;
            rb_resep.Checked = false;
            cb_harga.SelectedIndex = -1;
            tb_desc.Text = "";
            cb_kosong.Checked = false;
            cb_ada.Checked = false;
            tb_tanggal.Text = "";
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = calendar.SelectionStart;

            string formattedDate = selectedDate.ToString("dd/MM/yyyy");

            tb_tanggal.Text = formattedDate;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (calendar.Visible == true)
            {
                calendar.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from data_apotik where kodeobat=@kodeobat", conn);
            cmd4.Parameters.AddWithValue("kodeobat", tb_kode.Text);
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string kategoriObat = rb_bebas.Checked ? rb_bebas.Text : rb_resep.Checked ? rb_resep.Text : "";

            string stockObat = cb_ada.Checked ? cb_ada.Text : cb_kosong.Checked ? cb_kosong.Text : "";

            SqlCommand cmdUpdate = new SqlCommand("UPDATE data_apotik SET namaobat=@namaobat, kategoriobat=@kategoriobat, hargaobat=@hargaobat, deskripsiobat=@deskripsi, stockobat=@stockobat, tanggalkadaluwarsa=@tanggalkadaluwarsa WHERE kodeobat=@kodeobat", conn);


            cmdUpdate.Parameters.AddWithValue("@kodeobat", tb_kode.Text);
            cmdUpdate.Parameters.AddWithValue("@namaobat", tb_nama.Text);
            cmdUpdate.Parameters.AddWithValue("@kategoriobat", kategoriObat);
            cmdUpdate.Parameters.AddWithValue("@hargaobat", cb_harga.Text);
            cmdUpdate.Parameters.AddWithValue("@deskripsi", tb_desc.Text);
            cmdUpdate.Parameters.AddWithValue("@stockobat", stockObat);
            cmdUpdate.Parameters.AddWithValue("@tanggalkadaluwarsa", tb_tanggal.Text);
            conn.Open();
            cmdUpdate.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            string keyword = tbx_search.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                
                bind_data();
            }
            else
            {
                
                string query = "SELECT kodeobat, namaobat, kategoriobat, hargaobat, deskripsiobat, stockobat, tanggalkadaluwarsa FROM data_apotik WHERE kodeobat LIKE @keyword OR namaobat LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin LogOut?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
        }

        private void cb_resep_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_kosong.Checked)
            {
                cb_ada.Checked = false; 
            }
        }

        private void cb_ada_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ada.Checked)
            {
                cb_kosong.Checked = false;
            }
        }
    }
}
