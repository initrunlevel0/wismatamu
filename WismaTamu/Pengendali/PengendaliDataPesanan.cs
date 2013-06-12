using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WismaTamu.Model;
using WismaTamu.Sistem;

namespace WismaTamu.Pengendali
{
    public class PengendaliDataPesanan
    {
        private WismaTamuDb db = new WismaTamuDb();

        public List<Pesanan> CekPesananRentangTanggal(DateTime tanggalCheckin, DateTime tanggalCheckout)
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var x in db.Pesanan.Where(x => x.TanggalCheckin >= tanggalCheckin && x.TanggalCheckout <= tanggalCheckout && x.StatusPembayaran > 0))
            {
                listPesanan.Add(x);
            }
            return listPesanan;
        }

        public bool CekStatusKamarDipilih(int inputID)
        {
            var kamar = db.Kamar.SingleOrDefault(x => x.IdKamar == inputID);
            return kamar.KamarTersedia;
        }

        public void CheckinPesanan(int inputID)
        {
            var pesanan = db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
            pesanan.StatusPenginapan = 1;
        }

        public void CheckoutPesanan(int inputID)
        {
            var pesanan = db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
            pesanan.StatusPenginapan = 2;
        }

        public void EditPesananMember(int inputID, Pesanan dataPesananBaru)
        {
            var pesanan = db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
            pesanan = dataPesananBaru;
        }

        public List<Pesanan> LihatPesananCheckinHariIni()
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var pesanan in db.Pesanan.Where(x => x.TanggalCheckin == DateTime.Now))
            {
                listPesanan.Add(pesanan);
            }
            return listPesanan;
        }

        public List<Pesanan> LihatPesananCheckoutHariIni()
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var pesanan in db.Pesanan.Where(x => x.TanggalCheckout == DateTime.Now))
            {
                listPesanan.Add(pesanan);
            }
            return listPesanan;
        }

        public Pesanan LihatPesananKode(int inputID)
        {
            return db.Pesanan.SingleOrDefault(x => x.IdPesanan == inputID);
        }

        public List<Pesanan> LihatPesananMember(int idAnggota)
        {
            List<Pesanan> listPesanan = new List<Pesanan>();
            foreach (var pesanan in db.Pesanan.Where(x => x.AnggotaPemesanId == idAnggota))
            {
                listPesanan.Add(pesanan);
            }
            return listPesanan;
        }

        public void TambahPesananBaru(Pesanan dataPesananBaru)
        {
            db.Pesanan.Add(dataPesananBaru);
        }
    }
}