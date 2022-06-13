using Halk_Kitap.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halk_Kitap.ui
{
    public partial class Okuyucular : Form
    {
        public Okuyucular()
        {
            InitializeComponent();
        }
        private void bntOkuyucuEkle_Click(object sender, EventArgs e)
        {

            FrmOkuyucu frmOkuyucu = new FrmOkuyucu()
            {
                Text = "Okuyucu Ekle",
                Okuyucu = new Okuyucu() { ID = Guid.NewGuid() },
            };
            var sonuc = frmOkuyucu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OkuyucuEkle(frmOkuyucu.Okuyucu);
                if (b)
                {
                    DataSet ds = BLogic.OkuyucuGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnOkuyucuBul_Click_1(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OkuyucuGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        

        private void btnOkuyucuDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmOkuyucu frmOkuyucu = new FrmOkuyucu()
            {
                Text = "Okuyucu Güncelle",
                Güncelleme = true,
                Okuyucu = new Okuyucu()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Adi = row.Cells[1].Value.ToString(),
                    Soyadi = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Gmail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString()


                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frmOkuyucu.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OkuyucuGüncelle(frmOkuyucu.Okuyucu);
                if (b)
                {

                    row.Cells[1].Value = frmOkuyucu.Okuyucu.Adi;
                    row.Cells[2].Value = frmOkuyucu.Okuyucu.Soyadi;
                    row.Cells[3].Value = frmOkuyucu.Okuyucu.Telefon;
                    row.Cells[4].Value = frmOkuyucu.Okuyucu.Gmail;
                    row.Cells[5].Value = frmOkuyucu.Okuyucu.Adres;
                }
            }
        }

        private void btnOkuyucuSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Şeçili Kayıtı Silmek İstermisiniz?", "Silmeyı Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OkuyucuSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.OkuyucuGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }

        }

        private void Okuyucular_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.OkuyucuGetir("");
            if (ds1 != null)
                dataGridView2.DataSource = ds1.Tables[0];
        }

        public Okuyucu Okuyucu { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            Okuyucu = new Okuyucu()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                Adi = row.Cells[1].Value.ToString(),
                Soyadi = row.Cells[2].Value.ToString(),
                Telefon = row.Cells[3].Value.ToString(),
                Gmail = row.Cells[4].Value.ToString(),
                Adres = row.Cells[5].Value.ToString()


            };

                //{ ID = Guid.NewGuid() },
            




            DialogResult = DialogResult.OK;
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
