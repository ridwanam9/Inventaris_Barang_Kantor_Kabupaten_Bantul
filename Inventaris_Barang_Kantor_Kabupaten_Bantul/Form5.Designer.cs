
namespace Inventaris_Barang_Kantor_Kabupaten_Bantul
{
    partial class Form5
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
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKuantitasKlr = new System.Windows.Forms.TextBox();
            this.txtNamaBrgKlr = new System.Windows.Forms.TextBox();
            this.txtTglKlr = new System.Windows.Forms.TextBox();
            this.txtHrgTotal = new System.Windows.Forms.TextBox();
            this.txtHrgStnKlr = new System.Windows.Forms.TextBox();
            this.txtKodeBrg = new System.Windows.Forms.TextBox();
            this.txtNoBrgKlr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelKlr = new System.Windows.Forms.Button();
            this.btnSaveKlr = new System.Windows.Forms.Button();
            this.btnDeleteKlr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noKeluarBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalKeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuantitasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargatotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangKeluarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invetarisDataSet2 = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSet2();
            this.barang_KeluarTableAdapter = new Inventaris_Barang_Kantor_Kabupaten_Bantul.InvetarisDataSet2TableAdapters.Barang_KeluarTableAdapter();
            this.btnUpdateBrgKlr = new System.Windows.Forms.Button();
            this.btnDisplayKlr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangKeluarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Location = new System.Drawing.Point(740, 26);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
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
            this.pictureBox2.Location = new System.Drawing.Point(848, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventaris_Barang_Kantor_Kabupaten_Bantul.Properties.Resources.logobantul;
            this.pictureBox1.Location = new System.Drawing.Point(28, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Barang Keluar";
            // 
            // txtKuantitasKlr
            // 
            this.txtKuantitasKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Kuantitas", true));
            this.txtKuantitasKlr.Location = new System.Drawing.Point(691, 102);
            this.txtKuantitasKlr.Margin = new System.Windows.Forms.Padding(2);
            this.txtKuantitasKlr.Multiline = true;
            this.txtKuantitasKlr.Name = "txtKuantitasKlr";
            this.txtKuantitasKlr.Size = new System.Drawing.Size(117, 35);
            this.txtKuantitasKlr.TabIndex = 35;
            // 
            // txtNamaBrgKlr
            // 
            this.txtNamaBrgKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Nama_Barang", true));
            this.txtNamaBrgKlr.Location = new System.Drawing.Point(498, 102);
            this.txtNamaBrgKlr.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaBrgKlr.Multiline = true;
            this.txtNamaBrgKlr.Name = "txtNamaBrgKlr";
            this.txtNamaBrgKlr.Size = new System.Drawing.Size(117, 35);
            this.txtNamaBrgKlr.TabIndex = 36;
            // 
            // txtTglKlr
            // 
            this.txtTglKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Tanggal_Keluar", true));
            this.txtTglKlr.Location = new System.Drawing.Point(498, 158);
            this.txtTglKlr.Margin = new System.Windows.Forms.Padding(2);
            this.txtTglKlr.Multiline = true;
            this.txtTglKlr.Name = "txtTglKlr";
            this.txtTglKlr.Size = new System.Drawing.Size(117, 35);
            this.txtTglKlr.TabIndex = 37;
            // 
            // txtHrgTotal
            // 
            this.txtHrgTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Harga_total", true));
            this.txtHrgTotal.Location = new System.Drawing.Point(314, 158);
            this.txtHrgTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtHrgTotal.Multiline = true;
            this.txtHrgTotal.Name = "txtHrgTotal";
            this.txtHrgTotal.Size = new System.Drawing.Size(117, 35);
            this.txtHrgTotal.TabIndex = 38;
            // 
            // txtHrgStnKlr
            // 
            this.txtHrgStnKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Harga_Satuan", true));
            this.txtHrgStnKlr.Location = new System.Drawing.Point(152, 158);
            this.txtHrgStnKlr.Margin = new System.Windows.Forms.Padding(2);
            this.txtHrgStnKlr.Multiline = true;
            this.txtHrgStnKlr.Name = "txtHrgStnKlr";
            this.txtHrgStnKlr.Size = new System.Drawing.Size(117, 35);
            this.txtHrgStnKlr.TabIndex = 39;
            // 
            // txtKodeBrg
            // 
            this.txtKodeBrg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "Kode_Barang", true));
            this.txtKodeBrg.Location = new System.Drawing.Point(314, 102);
            this.txtKodeBrg.Margin = new System.Windows.Forms.Padding(2);
            this.txtKodeBrg.Multiline = true;
            this.txtKodeBrg.Name = "txtKodeBrg";
            this.txtKodeBrg.Size = new System.Drawing.Size(117, 35);
            this.txtKodeBrg.TabIndex = 40;
            // 
            // txtNoBrgKlr
            // 
            this.txtNoBrgKlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangKeluarBindingSource, "No_Keluar_Barang", true));
            this.txtNoBrgKlr.Location = new System.Drawing.Point(152, 102);
            this.txtNoBrgKlr.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoBrgKlr.Multiline = true;
            this.txtNoBrgKlr.Name = "txtNoBrgKlr";
            this.txtNoBrgKlr.Size = new System.Drawing.Size(117, 35);
            this.txtNoBrgKlr.TabIndex = 41;
            this.txtNoBrgKlr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kuantitas Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Kode Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tanggal Keluar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(340, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total Harga ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Harga Satuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "No.Keluar Barang";
            // 
            // btnCancelKlr
            // 
            this.btnCancelKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCancelKlr.Location = new System.Drawing.Point(565, 215);
            this.btnCancelKlr.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelKlr.Name = "btnCancelKlr";
            this.btnCancelKlr.Size = new System.Drawing.Size(91, 35);
            this.btnCancelKlr.TabIndex = 42;
            this.btnCancelKlr.Text = "Cancel";
            this.btnCancelKlr.UseVisualStyleBackColor = false;
            this.btnCancelKlr.Click += new System.EventHandler(this.btnCancelKlr_Click);
            // 
            // btnSaveKlr
            // 
            this.btnSaveKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSaveKlr.Location = new System.Drawing.Point(178, 215);
            this.btnSaveKlr.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveKlr.Name = "btnSaveKlr";
            this.btnSaveKlr.Size = new System.Drawing.Size(91, 35);
            this.btnSaveKlr.TabIndex = 43;
            this.btnSaveKlr.Text = "Save";
            this.btnSaveKlr.UseVisualStyleBackColor = false;
            this.btnSaveKlr.Click += new System.EventHandler(this.btnSaveKlr_Click);
            // 
            // btnDeleteKlr
            // 
            this.btnDeleteKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteKlr.Location = new System.Drawing.Point(434, 215);
            this.btnDeleteKlr.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteKlr.Name = "btnDeleteKlr";
            this.btnDeleteKlr.Size = new System.Drawing.Size(91, 35);
            this.btnDeleteKlr.TabIndex = 44;
            this.btnDeleteKlr.Text = "Delete";
            this.btnDeleteKlr.UseVisualStyleBackColor = false;
            this.btnDeleteKlr.Click += new System.EventHandler(this.btnDeleteKlr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noKeluarBarangDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.tanggalKeluarDataGridViewTextBoxColumn,
            this.hargaSatuanDataGridViewTextBoxColumn,
            this.kuantitasDataGridViewTextBoxColumn,
            this.hargatotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barangKeluarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 279);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 130);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // noKeluarBarangDataGridViewTextBoxColumn
            // 
            this.noKeluarBarangDataGridViewTextBoxColumn.DataPropertyName = "No_Keluar_Barang";
            this.noKeluarBarangDataGridViewTextBoxColumn.HeaderText = "No_Keluar_Barang";
            this.noKeluarBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noKeluarBarangDataGridViewTextBoxColumn.Name = "noKeluarBarangDataGridViewTextBoxColumn";
            this.noKeluarBarangDataGridViewTextBoxColumn.Width = 125;
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
            // tanggalKeluarDataGridViewTextBoxColumn
            // 
            this.tanggalKeluarDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Keluar";
            this.tanggalKeluarDataGridViewTextBoxColumn.HeaderText = "Tanggal_Keluar";
            this.tanggalKeluarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalKeluarDataGridViewTextBoxColumn.Name = "tanggalKeluarDataGridViewTextBoxColumn";
            this.tanggalKeluarDataGridViewTextBoxColumn.Width = 125;
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
            // barangKeluarBindingSource
            // 
            this.barangKeluarBindingSource.DataMember = "Barang_Keluar";
            this.barangKeluarBindingSource.DataSource = this.invetarisDataSet2;
            // 
            // invetarisDataSet2
            // 
            this.invetarisDataSet2.DataSetName = "InvetarisDataSet2";
            this.invetarisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barang_KeluarTableAdapter
            // 
            this.barang_KeluarTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateBrgKlr
            // 
            this.btnUpdateBrgKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateBrgKlr.Location = new System.Drawing.Point(303, 215);
            this.btnUpdateBrgKlr.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateBrgKlr.Name = "btnUpdateBrgKlr";
            this.btnUpdateBrgKlr.Size = new System.Drawing.Size(91, 35);
            this.btnUpdateBrgKlr.TabIndex = 46;
            this.btnUpdateBrgKlr.Text = "Update";
            this.btnUpdateBrgKlr.UseVisualStyleBackColor = false;
            this.btnUpdateBrgKlr.Click += new System.EventHandler(this.btnUpdateBrgKlr_Click);
            // 
            // btnDisplayKlr
            // 
            this.btnDisplayKlr.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDisplayKlr.Location = new System.Drawing.Point(691, 215);
            this.btnDisplayKlr.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplayKlr.Name = "btnDisplayKlr";
            this.btnDisplayKlr.Size = new System.Drawing.Size(91, 35);
            this.btnDisplayKlr.TabIndex = 47;
            this.btnDisplayKlr.Text = "Display";
            this.btnDisplayKlr.UseVisualStyleBackColor = false;
            this.btnDisplayKlr.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(891, 455);
            this.Controls.Add(this.btnDisplayKlr);
            this.Controls.Add(this.btnUpdateBrgKlr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelKlr);
            this.Controls.Add(this.btnSaveKlr);
            this.Controls.Add(this.btnDeleteKlr);
            this.Controls.Add(this.txtKuantitasKlr);
            this.Controls.Add(this.txtNamaBrgKlr);
            this.Controls.Add(this.txtTglKlr);
            this.Controls.Add(this.txtHrgTotal);
            this.Controls.Add(this.txtHrgStnKlr);
            this.Controls.Add(this.txtKodeBrg);
            this.Controls.Add(this.txtNoBrgKlr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Halaman Barang Keluar";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangKeluarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invetarisDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKuantitasKlr;
        private System.Windows.Forms.TextBox txtNamaBrgKlr;
        private System.Windows.Forms.TextBox txtTglKlr;
        private System.Windows.Forms.TextBox txtHrgTotal;
        private System.Windows.Forms.TextBox txtHrgStnKlr;
        private System.Windows.Forms.TextBox txtKodeBrg;
        private System.Windows.Forms.TextBox txtNoBrgKlr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelKlr;
        private System.Windows.Forms.Button btnSaveKlr;
        private System.Windows.Forms.Button btnDeleteKlr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InvetarisDataSet2 invetarisDataSet2;
        private System.Windows.Forms.BindingSource barangKeluarBindingSource;
        private InvetarisDataSet2TableAdapters.Barang_KeluarTableAdapter barang_KeluarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noKeluarBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalKeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuantitasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargatotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdateBrgKlr;
        private System.Windows.Forms.Button btnDisplayKlr;
    }
}