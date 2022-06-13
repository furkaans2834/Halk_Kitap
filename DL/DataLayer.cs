using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halk_Kitap.DL
{
    public class DataLayer
    {
      static  MySqlConnection conn = new MySqlConnection(
        
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
              Database = "halk_Kitap",
              UserID = "root",
            
              
            }.ConnectionString

        );
            
               
        public static int OkuyucuEkle(Okuyucu o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OkuyucuEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.ID);
                komut.Parameters.AddWithValue("@ad", o.Adi);
                komut.Parameters.AddWithValue("@soy", o.Soyadi);
                komut.Parameters.AddWithValue("@tel", o.Telefon);
                komut.Parameters.AddWithValue("@mail", o.Gmail);
                komut.Parameters.AddWithValue("@adr", o.Adres);

               int res = komut.ExecuteNonQuery();
                return res;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
            
        }

        internal static int SatışEkle(Ksatis ksatış)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("SatışEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ksid", ksatış.ID);
                komut.Parameters.AddWithValue("@oid", ksatış.Okuyucuid);
                komut.Parameters.AddWithValue("@kid", ksatış.Kitapid);
                komut.Parameters.AddWithValue("@tarih", ksatış.Tarih);
                komut.Parameters.AddWithValue("@fiyat", ksatış.Fiyat);
                

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet SatışDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("SatisDetay", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

               
                
                
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int SatisGüncelle(Ksatis ksatış)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("SatisGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@ksid", ksatış.ID);
                komut.Parameters.AddWithValue("@oid", ksatış.Okuyucuid);
                komut.Parameters.AddWithValue("@kid", ksatış.Kitapid);
                komut.Parameters.AddWithValue("@tarih", ksatış.Tarih);
                komut.Parameters.AddWithValue("@fiyat", ksatış.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet ÖdemeDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("ÖdemeDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;




                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÖdemeEkle(Ödeme ödeme)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("ÖdemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@odid", ödeme.ID);
                komut.Parameters.AddWithValue("@oid", ödeme.Okuyucuid);
                komut.Parameters.AddWithValue("@tarih", ödeme.Tarih);
                komut.Parameters.AddWithValue("@tutar", ödeme.Fiyat);
                komut.Parameters.AddWithValue("@tur", ödeme.Tur);
                komut.Parameters.AddWithValue("@aciklama", ödeme.Acıklama);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÖdemeSil(string ID)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OdemeSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@odid", ID);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int ÖdemeGüncelle(Ödeme ödeme)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OdemeGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@odid", ödeme.ID);
                komut.Parameters.AddWithValue("@oid", ödeme.Okuyucuid);
                komut.Parameters.AddWithValue("@tarih", ödeme.Tarih);
                komut.Parameters.AddWithValue("@tutar", ödeme.Fiyat);
                komut.Parameters.AddWithValue("@tur", ödeme.Tur);
                komut.Parameters.AddWithValue("@aciklama", ödeme.Acıklama);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int SatisSil(object id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("SatisSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OkuyucuSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OkuyucuSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
               

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet KitapGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (String.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("KitapHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("KitapBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;



            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int KitapSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("KitapSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int KitapGüncelle(Kitap kitap)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("KitapGüncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", kitap.ID);
                komut.Parameters.AddWithValue("@ad", kitap.ad);
                komut.Parameters.AddWithValue("@kategori", kitap.kategori);
                komut.Parameters.AddWithValue("@fiyat", kitap.fiyat);
                komut.Parameters.AddWithValue("@stok", kitap.stok);
                komut.Parameters.AddWithValue("@yazarı", kitap.yazar);
                

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int KitapEkle(Kitap k)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("KitapEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", k.ID);
                komut.Parameters.AddWithValue("@ad", k.ad);
                komut.Parameters.AddWithValue("@kategori", k.kategori);
                komut.Parameters.AddWithValue("@fiyat", k.fiyat);
                komut.Parameters.AddWithValue("@stok", k.stok);
                komut.Parameters.AddWithValue("@yazarı", k.yazar);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static int OkuyucuGüncelle(Okuyucu o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("OkuyucuGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.ID);
                komut.Parameters.AddWithValue("@ad", o.Adi);
                komut.Parameters.AddWithValue("@soy", o.Soyadi);
                komut.Parameters.AddWithValue("@tel", o.Telefon);
                komut.Parameters.AddWithValue("@mail", o.Gmail);
                komut.Parameters.AddWithValue("@adr", o.Adres);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }

        internal static DataSet OkuyucuGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (String.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("OkuyucularHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                   
                }
                else
                {
                    komut = new MySqlCommand("OkuyucuBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
                
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();

            }
        }
    }
}

