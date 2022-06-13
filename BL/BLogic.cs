using Halk_Kitap.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halk_Kitap.BL
{
   public static class BLogic
    {
        public static bool OkuyucuEkle(Okuyucu o)
        {
            try
            {
                int res = DataLayer.OkuyucuEkle(o);

                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }

        }

        internal static DataSet OkuyucuGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.OkuyucuGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
            
        }

        internal static bool OkuyucuGüncelle(Okuyucu o)
        {
            try
            {
                int res = DataLayer.OkuyucuGüncelle(o);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatışEkle(Ksatis ksatış)
        {
            try
            {
                int res = DataLayer.SatışEkle(ksatış);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

       internal static DataSet SatışDetay()
        {
            try
            {
                DataSet ds = DataLayer.SatışDetay();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
        }
       
        internal static bool OkuyucuSil(string id)
        {
            try
            {
                int res = DataLayer.OkuyucuSil(id);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
            throw new NotImplementedException();
        }

        internal static bool KitapEkle(Kitap k)
        {
            try
            {
                int res = DataLayer.KitapEkle(k);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatisGüncelle(Ksatis ksatış)
        {
            try
            {
                int res = DataLayer.SatisGüncelle(ksatış);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet KitapGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.KitapGetir(filtre);

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
        }

       
      

        internal static bool SatisSil(string ID)
        {
            try
            {
                int res = DataLayer.SatisSil(ID);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool KitapGüncelle(Kitap kitap)
        {
            try
            {
                int res = DataLayer.KitapGüncelle(kitap);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet ÖdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.ÖdemeDetay();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool ÖdemeEkle(Ödeme ödeme)
        {
            try
            {
                int res = DataLayer.ÖdemeEkle(ödeme);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool KitapSil(string ID)
        {
            try
            {
                int res = DataLayer.KitapSil(ID);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÖdemeGüncelle(Ödeme ödeme)
        {
            try
            {
                int res = DataLayer.ÖdemeGüncelle(ödeme);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool ÖdemeSil(string ID)
        {
            try
            {
                int res = DataLayer.ÖdemeSil(ID);

                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
                return false;
            }
        }
    }
}
