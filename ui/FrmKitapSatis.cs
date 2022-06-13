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
    public partial class FrmKitapSatis : Form
    {
        public FrmKitapSatis()
        {
            InitializeComponent();
        }

       
        public Ksatis Ksatış { get; set; }
        public bool Güncelleme { get; set; } = false;       

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value==0)
            {
                errorProvider1.SetError(nmFiyat, "Lüften Fiyat Giriniz");
                nmFiyat.Focus();
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Ksatış.Tarih = dtTarih.Value;
            Ksatış.Fiyat = (double)nmFiyat.Value;
            Ksatış.Kitapid =Guid.Parse(txtKitap.Text);
            Ksatış.Okuyucuid =Guid.Parse(txtOkuyucu.Text);

            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmKitapSatis_Load(object sender, EventArgs e)
        {
            txtID.Text = Ksatış.ID.ToString();
            if (Güncelleme)
            {
                txtOkuyucu.Text = Ksatış.Okuyucuid.ToString();
                txtKitap.Text=Ksatış.Kitapid.ToString();
                nmFiyat.Value = (decimal)Ksatış.Fiyat;
                dtTarih.Value = Ksatış.Tarih;
            }
           
        }

        private void btnOkuyucuSeç_Click(object sender, EventArgs e)
        {
            Okuyucular frm = new Okuyucular();
            if(frm.ShowDialog()== DialogResult.OK)
            {
               
                txtOkuyucu.Text =frm.Okuyucu.ID. ToString();
            }

        }

        private void btnKitapSeç_Click(object sender, EventArgs e)
        {
            Kitaplar frm = new Kitaplar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
              
                txtKitap.Text =frm.Kitap.ID.ToString();
            }
        }
    }
}
