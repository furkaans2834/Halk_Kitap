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
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            FrmKitap frm = new FrmKitap()
            {
                Text = "Kitap Ekle",
                Kitap = new Kitap() { ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KitapEkle(frm.Kitap);
                if (b)
                {
                    DataSet ds = BLogic.KitapGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnKitapBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.KitapGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnKitapDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmKitap frm = new FrmKitap()
            {
                Text = "Kitap Güncelle",
                Güncelleme = true,
                Kitap = new Kitap()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    ad = row.Cells[1].Value.ToString(),
                    kategori = row.Cells[2].Value.ToString(),
                    fiyat = double.Parse(row.Cells[3].Value.ToString()),
                    stok = double.Parse(row.Cells[4].Value.ToString()),
                    yazar = row.Cells[5].Value.ToString(),


                }
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KitapGüncelle(frm.Kitap);

                if (b)
                {
                    row.Cells[1].Value = frm.Kitap.ad;
                    row.Cells[2].Value = frm.Kitap.kategori;
                    row.Cells[3].Value = frm.Kitap.fiyat;
                    row.Cells[4].Value = frm.Kitap.stok;
                    row.Cells[5].Value = frm.Kitap.yazar;


                }

            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Şeçili Kayıtı Silmek İstermisiniz?", "Silmeyı Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KitapSil(ID);
                if (b)
                {
                    DataSet ds = BLogic.KitapGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            DataSet ds2 = BLogic.KitapGetir("");
            if (ds2 != null)
                dataGridView1.DataSource = ds2.Tables[0];
        }

        public Kitap Kitap { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];



            Kitap = new Kitap()
            {
                ID = Guid.Parse(row.Cells[0].Value.ToString()),
                ad = row.Cells[1].Value.ToString(),
                kategori = row.Cells[2].Value.ToString(),
                fiyat = double.Parse(row.Cells[3].Value.ToString()),
                stok = double.Parse(row.Cells[4].Value.ToString()),
                yazar = row.Cells[5].Value.ToString(),


            };
            DialogResult = DialogResult.OK;
            
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
   
}
