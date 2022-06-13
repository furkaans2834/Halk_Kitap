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
    public partial class FrmKitap : Form
    {
        public FrmKitap()
        {
            InitializeComponent();
        }

       

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public Kitap Kitap { get; set; }
        
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtKitapAd)) return;
            if (!ErrorControl(cbKategori)) return;
            if (!ErrorControl(nmFiyat)) return;
            if (!ErrorControl(nmStok)) return;
            if (!ErrorControl(txtYazar)) return;

            Kitap.ad = txtKitapAd.Text;
            Kitap.kategori = cbKategori.Text;
            Kitap.fiyat =(double)nmFiyat.Value;
            Kitap.stok =  (double)nmStok.Value;
            Kitap.yazar = txtYazar.Text;
           
            
            DialogResult = DialogResult.OK;
        }
        private bool ErrorControl(Control b)
        {
            if (b is TextBox || b is ComboBox)
            {
                if (b.Text == "")
                {
                    errorProvider1.SetError(b, "Eksik veya hatalı bilgi");
                    b.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(b, "");
                    return true;

                }
            }

            if (b is NumericUpDown)
            {
                if (((NumericUpDown)b).Value == 0)
                {
                    errorProvider1.SetError(b, "Eksik veya hatalı bilgi");
                    b.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(b, "");
                    return true;

                }
            }

            return true;

        }
        
        

        private void FrmKitap_Load_1(object sender, EventArgs e)
        {
            txtID.Text = Kitap.ID.ToString();
            if (Güncelleme)
            {
                txtKitapAd.Text = Kitap.ad;
                cbKategori.Text = Kitap.kategori;
                nmFiyat.Value = (decimal)Kitap.fiyat;
                nmStok.Value = (decimal)Kitap.stok;
                txtYazar.Text = Kitap.yazar;



            }
        }
    }
}
