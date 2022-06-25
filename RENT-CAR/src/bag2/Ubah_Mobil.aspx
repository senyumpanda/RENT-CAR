<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag2/Bagian_2.Master" AutoEventWireup="true" CodeBehind="Ubah_Mobil.aspx.cs" Inherits="RENT_CAR.src.bag2.Ubah_Mobil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Master2" runat="server">

    <div style="height: 95vh;">
        <div class="container-fluid" style="background-color: #F3F3F3;">
            <div class="bungkus-detail" style="background-color: #F3F3F3;">
                <div class="bungkus-luar row mx-auto" style="background-color: white;">
                    <%-- DATA KENDARAAN --%>
                    <div class="col-12 text-center">
                        <h2>Data Kendaraan</h2>
                        <asp:PlaceHolder runat="server" ID="coba"></asp:PlaceHolder>
                    </div>
                    <div class="col-6 data-diri">
                        <%-- NAMA KENDARAAN --%>
                        <div class="nama mb-3">
                            <small>Nama Kendaraan</small>
                            <asp:TextBox class="form-control" ID="nama_kendaraan" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR NAMA KENDARAAN --%>

                        <%-- NOMOR POLISI --%>
                        <div class="no-polisi mb-3">
                            <small>Nomor Polisi</small>
                            <asp:TextBox class="form-control" ID="no_polisi" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR NOMOR POLISI --%>

                        <%-- WARNA --%>
                        <div class="warna mb-3">
                            <small>Warna</small>
                            <asp:TextBox class="form-control" ID="warna_mobil" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR WARNA --%>

                        <%-- Jumlah Penumpang --%>
                        <div class="jml-penumpang mb-3">
                            <small>Jumlah Penumpang</small>
                            <asp:TextBox class="form-control" ID="jumlah_penumpang" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR ALAMAT RUMAH --%>
                    </div>

                    <div class="col-6 barang-sewa">
                        <%-- KONSUMSI BAHAN BAKAR --%>
                        <div class="bahan-bakar mb-3">
                            <small>Konsumsi Bahan Bakar</small>
                            <asp:TextBox class="form-control" ID="bahan_bakar" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR KONSUMSI BAHAN BAKAR --%>

                        <%-- HARGA SEWA /6 JAM --%>
                        <div class="harga-sewa-6 mb-3">
                            <small>Harga Sewa /6 jam</small>
                            <asp:TextBox class="form-control" ID="harga_6" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR HARGA SEWA /6 JAM --%>

                        <%-- HARGA SEWA /12 JAM --%>
                        <div class="harga-sewa-12 mb-3">
                            <small>Harga Sewa /12 jam</small>
                           <asp:TextBox class="form-control" ID="harga_12" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR HARGA SEWA /12 JAM --%>

                        <%-- HARGA SEWA /1 HARI --%>
                        <div class="harga-sewa-1 mb-3">
                            <small>Harga Sewa /1 Hari</small>
                            <asp:TextBox class="form-control" ID="harga_24" AutoCompleteType="Disabled" Text="" runat="server"></asp:TextBox>
                        </div>
                        <%-- AKHIR HARGA SEWA /1 HARI --%>
                    </div>
                    <%-- AKHIR BARANG SEWA --%>

                    <%-- PILIHAN TOMBOL --%>
                    <div class="pil-tombol w-75 mx-auto d-flex justify-content-around">
                        <%-- KEMBALI --%>
                        <div class="kembali">
                            <button type="button" class="btn btn-secondary w-100">
                                <a href="/src/bag2/Dashboard2.aspx">Kembali</a>
                            </button>
                        </div>
                        <%-- AKHIR KEMBALI --%>

                        <%-- UBAH DATA --%>
                        <div class="ubah_data">
                            <asp:Button Text="Ubah Data" ID="tbl_ubah_data" CssClass="btn btn-success w-100" runat="server" OnClick="tbl_ubah_data_Click" />
                        </div>
                        <%-- AKHIR UBAH DATA --%>
                    </div>
                    <%-- AKHIR PILIHAN TOMBOL --%>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
