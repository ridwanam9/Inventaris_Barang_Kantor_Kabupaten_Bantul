
namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtKuantitasMsk = new System.Windows.Forms.TextBox();
            this.txtTglMsk = new System.Windows.Forms.TextBox();
            this.txtNamaBrgMsk = new System.Windows.Forms.TextBox();
            this.txtTotalHrgMsk = new System.Windows.Forms.TextBox();
            this.txtHrgStnMsk = new System.Windows.Forms.TextBox();
            this.txtKodeBrgMsk = new System.Windows.Forms.TextBox();
            this.txtNoMasuk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSaveMsk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noMasukBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargatotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangMasukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invetarisDataSet = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSet();
            this.barang_MasukTableAdapter = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSetTableAdapters.Barang_MasukTableAdapter();
            this.btnUpdateBrg = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangMasukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barang Masuk";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.logobantul;
            this.pictureBox1.Location = new System.Drawing.Point(31, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Location = new System.Drawing.Point(690, 22);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(795, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtKuantitasMsk
            // 
            this.txtKuantitasMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Kuantitas", true));
            this.txtKuantitasMsk.Location = new System.Drawing.Point(693, 96);
            this.txtKuantitasMsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKuantitasMsk.Multiline = true;
            this.txtKuantitasMsk.Name = "txtKuantitasMsk";
            this.txtKuantitasMsk.Size = new System.Drawing.Size(117, 35);
            this.txtKuantitasMsk.TabIndex = 19;
            this.txtKuantitasMsk.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTglMsk
            // 
            this.txtTglMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Tanggal_Masuk", true));
            this.txtTglMsk.Location = new System.Drawing.Point(501, 160);
            this.txtTglMsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTglMsk.Multiline = true;
            this.txtTglMsk.Name = "txtTglMsk";
            this.txtTglMsk.Size = new System.Drawing.Size(117, 35);
            this.txtTglMsk.TabIndex = 20;
            this.txtTglMsk.TextChanged += new System.EventHandler(this.txtTglMsk_TextChanged);
            // 
            // txtNamaBrgMsk
            // 
            this.txtNamaBrgMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Nama_Barang", true));
            this.txtNamaBrgMsk.Location = new System.Drawing.Point(501, 96);
            this.txtNamaBrgMsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNamaBrgMsk.Multiline = true;
            this.txtNamaBrgMsk.Name = "txtNamaBrgMsk";
            this.txtNamaBrgMsk.Size = new System.Drawing.Size(117, 35);
            this.txtNamaBrgMsk.TabIndex = 21;
            // 
            // txtTotalHrgMsk
            // 
            this.txtTotalHrgMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Harga_total", true));
            this.txtTotalHrgMsk.Location = new System.Drawing.Point(316, 160);
            this.txtTotalHrgMsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalHrgMsk.Multiline = true;
            this.txtTotalHrgMsk.Name = "txtTotalHrgMsk";
            this.txtTotalHrgMsk.Size = new System.Drawing.Size(117, 35);
            this.txtTotalHrgMsk.TabIndex = 22;
            // 
            // txtHrgStnMsk
            // 
            this.txtHrgStnMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Harga_Satuan", true));
            this.txtHrgStnMsk.Location = new System.Drawing.Point(154, 160);
            this.txtHrgStnMsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHrgStnMsk.Multiline = true;
            this.txtHrgStnMsk.Name = "txtHrgStnMsk";
            this.txtHrgStnMsk.Size = new System.Drawing.Size(117, 35);
            this.txtHrgStnMsk.TabIndex = 23;
            // 
            // txtKodeBrgMsk
            // 
            this.txtKodeBrgMsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "Kode_Barang", true));
            this.txtKodeBrgMsk.Location = new System.Drawing.Point(316, 96);
            this.txtKodeBrgMsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKodeBrgMsk.Multiline = true;
            this.txtKodeBrgMsk.Name = "txtKodeBrgMsk";
            this.txtKodeBrgMsk.Size = new System.Drawing.Size(117, 35);
            this.txtKodeBrgMsk.TabIndex = 24;
            // 
            // txtNoMasuk
            // 
            this.txtNoMasuk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangMasukBindingSource, "No_Masuk_Barang", true));
            this.txtNoMasuk.Location = new System.Drawing.Point(154, 96);
            this.txtNoMasuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoMasuk.Multiline = true;
            this.txtNoMasuk.Name = "txtNoMasuk";
            this.txtNoMasuk.Size = new System.Drawing.Size(117, 35);
            this.txtNoMasuk.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(706, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kuantitas Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nama Barang";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kode Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tanggal Masuk";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Harga ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 136);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Harga Satuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "No.Masuk Barang";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Location = new System.Drawing.Point(556, 224);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSaveMsk
            // 
            this.btnSaveMsk.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveMsk.Location = new System.Drawing.Point(180, 224);
            this.btnSaveMsk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveMsk.Name = "btnSaveMsk";
            this.btnSaveMsk.Size = new System.Drawing.Size(91, 35);
            this.btnSaveMsk.TabIndex = 27;
            this.btnSaveMsk.Text = "Save";
            this.btnSaveMsk.UseVisualStyleBackColor = false;
            this.btnSaveMsk.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(425, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noMasukBarangDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.tanggalMasukDataGridViewTextBoxColumn,
            this.hargaSatuanDataGridViewTextBoxColumn,
            this.kuantitasDataGridViewTextBoxColumn,
            this.hargatotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangMasukBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(99, 312);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 102);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // noMasukBarangDataGridViewTextBoxColumn
            // 
            this.noMasukBarangDataGridViewTextBoxColumn.DataPropertyName = "No_Masuk_Barang";
            this.noMasukBarangDataGridViewTextBoxColumn.HeaderText = "No_Masuk_Barang";
            this.noMasukBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noMasukBarangDataGridViewTextBoxColumn.Name = "noMasukBarangDataGridViewTextBoxColumn";
            this.noMasukBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            this.kodeBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "Nama_Barang";
            this.namaBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            this.namaBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalMasukDataGridViewTextBoxColumn
            // 
            this.tanggalMasukDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.HeaderText = "Tanggal_Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalMasukDataGridViewTextBoxColumn.Name = "tanggalMasukDataGridViewTextBoxColumn";
            this.tanggalMasukDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaSatuanDataGridViewTextBoxColumn
            // 
            this.hargaSatuanDataGridViewTextBoxColumn.DataPropertyName = "Harga_Satuan";
            this.hargaSatuanDataGridViewTextBoxColumn.HeaderText = "Harga_Satuan";
            this.hargaSatuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaSatuanDataGridViewTextBoxColumn.Name = "hargaSatuanDataGridViewTextBoxColumn";
            this.hargaSatuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // kuantitasDataGridViewTextBoxColumn
            // 
            this.kuantitasDataGridViewTextBoxColumn.DataPropertyName = "Kuantitas";
            this.kuantitasDataGridViewTextBoxColumn.HeaderText = "Kuantitas";
            this.kuantitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kuantitasDataGridViewTextBoxColumn.Name = "kuantitasDataGridViewTextBoxColumn";
            this.kuantitasDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargatotalDataGridViewTextBoxColumn
            // 
            this.hargatotalDataGridViewTextBoxColumn.DataPropertyName = "Harga_total";
            this.hargatotalDataGridViewTextBoxColumn.HeaderText = "Harga_total";
            this.hargatotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargatotalDataGridViewTextBoxColumn.Name = "hargatotalDataGridViewTextBoxColumn";
            this.hargatotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // barangMasukBindingSource
            // 
            this.barangMasukBindingSource.DataMember = "Barang_Masuk";
            this.barangMasukBindingSource.DataSource = this.invetarisDataSet;
            // 
            // invetarisDataSet
            // 
            this.invetarisDataSet.DataSetName = "InvetarisDataSet";
            this.invetarisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barang_MasukTableAdapter
            // 
            this.barang_MasukTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateBrg
            // 
            this.btnUpdateBrg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateBrg.Location = new System.Drawing.Point(304, 224);
            this.btnUpdateBrg.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBrg.Name = "btnUpdateBrg";
            this.btnUpdateBrg.Size = new System.Drawing.Size(91, 35);
            this.btnUpdateBrg.TabIndex = 30;
            this.btnUpdateBrg.Text = "Update";
            this.btnUpdateBrg.UseVisualStyleBackColor = false;
            this.btnUpdateBrg.Click += new System.EventHandler(this.btnUpdateBrg_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.Location = new System.Drawing.Point(693, 224);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 35);
            this.button5.TabIndex = 31;
            this.button5.Text = "Display";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(876, 492);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnUpdateBrg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSaveMsk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKuantitasMsk);
            this.Controls.Add(this.txtTglMsk);
            this.Controls.Add(this.txtNamaBrgMsk);
            this.Controls.Add(this.txtTotalHrgMsk);
            this.Controls.Add(this.txtHrgStnMsk);
            this.Controls.Add(this.txtKodeBrgMsk);
            this.Controls.Add(this.txtNoMasuk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Halaman Barang Masuk";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangMasukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtKuantitasMsk;
        private System.Windows.Forms.TextBox txtTglMsk;
        private System.Windows.Forms.TextBox txtNamaBrgMsk;
        private System.Windows.Forms.TextBox txtTotalHrgMsk;
        private System.Windows.Forms.TextBox txtHrgStnMsk;
        private System.Windows.Forms.TextBox txtKodeBrgMsk;
        private System.Windows.Forms.TextBox txtNoMasuk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSaveMsk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InvetarisDataSet invetarisDataSet;
        private System.Windows.Forms.BindingSource barangMasukBindingSource;
        private InvetarisDataSetTableAdapters.Barang_MasukTableAdapter barang_MasukTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noMasukBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargatotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateBrg;
        private System.Windows.Forms.Button button5;
    }
}