using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invetarisDataSet.Barang_Masuk' table. You can move, or remove it, as needed.
            //this.barang_MasukTableAdapter.Fill(this.invetarisDataSet.Barang_Masuk);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Barang_Masuk", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Barang_Masuk values (@No_Masuk_Barang, @Kode_Barang, @Nama_Barang, " +
                "@Tanggal_Masuk, @Harga_Satuan, @Kuantitas, @Harga_total)", con);
            cmd.Parameters.AddWithValue("@Kode_Barang", txtKodeBrgMsk.Text);
            cmd.Parameters.AddWithValue("@Nama_Barang", txtNamaBrgMsk.Text);
            cmd.Parameters.AddWithValue("No_Masuk_Barang", txtNoMasuk.Text);
            //cmd.Parameters.AddWithValue("@Keadaan", txtKondisiBrgMsk.Text);
            DateTime TglMsk = DateTime.Parse(txtTglMsk.Text);
            cmd.Parameters.AddWithValue("@Tanggal_Masuk", TglMsk);
            cmd.Parameters.AddWithValue("@Harga_Satuan", decimal.Parse(txtHrgStnMsk.Text));
            cmd.Parameters.AddWithValue("@Kuantitas", int.Parse(txtKuantitasMsk.Text));
            cmd.Parameters.AddWithValue("@Harga_total", decimal.Parse(txtTotalHrgMsk.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil Disimpan");
        }

        private void txtTglMsk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateBrg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Barang_Masuk set Kode_Barang=@Kode_Barang, Nama_Barang=@Nama_Barang, " +
                "Tanggal_Masuk=@Tanggal_Masuk, Harga_Satuan=@Harga_Satuan, Kuantitas=@Kuantitas, Harga_total=@Harga_total " +
                "where No_Masuk_Barang=@No_Masuk_Barang", con);
            cmd.Parameters.AddWithValue("@Kode_Barang", txtKodeBrgMsk.Text);
            cmd.Parameters.AddWithValue("@Nama_Barang", txtNamaBrgMsk.Text);
            cmd.Parameters.AddWithValue("No_Masuk_Barang", txtNoMasuk.Text);
            //cmd.Parameters.AddWithValue("@Keadaan", txtKondisiBrgMsk.Text);
            DateTime TglMsk = DateTime.Parse(txtTglMsk.Text);
            cmd.Parameters.AddWithValue("@Tanggal_Masuk", TglMsk);
            cmd.Parameters.AddWithValue("@Harga_Satuan", decimal.Parse(txtHrgStnMsk.Text));
            cmd.Parameters.AddWithValue("@Kuantitas", int.Parse(txtKuantitasMsk.Text));
            cmd.Parameters.AddWithValue("@Harga_total", decimal.Parse(txtTotalHrgMsk.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil Diubah");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Barang_Masuk Where No_Masuk_Barang=@No_Masuk_Barang", con);
            cmd.Parameters.AddWithValue("@No_Masuk_Barang", txtKodeBrgMsk.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Dihapus");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNoMasuk.Clear();
            txtKodeBrgMsk.Clear();
            txtNamaBrgMsk.Clear();
            txtKuantitasMsk.Clear();
            txtHrgStnMsk.Clear();
            txtTotalHrgMsk.Clear();
            txtTglMsk.Clear();
            txtKodeBrgMsk.Focus();
        }
    }
}
