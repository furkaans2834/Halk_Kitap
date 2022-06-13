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
    public partial class FrmOkuyucu : Form
    {
        public FrmOkuyucu()
        {
            InitializeComponent();
        }
        public Okuyucu Okuyucu { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdres)) return;

            Okuyucu.Adi = txtAd.Text;
            Okuyucu.Soyadi = txtSoyad.Text;
            Okuyucu.Telefon = txtTel.Text;
            Okuyucu.Gmail = txtMail.Text;
            Okuyucu.Adres = txtAdres.Text;
           

            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik Ve Hatalı Bilgi");
                    c.Focus();
                    return false;
                }



                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }

            }
            
            return true;
        }

        private void FrmOkuyucu_Load(object sender, EventArgs e)
        {
            txtID.Text = Okuyucu.ID.ToString();
            if(Güncelleme)
            {
                txtAd.Text = Okuyucu.Adi;
                txtSoyad.Text = Okuyucu.Soyadi;
                txtTel.Text = Okuyucu.Telefon;
                txtMail.Text=Okuyucu.Gmail;
                txtAdres.Text= Okuyucu.Adres;
            }
            
        }
    }
}
