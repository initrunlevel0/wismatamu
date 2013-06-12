using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;

namespace WismaTamu.Pengendali
{
    public class PengendaliAnggota
    {
        private static WismaTamuDb db = new WismaTamuDb();
        public static List<Anggota> LihatSemuaAnggota(string idAnggota)
        {
            return (db.Anggota.Where(x => x.IdAnggota == idAnggota)).ToList();
        }

        public static void SuntingDataAnggota(Anggota dataBaru, string idAnggota)
        {
            try
            {
                var dataAnggota = db.Anggota.SingleOrDefault(x => x.IdAnggota == idAnggota);
                dataAnggota = dataBaru;
                db.SaveChanges();
            }
            catch
            {

            }
        }

        public static void TambahDataAnggota(Anggota dataBaru)
        {
            db.Anggota.Add(dataBaru);
            db.SaveChanges();
        }
    }
}