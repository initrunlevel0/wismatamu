using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;
using WismaTamu.Sistem;

namespace WismaTamu.Pengendali
{
    public class PengedaliKamar
    {
        private WismaTamuDb db = new WismaTamuDb();

        public List<Kamar> LihatSemuaKamar()
        {
            return db.Kamar.ToList();
        }

        public Kamar SuntingDataKamar(int idKamar)
        {
            return db.Kamar.SingleOrDefault(x => x.IdKamar == idKamar);
        }

        public void TambahKamarBaru(Kamar dataKamarBaru)
        {
            db.Kamar.Add(dataKamarBaru);
        }
    }
}