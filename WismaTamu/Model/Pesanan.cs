using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WismaTamu.Model
{
    public class Pesanan
    {
        [Required(ErrorMessage="Nomor identitas pesanan belum diisi")]
        [Key]
        public int IdPesanan { get; set; }
        
        [Required(ErrorMessage="Anggota pemesan belum ditentukan")]
        public int AnggotaPemesanId { get; set; }
        
        [ForeignKey("AnggotaPemesanId")]
        public virtual Anggota AnggotaPemesan { get; set; }

        [Required]
        public int KamarDipesanId { get; set; }

        [ForeignKey("KamarDipesanId")]
        public PesananKamar KamarDipesan { get; set; }

        [Required]
        public double BiayaPemesanan { get; set; }

        [Required]
        public double BiayaPiutang { get; set; }

        [Required]
        public string BuktiTransfer { get; set; }

        [Required]
        public int StatusPembayaran { get; set; }

        [Required]
        public int StatusPenginapan { get; set; }

        [Required]
        public DateTime TanggalBayarDpMaks { get; set; }

        [Required]
        public DateTime TanggalCheckin { get; set; }

        [Required]
        public DateTime TanggalCheckout { get; set; }
    }
}