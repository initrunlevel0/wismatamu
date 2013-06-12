<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="PendaftaranAnggota.aspx.cs" Inherits="WismaTamu.PendaftaranAnggota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="pagetitle" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    Sugeng Rawuh
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="content" runat="server">
    <p>
        Melalui halaman ini, Anda dapt mendaftarkan diri sebagai anggota baru Guesthouse ITS sehingga Anda bisa melakukan pemesanan kamar secara mandiri melalui sistem ini.
        <br/>
        Silakan masukan data diri Anda di sini.
    </p>
    <p>
        *) Wajib diisi
    </p>
    <div>
        <h3><strong> Data autentikasi untuk masuk </strong></h3>
        <h5>Data berikut akan digunakan untuk proses masuk ke dalam sistem</h5>
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" Text="No. Identitas Pengguna*" />
                </td>
                <td>
                    <asp:TextBox runat="server" ID="tbIdentitas"/>
                    <asp:RequiredFieldValidator ControlToValidate="tbIdentitas" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
                <td> No. KTP/SIM/KM ITS</td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Alamat Surel*" />
                </td>
                <td>
                    <asp:TextBox ID="tbSurel" runat="server" placeholder="alamat@contoh.com" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tbSurel" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td colspan="3"> <h6>Catatan: Anda dapat menggunakan nomor identitas / alamat surel untuk masuk</h6> </td>
            </tr>
            <tr>
                <td>
                    Kata Sandi
                </td>
                <td>
                    <asp:TextBox ID="tbSandi" TextMode="Password" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tbSandi" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    Ulangi Kata Sandi
                </td>
                <td>
                    <asp:TextBox ID="tbKonfSandi" TextMode="Password" runat="server" />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Kata Sandi Tidak Sama" ControlToCompare="tbSandi" ControlToValidate="tbKonfSandi"></asp:CompareValidator>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div>
        <h3><strong>Data diri pengguna</strong></h3>
        <h5>Silakan masukan data diri pengguna untuk mempermudah proses transaksi </h5>
        <table>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Nama Lengkap" />
                </td>
                <td>
                    <asp:TextBox ID="tbNama" runat="server" placeholder="Nama Anda" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tbNama" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Alamat/Domisili*" />
                </td>
                <td>
                    <asp:TextBox ID="tbAlamat" runat="server" placeholder="Alamat Anda" TextMode="MultiLine" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tbAlamat" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label  runat="server" Text="Nomor Kontak*" />
                </td>
                <td>
                    <asp:TextBox ID="tbKontak" runat="server" placeholder="Nomor Kontak Anda" TextMode="MultiLine" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="tbKontak" ErrorMessage="Harus Diisi" runat="server"/>
                </td>
            </tr>
        </table>
    </div>
    <table>
        <tr>
            <td><asp:CheckBox ID="cbSetuju" runat="server" Text="Saya menyetujui segala ketentuan di dalam sistem manajemen pemesanan Guesthouse ITS ini" /></td>            
        </tr>
        <tr style="position:relative; margin:auto;">
            <td colspan="2">
                <asp:Button ID="btnProses" runat="server" OnClick="btnProses_Click" Text="Proses Pendaftaran"/>
            </td>
        </tr>
    </table>
    
</asp:Content>