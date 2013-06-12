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
    public partial class Checkin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btCari_Click(object sender, EventArgs e)
        {
            PengendaliDataPesanan pengendaliDataPesanan = new PengendaliDataPesanan();
            pengendaliDataPesanan.LihatPesananKode(ints.Parse(tbCari.Text));
        }
    }
}