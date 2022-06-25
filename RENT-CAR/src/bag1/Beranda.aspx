<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag1/Bagian_1.Master" AutoEventWireup="true" CodeBehind="Beranda.aspx.cs" Inherits="RENT_CAR.src.bag1.Beranda" %>

<asp:Content ID="Beranda" ContentPlaceHolderID="Master1" runat="server">
    <%-- GAMBAR UTAMA --%>
    <div class="gambar-utama text-center text-white" id="beranda">
        <div class="jumbotron jumbotron-fluid mt-0 mb-0" style="background-image: url(../../img/car-page.jpg); background-attachment: fixed; background-position: center; background-size: cover; background-repeat: no-repeat; height: 100vh;">
            <div class="container position-relative">
                <h1 class="teks-gambar display-4 text-white font-weight-bold w-100" style="">SELAMAT DATANG</h1>
            </div>
        </div>
    </div>
    <%-- AKHIR GAMBAR UTAMA --%>

    <%-- ARMADA PENYEWAAN --%>
    <div class="armada-penyewaan p-5" id="penyewaan" style="background-color: #F3F3F3;">
        <div class="container">
            <div class="keterangan-sewa text-center mb-5">
                <h1 class="teks-penyewaan">ARMADA KAMI</h1>
            </div>

            <div class="row">
                <asp:PlaceHolder ID="data_mobil" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </div>
    <%-- AKHIR ARMADA PENYEWAAN --%>
</asp:Content>
