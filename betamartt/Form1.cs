﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betamartt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Apakah anda yakin untuk menghapus ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    barangBindingSource.RemoveCurrent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.appData.Barang);
            barangBindingSource.DataSource = this.appData.Barang;
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            try
            {
                barangBindingSource.EndEdit();
                barangTableAdapter.Update(this.appData.Barang);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);

            }

        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtnama.Focus();
                this.appData.Barang.AddBarangRow(this.appData.Barang.NewBarangRow());
                barangBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                barangBindingSource.ResetBindings(false);

            }

        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            barangBindingSource.ResetBindings(false);
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtnama.Focus();
        }

        private void btnpict_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictbox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
           barangBindingSource.RemoveCurrent();
        }
    }
}