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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invetarisDataSet2.Barang_Keluar' table. You can move, or remove it, as needed.
            //this.barang_KeluarTableAdapter.Fill(this.invetarisDataSet2.Barang_Keluar);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Barang_Keluar", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveKlr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Barang_Keluar values (@No_Keluar_Barang, @Kode_Barang, @Nama_Barang, " +
                "@Tanggal_Keluar, @Harga_Satuan, @Kuantitas, @Harga_total)", con);
            cmd.Parameters.AddWithValue("@Kode_Barang", txtKodeBrg.Text);
            cmd.Parameters.AddWithValue("@Nama_Barang", txtNamaBrgKlr.Text);
            cmd.Parameters.AddWithValue("No_Keluar_Barang", txtNoBrgKlr.Text);
            //cmd.Parameters.AddWithValue("@Keadaan", txtKondisiBrgMsk.Text);
            DateTime TglKlr = DateTime.Parse(txtTglKlr.Text);
            cmd.Parameters.AddWithValue("@Tanggal_Keluar", TglKlr);
            cmd.Parameters.AddWithValue("@Harga_Satuan", decimal.Parse(txtHrgStnKlr.Text));
            cmd.Parameters.AddWithValue("@Kuantitas", int.Parse(txtKuantitasKlr.Text));
            cmd.Parameters.AddWithValue("@Harga_total", decimal.Parse(txtHrgTotal.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil Disimpan");
        }

        private void btnUpdateBrgKlr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Barang_Keluar set Kode_Barang=@Kode_Barang, Nama_Barang=@Nama_Barang, " +
                "Tanggal_Keluar=@Tanggal_Keluar, Harga_Satuan=@Harga_Satuan, Kuantitas=@Kuantitas, Harga_total=@Harga_total " +
                "where No_Keluar_Barang=@No_Keluar_Barang", con);
            cmd.Parameters.AddWithValue("@Kode_Barang", txtKodeBrg.Text);
            cmd.Parameters.AddWithValue("@Nama_Barang", txtNamaBrgKlr.Text);
            cmd.Parameters.AddWithValue("No_Keluar_Barang", txtNoBrgKlr.Text);
            //cmd.Parameters.AddWithValue("@Keadaan", txtKondisiBrgMsk.Text);
            DateTime TglKlr = DateTime.Parse(txtTglKlr.Text);
            cmd.Parameters.AddWithValue("@Tanggal_Keluar", TglKlr);
            cmd.Parameters.AddWithValue("@Harga_Satuan", decimal.Parse(txtHrgStnKlr.Text));
            cmd.Parameters.AddWithValue("@Kuantitas", int.Parse(txtKuantitasKlr.Text));
            cmd.Parameters.AddWithValue("@Harga_total", decimal.Parse(txtHrgTotal.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil Diubah");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteKlr_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Barang_Keluar Where No_Keluar_Barang=@No_Keluar_Barang", con);
            cmd.Parameters.AddWithValue("@No_Keluar_Barang", txtNoBrgKlr.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Dihapus");
        }

        private void btnCancelKlr_Click(object sender, EventArgs e)
        {
            txtNoBrgKlr.Clear();
            txtKodeBrg.Clear();
            txtNamaBrgKlr.Clear();
            txtKuantitasKlr.Clear();
            txtHrgStnKlr.Clear();
            txtHrgTotal.Clear();
            txtTglKlr.Clear();
            txtNoBrgKlr.Focus();
        }
    }
}
