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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
