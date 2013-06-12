using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;
using WismaTamu.Sistem;

namespace WismaTamu.Pengendali
{
    public class PengendaliDataAnggota
    {
        private  WismaTamuDb db = new WismaTamuDb();

        public List<Anggota> LihatSemuaAnggota()
        {
            return db.Anggota.ToList();
        }

        public Anggota SuntingDataAngota(string idAnggota)
        {
            return db.Anggota.SingleOrDefault(x => x.IdAnggota == idAnggota);
        }

        public void TambahAnggotaBaru(string ID, string nama, string alamat, string kontak, string sandi, string surel)
        {
            Anggota dataAnggotaBaru = new Anggota();
            dataAnggotaBaru.IdAnggota = ID;
            dataAnggotaBaru.NamaAnggota = nama;
            dataAnggotaBaru.AlamatAnggota = alamat;
            dataAnggotaBaru.NomorKontakAnggota = kontak;
            dataAnggotaBaru.PasswordAnggota = sandi;
            dataAnggotaBaru.SurelAnggota = surel;
            db.Anggota.Add(dataAnggotaBaru);
        }
    }
}