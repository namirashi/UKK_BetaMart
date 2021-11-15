namespace betamartt
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.txtdeskripsi = new System.Windows.Forms.TextBox();
            this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new betamartt.AppData();
            this.txtpabrik = new System.Windows.Forms.TextBox();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.deskripsi = new System.Windows.Forms.Label();
            this.pabrik = new System.Windows.Forms.Label();
            this.jumlah = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.btnpict = new System.Windows.Forms.Button();
            this.pictbox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pabrikProduksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.barangTableAdapter = new betamartt.AppDataTableAdapters.BarangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhapus = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel.Controls.Add(this.txtdeskripsi);
            this.panel.Controls.Add(this.txtpabrik);
            this.panel.Controls.Add(this.txtjumlah);
            this.panel.Controls.Add(this.txtharga);
            this.panel.Controls.Add(this.txtnama);
            this.panel.Controls.Add(this.deskripsi);
            this.panel.Controls.Add(this.pabrik);
            this.panel.Controls.Add(this.jumlah);
            this.panel.Controls.Add(this.harga);
            this.panel.Controls.Add(this.nama);
            this.panel.Controls.Add(this.btnpict);
            this.panel.Controls.Add(this.pictbox);
            this.panel.Location = new System.Drawing.Point(52, 45);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(840, 215);
            this.panel.TabIndex = 0;
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtdeskripsi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Deskripsi Barang", true));
            this.txtdeskripsi.Location = new System.Drawing.Point(284, 101);
            this.txtdeskripsi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdeskripsi.Multiline = true;
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.Size = new System.Drawing.Size(554, 81);
            this.txtdeskripsi.TabIndex = 4;
            // 
            // barangBindingSource
            // 
            this.barangBindingSource.DataMember = "Barang";
            this.barangBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtpabrik
            // 
            this.txtpabrik.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtpabrik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Pabrik Produksi", true));
            this.txtpabrik.Location = new System.Drawing.Point(620, 55);
            this.txtpabrik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtpabrik.Name = "txtpabrik";
            this.txtpabrik.Size = new System.Drawing.Size(218, 21);
            this.txtpabrik.TabIndex = 3;
            // 
            // txtjumlah
            // 
            this.txtjumlah.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtjumlah.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Jumlah Barang", true));
            this.txtjumlah.Location = new System.Drawing.Point(620, 6);
            this.txtjumlah.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(218, 21);
            this.txtjumlah.TabIndex = 2;
            // 
            // txtharga
            // 
            this.txtharga.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtharga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Harga", true));
            this.txtharga.Location = new System.Drawing.Point(280, 55);
            this.txtharga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(218, 21);
            this.txtharga.TabIndex = 1;
            // 
            // txtnama
            // 
            this.txtnama.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtnama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangBindingSource, "Nama Barang", true));
            this.txtnama.Location = new System.Drawing.Point(280, 8);
            this.txtnama.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(218, 21);
            this.txtnama.TabIndex = 0;
            // 
            // deskripsi
            // 
            this.deskripsi.AutoSize = true;
            this.deskripsi.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskripsi.Location = new System.Drawing.Point(169, 101);
            this.deskripsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(105, 14);
            this.deskripsi.TabIndex = 6;
            this.deskripsi.Text = "Deskripsi Barang :";
            // 
            // pabrik
            // 
            this.pabrik.AutoSize = true;
            this.pabrik.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pabrik.Location = new System.Drawing.Point(515, 58);
            this.pabrik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pabrik.Name = "pabrik";
            this.pabrik.Size = new System.Drawing.Size(98, 14);
            this.pabrik.TabIndex = 5;
            this.pabrik.Text = "Pabrik Produksi :";
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.Location = new System.Drawing.Point(521, 8);
            this.jumlah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(94, 14);
            this.jumlah.TabIndex = 4;
            this.jumlah.Text = "Jumlah Barang :";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.Location = new System.Drawing.Point(169, 58);
            this.harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(98, 14);
            this.harga.TabIndex = 3;
            this.harga.Text = "Harga Barang     :";
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(169, 12);
            this.nama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(98, 14);
            this.nama.TabIndex = 2;
            this.nama.Text = "Nama Barang     :";
            // 
            // btnpict
            // 
            this.btnpict.BackColor = System.Drawing.Color.PeachPuff;
            this.btnpict.Location = new System.Drawing.Point(4, 157);
            this.btnpict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnpict.Name = "btnpict";
            this.btnpict.Size = new System.Drawing.Size(140, 25);
            this.btnpict.TabIndex = 1;
            this.btnpict.Text = "Tambah Gambar";
            this.btnpict.UseVisualStyleBackColor = false;
            this.btnpict.Click += new System.EventHandler(this.btnpict_Click);
            // 
            // pictbox
            // 
            this.pictbox.BackColor = System.Drawing.Color.LemonChiffon;
            this.pictbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictbox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.barangBindingSource, "Image", true));
            this.pictbox.Location = new System.Drawing.Point(4, 5);
            this.pictbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictbox.Name = "pictbox";
            this.pictbox.Size = new System.Drawing.Size(140, 135);
            this.pictbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictbox.TabIndex = 0;
            this.pictbox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBarangDataGridViewTextBoxColumn,
            this.namaBarangDataGridViewTextBoxColumn,
            this.jumlahBarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.pabrikProduksiDataGridViewTextBoxColumn,
            this.deskripsiBarangDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.barangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(52, 296);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(840, 161);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // iDBarangDataGridViewTextBoxColumn
            // 
            this.iDBarangDataGridViewTextBoxColumn.DataPropertyName = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn.HeaderText = "ID Barang";
            this.iDBarangDataGridViewTextBoxColumn.Name = "iDBarangDataGridViewTextBoxColumn";
            // 
            // namaBarangDataGridViewTextBoxColumn
            // 
            this.namaBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama Barang";
            this.namaBarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namaBarangDataGridViewTextBoxColumn.Name = "namaBarangDataGridViewTextBoxColumn";
            // 
            // jumlahBarangDataGridViewTextBoxColumn
            // 
            this.jumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "Jumlah Barang";
            this.jumlahBarangDataGridViewTextBoxColumn.HeaderText = "Jumlah Barang";
            this.jumlahBarangDataGridViewTextBoxColumn.Name = "jumlahBarangDataGridViewTextBoxColumn";
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            // 
            // pabrikProduksiDataGridViewTextBoxColumn
            // 
            this.pabrikProduksiDataGridViewTextBoxColumn.DataPropertyName = "Pabrik Produksi";
            this.pabrikProduksiDataGridViewTextBoxColumn.HeaderText = "Pabrik Produksi";
            this.pabrikProduksiDataGridViewTextBoxColumn.Name = "pabrikProduksiDataGridViewTextBoxColumn";
            // 
            // deskripsiBarangDataGridViewTextBoxColumn
            // 
            this.deskripsiBarangDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi Barang";
            this.deskripsiBarangDataGridViewTextBoxColumn.HeaderText = "Deskripsi Barang";
            this.deskripsiBarangDataGridViewTextBoxColumn.Name = "deskripsiBarangDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 200;
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.PeachPuff;
            this.btntambah.Location = new System.Drawing.Point(465, 483);
            this.btntambah.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(88, 25);
            this.btntambah.TabIndex = 2;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.PeachPuff;
            this.btnubah.Location = new System.Drawing.Point(582, 483);
            this.btnubah.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(88, 25);
            this.btnubah.TabIndex = 3;
            this.btnubah.Text = "Ubah";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.PeachPuff;
            this.btnsimpan.Location = new System.Drawing.Point(805, 483);
            this.btnsimpan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(88, 25);
            this.btnsimpan.TabIndex = 5;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            this.btnsimpan.Click += new System.EventHandler(this.btnsimpan_Click);
            // 
            // barangTableAdapter
            // 
            this.barangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humnst777 Blk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Beta Mart";
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.PeachPuff;
            this.btnhapus.Location = new System.Drawing.Point(689, 483);
            this.btnhapus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(88, 25);
            this.btnhapus.TabIndex = 7;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(934, 520);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtdeskripsi;
        private System.Windows.Forms.TextBox txtpabrik;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label deskripsi;
        private System.Windows.Forms.Label pabrik;
        private System.Windows.Forms.Label jumlah;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Button btnpict;
        private System.Windows.Forms.PictureBox pictbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btnsimpan;
        private AppData appData;
        private System.Windows.Forms.BindingSource barangBindingSource;
        private AppDataTableAdapters.BarangTableAdapter barangTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pabrikProduksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Button btnhapus;
    }
}

