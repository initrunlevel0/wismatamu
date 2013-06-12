using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;

namespace WismaTamu.Pengendali
{
    public class PengendaliKamar
    {
        private static WismaTamuDb db = new WismaTamuDb();
        public static List<Kamar> LihatSemuaKamar(string namaKamar)
        {
            return (db.Kamar.Where(x => x.KamarTersedia == true)).ToList();
        }

        public static void SuntingDataKamar(Kamar dataBaru, int idKamar)
        {
            try
            {
                var dataKamar = db.Kamar.SingleOrDefault(x => x.IdKamar == idKamar);
                dataKamar = dataBaru;
                db.SaveChanges();
            }
            catch
            {

            }
        }

        public static void TambahDataAnggota(Kamar dataBaru)
        {
            db.Kamar.Add(dataBaru);
            db.SaveChanges();
        }
    }
}