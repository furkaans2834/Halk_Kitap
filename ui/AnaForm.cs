using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Halk_Kitap.BL;
using Halk_Kitap.ui;

namespace Halk_Kitap
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        Okuyucular oku =new Okuyucular();
        Kitaplar kitap  = new Kitaplar();
        
        private void btnOkuyucular_Click(object sender, EventArgs e)
        {
            oku.ShowDialog();
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            kitap.ShowDialog();
        }

        private void btnSatşYap_Click(object sender, EventArgs e)
        {
            FrmKitapSatis frm = new FrmKitapSatis()
            {
                Text = "Satış Yap",
                Ksatış=new Ksatis()
                {
                    ID = Guid.NewGuid()
                },
            };
            
                var sonuc = frm.ShowDialog();
                if (sonuc == DialogResult.OK)
                {
                    bool b = BLogic.SatışEkle(frm.Ksatış);
                    if (b)
                    {
                    DataSet ds1 = BLogic.SatışDetay();
                    if (ds1 != null)
                        dataGridView2.DataSource = ds1.Tables[0];
                }
                }
            
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = BLogic.SatışDetay();
            if (ds1 != null)
                dataGridView2.DataSource = ds1.Tables[0];

            DataSet ds2 = BLogic.ÖdemeDetay();
            if (ds2 != null)
                dataGridView1.DataSource = ds2.Tables[0];
        }

        private void btnSatışDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmKitapSatis frm = new FrmKitapSatis()
            {
                Text = "Satış Güncelle",
                Güncelleme = true,
               Ksatış= new Ksatis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Okuyucuid =Guid.Parse( row.Cells[1].Value.ToString()),
                    Kitapid =Guid.Parse( row.Cells[2].Value.ToString()),
                    Fiyat =double.Parse(row.Cells[6].Value.ToString()),
                   Tarih =DateTime.Parse( row.Cells[7].Value.ToString()),
                    


                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisGüncelle(frm.Ksatış);
                if (b)
                {

                    row.Cells[1].Value = frm.Ksatış.Okuyucuid;
                    row.Cells[2].Value = frm.Ksatış.Kitapid;
                    row.Cells[6].Value = frm.Ksatış.Fiyat;
                    row.Cells[7].Value = frm.Ksatış.Tarih;
                    
                }
            }
        }

        private void btnSatışSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Şeçili Kayıtı Silmek İstermisiniz?", "Silmeyı Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);
                if (b)
                {
                    DataSet ds1 = BLogic.SatışDetay();
                    if (ds1 != null)
                        dataGridView2.DataSource = ds1.Tables[0];
                }
            }
        }

        private void btnÖdemeYap_Click(object sender, EventArgs e)
        {
           FrmÖdeme frm = new FrmÖdeme()
            {
                Text = "Ödeme Yap",
                Ödeme = new Ödeme()
                {
                    ID = Guid.NewGuid()
                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÖdemeEkle(frm.Ödeme);
                if (b)
                {
                    DataSet ds1 = BLogic.ÖdemeDetay();
                   if (ds1 != null)
                      dataGridView1.DataSource = ds1.Tables[0];
                }
            }
        }

        private void btnÖdemeDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmÖdeme frm = new FrmÖdeme()
            {
                Text = "Ödeme Güncelle",
                Güncelleme = true,
                Ödeme = new Ödeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Okuyucuid = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[4].Value.ToString()),
                    Tur = row.Cells[5].Value.ToString(),
                    Acıklama = row.Cells[6].Value.ToString(),
                    
                    



                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÖdemeGüncelle(frm.Ödeme);
                if (b)
                {

                    row.Cells[1].Value = frm.Ödeme.Okuyucuid;
                    row.Cells[3].Value = frm.Ödeme.Tarih;
                    row.Cells[4].Value = frm.Ödeme.Fiyat;
                    row.Cells[5].Value = frm.Ödeme.Tur;
                    row.Cells[6].Value = frm.Ödeme.Acıklama;

                }
            }
        }

        private void btnÖdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Şeçili Kayıtı Silmek İstermisiniz?", "Silmeyı Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÖdemeSil(ID);
                if (b)
                {
                    DataSet ds1 = BLogic.SatışDetay();
                    if (ds1 != null)
                        dataGridView1.DataSource = ds1.Tables[0];
                }
            }
        }
    }
}

