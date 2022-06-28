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
    public partial class Form3 : Form
    {
        //DataTable dt;
        //DataRow dr;
        //String code;
        public Form3()
        {
            InitializeComponent();
            txtKodeBrg.Text = txtKodeBrg.Text;
            txtNamaBrg.Text = txtNamaBrg.Text;
            txtIdPengurusBrg.Text = txtIdPengurusBrg.Text;
            txtKeadaanBrg.Text = txtKeadaanBrg.Text;
            txtKeterangan.Text = txtKeterangan.Text;
            txtHargaStn.Text = txtHargaStn.Text;
            txtKuantitasBrg.Text = txtKuantitasBrg.Text;
            txtTotalHrg.Text = txtTotalHrg.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invetarisDataSet3.Barang' table. You can move, or remove it, as needed.
            //this.barangTableAdapter1.Fill(this.invetarisDataSet3.Barang);
            // TODO: This line of code loads data into the 'invetarisDataSet1.Barang' table. You can move, or remove it, as needed.
            //this.barangTableAdapter.Fill(this.invetarisDataSet.Barang);
            //this.barangTableAdapter.Fill(this.invetarisDataSet1.Barang);
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveBrg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Barang values (@Kode_Barang, @Nama_Barang, @Id_Pengurus_Barang, @Keadaan, " +
                "@Keterangan, @Harga_Satuan, @Kuantitas, @Harga_Total)", con);
            cmd.Parameters.AddWithValue("@Kode_Barang", txtKodeBrg.Text);
            cmd.Parameters.AddWithValue("@Nama_Barang", txtNamaBrg.Text);
            cmd.Parameters.AddWithValue("@Id_Pengurus_Barang", int.Parse(txtIdPengurusBrg.Text));
            cmd.Parameters.AddWithValue("@Keadaan", txtKeadaanBrg.Text);
            cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text);
            cmd.Parameters.AddWithValue("@Harga_Satuan", decimal.Parse(txtHargaStn.Text));
            cmd.Parameters.AddWithValue("@Kuantitas", int.Parse(txtKuantitasBrg.Text));
            cmd.Parameters.AddWithValue("@Harga_Total", decimal.Parse(txtTotalHrg.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil Disimpan");

            /*
            btnSaveBrg.Enabled = true;
            btnCancelBrg.Enabled = true;
            txtKodeBrg.Enabled = true;
            txtNamaBrg.Enabled = true;
            txtIdPengurusBrg.Enabled = true;
            txtKeadaanBrg.Enabled = true;
            txtKeterangan.Enabled = true;
            txtHargaStn.Enabled = true;
            txtKuantitasBrg.Enabled = true;
            txtTotalHrg.Enabled = true;

            txtKodeBrg.Text = "";
            txtNamaBrg.Text = "";
            txtIdPengurusBrg.Text = "";
            txtKeadaanBrg.Text = "";
            txtKeterangan.Text = "";
            txtHargaStn.Text = "";
            txtKuantitasBrg.Text = "";
            txtTotalHrg.Text = "";

            //String HargaStn = txtHargaStn.ToDecimal();
            //System.Convert.ToDecimal(txtHargaStn);
            decimal HargaStn;
            decimal TotalHrg;
            decimal.TryParse(txtHargaStn.Text, out HargaStn);
            decimal.TryParse(txtHargaStn.Text, out TotalHrg);


            dt = invetarisDataSet1.Tables["Barang"];
            dr = dt.NewRow();
            dr[0] = txtKodeBrg.Text;
            dr[1] = txtNamaBrg.Text;
            dr[2] = txtIdPengurusBrg.Text;
            dr[3] = txtKeadaanBrg.Text;
            dr[4] = txtKeterangan.Text;
            //dr[5] = System.Convert.ToInt32(txtHargaStn);
            dr[5] = HargaStn;
            dr[6] = txtKuantitasBrg.Text;
            dr[7] = TotalHrg;
            dt.Rows.Add(dr);
            barangTableAdapter.Update(invetarisDataSet1);
            txtKodeBrg.Text = System.Convert.ToString(dr[0]);
            txtKodeBrg.Enabled = false;
            txtNamaBrg.Enabled = false;
            txtIdPengurusBrg.Text = System.Convert.ToString(dr[2]);
            txtKeadaanBrg.Enabled = false;
            txtKeterangan.Enabled = false;
            txtHargaStn.Enabled = false;
            txtKuantitasBrg.Enabled = false;
            txtTotalHrg.Enabled = false;
            //txtHargaStn.Text = System.Convert.ToString(dr[5]);
            //txtKuantitasBrg.Text = System.Convert.ToString(dr[6]);
            //txtTotalHrg.Text = System.Convert.ToString(dr[7]);
            this.barangTableAdapter.Fill(this.invetarisDataSet1.Barang);
            
            btnSaveBrg.Enabled = false; 
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteBrg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Barang Where Kode_Barang=@Kode_Barang", con);
            cmd.Parameters.AddWithValue("@Kode_Barang", txtKodeBrg.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Dihapus");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Barang set Nama_Barang=@Nama_Barang, " +
                "Id_Pengurus_Barang=@Id_Pengurus_Barang, Keadaan=@Keadaan, " +
                "Keterangan=@Keterangan, Harga_Satuan=@Harga_Satuan, Kuantitas=@Kuantitas, Harga_Total=@Harga_Total " +
                "Where Kode_Barang=@Kode_Barang", con);
            cmd.Parameters.AddWithValue("@Kode_Barang", txtKodeBrg.Text);
            cmd.Parameters.AddWithValue("@Nama_Barang", txtNamaBrg.Text);
            cmd.Parameters.AddWithValue("@Id_Pengurus_Barang", int.Parse(txtIdPengurusBrg.Text));
            cmd.Parameters.AddWithValue("@Keadaan", txtKeadaanBrg.Text);
            cmd.Parameters.AddWithValue("@Keterangan", txtKeterangan.Text);
            cmd.Parameters.AddWithValue("@Harga_Satuan", decimal.Parse(txtHargaStn.Text));
            cmd.Parameters.AddWithValue("@Kuantitas", int.Parse(txtKuantitasBrg.Text));
            cmd.Parameters.AddWithValue("@Harga_Total", decimal.Parse(txtTotalHrg.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Data Berhasil Diupdate");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = DESKTOP-KVHUS77\\RIDWANAM; database=invetaris; User ID=sa; Password=riamima");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * From Barang", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnCancelBrg_Click(object sender, EventArgs e)
        {
            txtKodeBrg.Clear();
            txtNamaBrg.Clear();
            txtIdPengurusBrg.Clear();
            txtKeadaanBrg.Clear();
            txtKeterangan.Clear();
            txtHargaStn.Clear();
            txtKuantitasBrg.Clear();
            txtTotalHrg.Clear();
            txtKodeBrg.Focus();
        }
    }
}
