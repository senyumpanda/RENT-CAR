<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag4/Bagian_4.Master" AutoEventWireup="true" CodeBehind="Data_Diri_Customer.aspx.cs" Inherits="RENT_CAR.src.bag4.Data_Diri_Customer" %>

<asp:Content ID="Data_Customer" ContentPlaceHolderID="Master4" runat="server">

    <div style="height: 95vh;">
        <div class="container-fluid" style="background-color: #F3F3F3;">
            <div class="bungkus-detail" style="background-color: #F3F3F3;">
                <div class="bungkus-luar row mx-auto" style="background-color: white;">
                    <%-- DATA KENDARAAN --%>
                    <div class="col-12 text-center" style="margin-top: -2.5rem;">
                        <h2>Data Diri</h2>
                    </div>

                    <div class="col-8 offset-2 isi-data-admin">
                        <%-- NAMA LENGKAP --%>
                        <div class="nama-lengkap mb-3">
                            <small>Nama Lengkap</small>
                            <asp:TextBox ID="nama_lengkap" CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                        </div>
                        <%-- AKHIR NAMA LENGKAP --%>

                        <%-- NO TELEPON --%>
                        <div class="no-telepon mb-3">
                            <small>Nomor Telepon</small>
                            <asp:TextBox ID="no_telepon" CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                        </div>
                        <%-- AKHIR NO TELEPON --%>

                        <%-- NIK --%>
                        <div class="nik mb-3">
                            <small>NIK</small>
                            <asp:TextBox ID="nik" CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                        </div>
                        <%-- AKHIR NIK --%>

                        <%-- ALAMAT RUMAH --%>
                        <div class="alamat mb-3">
                            <small>Alamat</small>
                            <asp:TextBox ID="alamat" CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                        </div>
                        <%-- AKHIR ALAMAT RUMAH --%>

                        <%-- DURASI SEWA --%>
                        <div class="durasi-sewa mb-3">
                            <small>Durasi Sewa</small>
                            <asp:TextBox ID="sewa" CssClass="form-control" AutoCompleteType="Disabled" runat="server" />
                        </div>
                        <%-- AKHIR DURASI SEWA --%>
                    </div>

                    <%-- PILIHAN TOMBOL --%>
                    <div class="pil-tombol w-75 mx-auto d-flex justify-content-around" style="margin-top: -2rem;">
                        <%-- KONFIRMASI --%>
                        <div class="konfirmasi">
                            <asp:Button Text="Sewa" ID="konfirmasi" CssClass="btn btn-success w-100" runat="server" OnClick="konfirmasi_Click" />
                        </div>
                        <%-- AKHIR KONFIRMASI --%>
                    </div>
                    <%-- AKHIR PILIHAN TOMBOL --%>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
