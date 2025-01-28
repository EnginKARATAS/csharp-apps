using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _16_12_2020
{
    public class KitapVT
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\sona\Desktop\1.mdb");
        public List<Kitap> _kt_list;

        public KitapVT()
        {
            _kt_list = new List<Kitap>();
        }
        public List<Kitap> DatagridGuncelle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from kitaplar", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap temp = new Kitap();
                temp.Id = Convert.ToInt32(dr[0].ToString());
                temp.AD = dr[1].ToString();
                temp.Yazar = dr[2].ToString();
                _kt_list.Add(temp);

            }

            baglanti.Close();
            return _kt_list;
        }

        public void KitapEkle(Kitap k)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar) values (@p1,@p2)",baglanti);
            komut.Parameters.AddWithValue("@p1", k.AD);
            komut.Parameters.AddWithValue("@p2", k.Yazar);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
         
        public void BookDelete(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Kitaplar where id = @id",baglanti);
            komut.Parameters.AddWithValue("@p1",kt.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
        }

        public void BookUpdate(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Update Kitaplar set  KitapAd = @kitapad, Yazar =@yazar where id=@id", baglanti);
            komut.Parameters.AddWithValue("@kitapad", kt.AD);
            komut.Parameters.AddWithValue("@yazar", kt.Yazar);
            komut.Parameters.AddWithValue("@id", kt.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

    }
}
