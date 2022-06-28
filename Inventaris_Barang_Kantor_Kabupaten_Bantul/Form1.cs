using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    public partial class Form1 : Form
    {
        readonly string Username = "Bantul";
        readonly string Password = "123";
        public Form1()
        {
            InitializeComponent();          
           
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Username && txtPassword.Text == Password)
            {
                new Form2().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "") 
            {
                MessageBox.Show("Mohon isi Nama dan Password terlebih dahulu");
            }
            else 
            {
                MessageBox.Show("Nama atau Password yang anda masukkan salah");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
