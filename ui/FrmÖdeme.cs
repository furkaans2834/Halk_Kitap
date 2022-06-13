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
    public partial class FrmÖdeme : Form
    {
        public FrmÖdeme()
        {
            InitializeComponent();
        }
        
        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Ödeme Ödeme { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (nmTutar.Value == 0)
            {
                errorProvider1.SetError(nmTutar, "Lüften Tutar Giriniz");
                nmTutar.Focus();
            }
            else
            {
                errorProvider1.SetError(nmTutar, "");
            }
            if (cmnTur.SelectedItem == null)
            {
                errorProvider1.SetError(cmnTur, "Ödeme Türü Seçınız");
                cmnTur.Focus();
                return ;
            }



            else
            {
                errorProvider1.SetError(cmnTur, "");
                
            }
            if (txtAçık.Text == "")
            {
                errorProvider1.SetError(txtAçık, "Açıklama Kısmını Boş  Bırakmayız");
                txtAçık.Focus();
                return;
            }



            else
            {
                errorProvider1.SetError(txtAçık, "");

            }
            Ödeme.Okuyucuid =Guid.Parse( txtOkuyucu.Text);
            Ödeme.Tur = cmnTur.SelectedItem.ToString();
           Ödeme.Fiyat = (double)nmTutar.Value;
            Ödeme.Acıklama = txtAçık.Text;
            Ödeme.Tarih = dtTarih.Value;


            DialogResult = DialogResult.OK;
            
        }

        private void FrmÖdeme_Load(object sender, EventArgs e)
        {
            txtID.Text = Ödeme.ID.ToString();
            if (Güncelleme)
            {
                txtOkuyucu.Text = Ödeme.Okuyucuid.ToString();
                dtTarih.Value = Ödeme.Tarih;
                nmTutar.Value = (decimal)Ödeme.Fiyat;
                cmnTur.SelectedItem = Ödeme.Tur;
                txtAçık.Text=Ödeme.Acıklama.ToString();
                
            }
        }

        private void btnOkuyucuSeç_Click(object sender, EventArgs e)
        {
            Okuyucular frm = new Okuyucular();
            if (frm.ShowDialog() == DialogResult.OK)
            {

                txtOkuyucu.Text = frm.Okuyucu.ID.ToString();
            }
        }
    }
}
