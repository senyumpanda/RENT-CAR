<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag5/Bagian_5.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="RENT_CAR.src.bag5.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Master5" runat="server">

    <div style="height: 95vh;">
        <div class="container-fluid" style="background-color: #F3F3F3;">
            <div class="bungkus-detail" style="background-color: #F3F3F3;">
                <div class="bungkus-luar row mx-auto" style="background-color: white;">
                    <%-- DATA DIRI --%>
                    <div class="col-6 data-diri">
                        <h2>Data Diri</h2>
                        <%-- NAMA --%>
                        <div class="nama">
                            <small>Nama lengkap</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="nama_lengkap" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR NAMA --%>

                        <%-- NOMOR TELEPON --%>
                        <div class="no-telepon">
                            <small>Nomor Telepon</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="no_telp" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR NOMOR TELEPON --%>

                        <%-- NIK --%>
                        <div class="nik">
                            <small>NIK</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="nik" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR NIK --%>

                        <%-- ALAMAT RUMAH --%>
                        <div class="alamat">
                            <small>Alamat Rumah</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="alamat" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR ALAMAT RUMAH --%>
                    </div>
                    <%-- AKHIR DATA DIRI --%>

                    <%-- BARANG SEWA --%>
                    <div class="col-6 barang-sewa">
                        <h2>Mobil Disewa</h2>
                        <%-- MERK MOBIL --%>
                        <div class="merk-mobil">
                            <small>Merk Mobil</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="nama_mobil" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR MERK MOBIL --%>

                        <%-- JUMLAH PENUMPANG --%>
                        <div class="jml-penumpang">
                            <small>Jumlah Penumpang</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="jml_penumpang" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR JUMLAH PENUMPANG --%>

                        <%-- KONSUMSI BAHAN BAKAR --%>
                        <div class="bahan-bakar">
                            <small>Konsumsi Bahan Bakar</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="bahan_bakar" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR KONSUMSI BAHAN BAKAR --%>

                        <%-- DURASI SEWA --%>
                        <div class="durasi-sewa">
                            <small>Durasi Sewa</small>
                            <asp:TextBox CssClass="form-control-plaintext cekout" Text="" ID="durasi_sewa" ReadOnly="true" runat="server" />
                        </div>
                        <%-- AKHIR DURASI SEWA --%>
                    </div>
                    <%-- AKHIR BARANG SEWA --%>

                    <%-- PILIHAN TOMBOL --%>
                    <div class="pil-tombol w-75 mx-auto d-flex justify-content-around">
                        <%-- KEMBALI --%>
                        <div class="kembali">
                            <asp:Button Text="Kembali" ID="kembali" CssClass="btn btn-secondary w-100" runat="server" />
                        </div>
                        <%-- AKHIR KEMBALI --%>

                        <%-- HUBUNGI ADMIN --%>
                        <div class="hubungi-admin">
                            <asp:Button Text="Hubungi Admin" ID="hub_admin" CssClass="btn btn-success w-100" runat="server" OnClick="hub_admin_Click" />
                        </div>
                        <%-- AKHIR HUBUNGI ADMIN --%>
                    </div>
                    <%-- AKHIR PILIHAN TOMBOL --%>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
