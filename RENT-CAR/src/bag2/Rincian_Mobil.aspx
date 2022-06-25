<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag2/Bagian_2.Master" AutoEventWireup="true" CodeBehind="Rincian_Mobil.aspx.cs" Inherits="RENT_CAR.src.bag2.Rincian_Mobil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Master2" runat="server">

    <div style="height: 95vh;">
        <div class="container-fluid" style="background-color: #F3F3F3;">
            <div class="bungkus-detail" style="background-color: #F3F3F3;">
                <div class="bungkus-luar row mx-auto" style="background-color: white;">

                    <asp:PlaceHolder ID="rincian_mobil" runat="server"></asp:PlaceHolder>

                    <%-- PILIHAN TOMBOL --%>
                    <div class="pil-tombol w-75 mx-auto d-flex justify-content-around">
                        <%-- KEMBALI --%>
                        <div class="kembali">
                            <button type="button" class="btn btn-secondary w-100">
                                <a href="/src/bag2/Dashboard2.aspx">Kembali</a>
                            </button>
                        </div>
                        <%-- AKHIR KEMBALI --%>

                        <%-- HAPUS DATA --%>
                        <div class="hapus">
                            <asp:Button Text="Hapus" ID="tbl_hapus_data" CssClass="btn btn-danger w-100" runat="server" OnClick="tbl_hapus_data_Click" />
                        </div>
                        <%-- AKHIR HAPUS DATA --%>

                        <%-- UBAH DATA --%>
                        <div class="ubah">
                            <asp:PlaceHolder ID="ubah_data_mobil" runat="server"></asp:PlaceHolder>
                        </div>
                        <%-- AKHIR UBAH DATA --%>
                    </div>
                    <%-- AKHIR PILIHAN TOMBOL --%>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
