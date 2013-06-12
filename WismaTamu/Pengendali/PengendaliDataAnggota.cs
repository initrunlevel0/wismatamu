﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;
using WismaTamu.Sistem;

namespace WismaTamu.Pengendali
{
    public static class PengendaliDataAnggota
    {
        private static WismaTamuDb db = new WismaTamuDb();

        public static List<Anggota> LihatSemuaAnggota()
        {
            return db.Anggota.ToList();
        }

        public static Anggota SuntingDataAngota(string idAnggota)
        {
            return db.Anggota.SingleOrDefault(x => x.IdAnggota == idAnggota);
        }

        public static void TambahAnggotaBaru(string ID, string nama, string alamat, string kontak, string sandi, string surel)
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
    
        public static bool CekAnggota(string idPengguna,string kataSandiMD5)
        {
 	        // Cek data anggota apakah ada atau tidak
            var dataAnggota = db.Anggota.Where(x => x.IdAnggota == idPengguna && x.PasswordAnggota == kataSandiMD5);
            if (dataAnggota.Count() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}