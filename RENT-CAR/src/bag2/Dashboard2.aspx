<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag2/Bagian_2.Master" AutoEventWireup="true" CodeBehind="Dashboard2.aspx.cs" Inherits="RENT_CAR.src.bag2.Dashboard2" %>

<asp:Content ID="Dashboard2" ContentPlaceHolderID="Master2" runat="server">

    <div class="row">
        <%-- BAG KIRI --%>
        <div class="sisi-kiri col-lg-2 pt-3 text-black text-center">
            <h1 class="font-weight-bolder d-block ml-2 w-100 d-block mt-2 mb-5" style="">DASHBOARD</h1>
            <div class="list ml-3">
                <h4 class="font-weight-bold mt-5" style="">
                    <a href="/src/bag2/Dashboard1.aspx">Data Pelanggan</a>
                </h4>
                <h4 class="font-weight-bold mt-3 aktif" style="">
                    <a href="/src/bag2/Dashboard2.aspx">Armada</a>
                </h4>
                <h4 class="font-weight-bold mt-3">
                    <asp:LinkButton ID="logout" Text="Logout" runat="server" OnClick="logout_Click" />
                </h4>
            </div>
        </div>
        <%-- AKHIR BAG KIRI --%>

        <%-- BAG KANAN --%>
        <div class="sisi-kanan col-lg-9 p-5 pt-5" style="background-color: #fff;">
            <div class="bungkus-table" style="">
                <asp:Placeholder ID="data_kendaraan" runat="server"></asp:Placeholder>
            </div>

            <%-- TAMBAH DATA -> MOBIL --%>
            <div class="tbl-tambah-luar">
                <div class="tbl-tambah-dalam w-25 m-auto">
                    <a href="/src/bag2/Tambah_Mobil.aspx" class="btn btn-secondary w-100" style="border-radius: 10px;">Tambah Data</a>
                </div>
            </div>
            <%-- AKHIR TAMBAH DATA -> MOBIL --%>
        </div>
        <%-- AKHIR BAG KANAN --%>
    </div>

</asp:Content>
