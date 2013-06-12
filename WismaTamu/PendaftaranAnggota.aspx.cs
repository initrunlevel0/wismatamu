using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WismaTamu.Pengendali;
using WismaTamu.Sistem;


namespace WismaTamu
{
    public partial class PendaftaranAnggota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnProses_Click(object sender, EventArgs e)
        {
            if (cbSetuju.Checked)
            {
                PengendaliDataAnggota pengendaliAnggota = new PengendaliDataAnggota();
                pengendaliAnggota.TambahAnggotaBaru(tbIdentitas.Text, tbNama.Text, tbAlamat.Text, tbKontak.Text, tbSandi.Text, tbSurel.Text);
            }
        }
    }
}