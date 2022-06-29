
namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKodeBrg = new System.Windows.Forms.TextBox();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invetarisDataSet1 = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSet1();
            this.barangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invetarisDataSet3 = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSet3();
            this.txtNamaBrg = new System.Windows.Forms.TextBox();
            this.txtIdPengurusBrg = new System.Windows.Forms.TextBox();
            this.txtKeadaanBrg = new System.Windows.Forms.TextBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.txtTotalHrg = new System.Windows.Forms.TextBox();
            this.txtHargaStn = new System.Windows.Forms.TextBox();
            this.txtKuantitasBrg = new System.Windows.Forms.TextBox();
            this.btnDeleteBrg = new System.Windows.Forms.Button();
            this.btnSaveBrg = new System.Windows.Forms.Button();
            this.btnCancelBrg = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPengurusBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keadaanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargatotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.barangTableAdapter = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSet1TableAdapters.BarangTableAdapter();
            this.barangTableAdapter1 = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSet3TableAdapters.BarangTableAdapter();
            this.btnUpdateBrg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.logobantul;
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id.Pengurus Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kode Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nama Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kuantitas Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Harga Satuan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(717, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Harga ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(706, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Keadaan Barang";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Keterangan";
            // 
            // txtKodeBrg
            // 
            this.txtKodeBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Kode_Barang", true));
            this.txtKodeBrg.Location = new System.Drawing.Point(148, 95);
            this.txtKodeBrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeBrg.Multiline = true;
            this.txtKodeBrg.Name = "txtKodeBrg";
            this.txtKodeBrg.Size = new System.Drawing.Size(117, 35);
            this.txtKodeBrg.TabIndex = 4;
            this.txtKodeBrg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.invetarisDataSet1;
            // 
            // invetarisDataSet1
            // 
            this.invetarisDataSet1.DataSetName = "InvetarisDataSet1";
            this.invetarisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangBindingSource2
            // 
            this.barangBindingSource2.DataMember = "Barang";
            this.barangBindingSource2.DataSource = this.invetarisDataSet3;
            // 
            // invetarisDataSet3
            // 
            this.invetarisDataSet3.DataSetName = "InvetarisDataSet3";
            this.invetarisDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNamaBrg
            // 
            this.txtNamaBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Nama_Barang", true));
            this.txtNamaBrg.Location = new System.Drawing.Point(311, 95);
            this.txtNamaBrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaBrg.Multiline = true;
            this.txtNamaBrg.Name = "txtNamaBrg";
            this.txtNamaBrg.Size = new System.Drawing.Size(117, 35);
            this.txtNamaBrg.TabIndex = 4;
            this.txtNamaBrg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIdPengurusBrg
            // 
            this.txtIdPengurusBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Id_Pengurus_Barang", true));
            this.txtIdPengurusBrg.Location = new System.Drawing.Point(495, 95);
            this.txtIdPengurusBrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPengurusBrg.Multiline = true;
            this.txtIdPengurusBrg.Name = "txtIdPengurusBrg";
            this.txtIdPengurusBrg.Size = new System.Drawing.Size(117, 35);
            this.txtIdPengurusBrg.TabIndex = 4;
            this.txtIdPengurusBrg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKeadaanBrg
            // 
            this.txtKeadaanBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Keadaan", true));
            this.txtKeadaanBrg.Location = new System.Drawing.Point(688, 95);
            this.txtKeadaanBrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeadaanBrg.Multiline = true;
            this.txtKeadaanBrg.Name = "txtKeadaanBrg";
            this.txtKeadaanBrg.Size = new System.Drawing.Size(117, 35);
            this.txtKeadaanBrg.TabIndex = 4;
            this.txtKeadaanBrg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Keterangan", true));
            this.txtKeterangan.Location = new System.Drawing.Point(148, 162);
            this.txtKeterangan.Margin = new System.Windows.Forms.Padding(2);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(117, 35);
            this.txtKeterangan.TabIndex = 4;
            this.txtKeterangan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTotalHrg
            // 
            this.txtTotalHrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Harga_total", true));
            this.txtTotalHrg.Location = new System.Drawing.Point(688, 162);
            this.txtTotalHrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalHrg.Multiline = true;
            this.txtTotalHrg.Name = "txtTotalHrg";
            this.txtTotalHrg.Size = new System.Drawing.Size(117, 35);
            this.txtTotalHrg.TabIndex = 4;
            this.txtTotalHrg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHargaStn
            // 
            this.txtHargaStn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Harga_Satuan", true));
            this.txtHargaStn.Location = new System.Drawing.Point(311, 162);
            this.txtHargaStn.Margin = new System.Windows.Forms.Padding(2);
            this.txtHargaStn.Multiline = true;
            this.txtHargaStn.Name = "txtHargaStn";
            this.txtHargaStn.Size = new System.Drawing.Size(117, 35);
            this.txtHargaStn.TabIndex = 4;
            this.txtHargaStn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtKuantitasBrg
            // 
            this.txtKuantitasBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Kuantitas", true));
            this.txtKuantitasBrg.Location = new System.Drawing.Point(495, 162);
            this.txtKuantitasBrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtKuantitasBrg.Multiline = true;
            this.txtKuantitasBrg.Name = "txtKuantitasBrg";
            this.txtKuantitasBrg.Size = new System.Drawing.Size(117, 35);
            this.txtKuantitasBrg.TabIndex = 4;
            this.txtKuantitasBrg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDeleteBrg
            // 
            this.btnDeleteBrg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteBrg.Location = new System.Drawing.Point(446, 211);
            this.btnDeleteBrg.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteBrg.Name = "btnDeleteBrg";
            this.btnDeleteBrg.Size = new System.Drawing.Size(91, 35);
            this.btnDeleteBrg.TabIndex = 5;
            this.btnDeleteBrg.Text = "Delete";
            this.btnDeleteBrg.UseVisualStyleBackColor = false;
            this.btnDeleteBrg.Click += new System.EventHandler(this.btnDeleteBrg_Click);
            // 
            // btnSaveBrg
            // 
            this.btnSaveBrg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveBrg.Location = new System.Drawing.Point(180, 211);
            this.btnSaveBrg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveBrg.Name = "btnSaveBrg";
            this.btnSaveBrg.Size = new System.Drawing.Size(91, 35);
            this.btnSaveBrg.TabIndex = 5;
            this.btnSaveBrg.Text = "Save";
            this.btnSaveBrg.UseVisualStyleBackColor = false;
            this.btnSaveBrg.Click += new System.EventHandler(this.btnSaveBrg_Click);
            // 
            // btnCancelBrg
            // 
            this.btnCancelBrg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCancelBrg.Location = new System.Drawing.Point(692, 211);
            this.btnCancelBrg.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelBrg.Name = "btnCancelBrg";
            this.btnCancelBrg.Size = new System.Drawing.Size(91, 35);
            this.btnCancelBrg.TabIndex = 5;
            this.btnCancelBrg.Text = "Cancel";
            this.btnCancelBrg.UseVisualStyleBackColor = false;
            this.btnCancelBrg.Click += new System.EventHandler(this.btnCancelBrg_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.home;
            this.pictureBox2.Location = new System.Drawing.Point(827, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Location = new System.Drawing.Point(729, 18);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.idPengurusBarangDataGridViewTextBoxColumn,
            this.keadaanDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.hargaSatuanDataGridViewTextBoxColumn,
            this.kuantitasDataGridViewTextBoxColumn,
            this.hargatotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(52, 277);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 175);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // idPengurusBarangDataGridViewTextBoxColumn
            // 
            this.idPengurusBarangDataGridViewTextBoxColumn.DataPropertyName = "Id_Pengurus_Barang";
            this.idPengurusBarangDataGridViewTextBoxColumn.HeaderText = "Id_Pengurus_Barang";
            this.idPengurusBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPengurusBarangDataGridViewTextBoxColumn.Name = "idPengurusBarangDataGridViewTextBoxColumn";
            this.idPengurusBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // keadaanDataGridViewTextBoxColumn
            // 
            this.keadaanDataGridViewTextBoxColumn.DataPropertyName = "Keadaan";
            this.keadaanDataGridViewTextBoxColumn.HeaderText = "Keadaan";
            this.keadaanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keadaanDataGridViewTextBoxColumn.Name = "keadaanDataGridViewTextBoxColumn";
            this.keadaanDataGridViewTextBoxColumn.Width = 125;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 125;
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
            // barangBindingSource1
            // 
            this.barangBindingSource1.DataMember = "Barang";
            this.barangBindingSource1.DataSource = this.invetarisDataSet3;
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // barangTableAdapter1
            // 
            this.barangTableAdapter1.ClearBeforeFill = true;
            // 
            // btnUpdateBrg
            // 
            this.btnUpdateBrg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateBrg.Location = new System.Drawing.Point(319, 211);
            this.btnUpdateBrg.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBrg.Name = "btnUpdateBrg";
            this.btnUpdateBrg.Size = new System.Drawing.Size(91, 35);
            this.btnUpdateBrg.TabIndex = 9;
            this.btnUpdateBrg.Text = "Update";
            this.btnUpdateBrg.UseVisualStyleBackColor = false;
            this.btnUpdateBrg.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Location = new System.Drawing.Point(570, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(888, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateBrg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCancelBrg);
            this.Controls.Add(this.btnSaveBrg);
            this.Controls.Add(this.btnDeleteBrg);
            this.Controls.Add(this.txtTotalHrg);
            this.Controls.Add(this.txtKeadaanBrg);
            this.Controls.Add(this.txtIdPengurusBrg);
            this.Controls.Add(this.txtKuantitasBrg);
            this.Controls.Add(this.txtHargaStn);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.txtNamaBrg);
            this.Controls.Add(this.txtKodeBrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Hamanan Data Barang";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKodeBrg;
        private System.Windows.Forms.TextBox txtNamaBrg;
        private System.Windows.Forms.TextBox txtIdPengurusBrg;
        private System.Windows.Forms.TextBox txtKeadaanBrg;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.TextBox txtTotalHrg;
        private System.Windows.Forms.TextBox txtHargaStn;
        private System.Windows.Forms.TextBox txtKuantitasBrg;
        private System.Windows.Forms.Button btnDeleteBrg;
        private System.Windows.Forms.Button btnSaveBrg;
        private System.Windows.Forms.Button btnCancelBrg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InvetarisDataSet1 invetarisDataSet1;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private InvetarisDataSet1TableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPengurusBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keadaanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargatotalDataGridViewTextBoxColumn;
        private InvetarisDataSet3 invetarisDataSet3;
        private System.Windows.Forms.BindingSource barangBindingSource1;
        private InvetarisDataSet3TableAdapters.BarangTableAdapter barangTableAdapter1;
        private System.Windows.Forms.BindingSource barangBindingSource2;
        private System.Windows.Forms.Button btnUpdateBrg;
        private System.Windows.Forms.Button button1;
    }
}