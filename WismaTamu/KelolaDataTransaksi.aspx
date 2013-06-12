<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="KelolaDataTransaksi.aspx.cs" Inherits="WismaTamu.KelolaDataTransaksi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Kelola Data Transaksi
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    Pada halaman ini dapat melihat daftar transaksi yang akan dilakukan setiap pengguna atau setiap tanggal yang dilakukan serta menyetujui pesanan yang sudah dikonfirmasi. Nama pengguna bisa dicari menggunakan kode atau nama penggunanya.
    <div style="background-color:aqua">
        <asp:Label ID="Label1" runat="server" Text="Label">Pencarian Pengguan&nbsp:&nbsp</asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="344px"></asp:TextBox>&nbsp&nbsp
        <input type="submit" value="Cari" />
        <p>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Untuk tangal Pemesanan"></asp:Label>
        </p>
    </div>
</asp:Content>
