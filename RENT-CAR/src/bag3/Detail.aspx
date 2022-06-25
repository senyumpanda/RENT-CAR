<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag3/Bagian_3.Master" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="RENT_CAR.src.bag3.Detail_2" %>

<asp:Content ID="Detail2" ContentPlaceHolderID="Master3" runat="server">

    <div style="height: 95vh;">
        <div class="container-fluid" style="background-color: #F3F3F3; padding: 0; margin: 0;">
            <div class="bungkus-detail" style="background-color: #F3F3F3;">
                <div class="bungkus-luar row" style="background-color: white;">
                    <asp:PlaceHolder ID="data_detail" runat="server"></asp:PlaceHolder>

                    <div class="w-100 mx-auto d-flex justify-content-around w-50 mt-3" style="height: 3rem;">

                        <asp:PlaceHolder ID="pil_tombol" runat="server" />

                        <div class='kembali w-100 mx-4'>
                            <button type='button' class='btn btn-secondary w-100'>
                                <a class="text-white" href='/src/bag2/Dashboard1.aspx'>Kembali</a>
                            </button>
                        </div>

                        <div class='batal w-100 mx-4'>
                            <%--<button type='button' class='btn btn-danger w-100' data-toggle='modal' data-target='#hapus'>
                                Hapus
                            </button>--%>
                            <asp:PlaceHolder ID="akses_batal" runat="server" />

                            <div class="modal fade" id="hapus" data-backdrop="static" data-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                                <div class="modal-dialog modal-dialog-centered">
                                    <div class="modal-content">
                                        <div class="modal-body text-center">
                                            <i class="bi bi-x-circle-fill " style="color: #f80715; font-size: 10rem;"></i>
                                        </div>
                                        <div class="modal-footer">
                                            <button type="button" class="btn btn-secondary w-25" data-dismiss="modal">Kembali</button>
                                            <asp:Button Text="Batal" ID="tbl_hapus" CssClass='btn btn-danger w-25' runat="server" OnClick="tbl_hapus_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class='konfirmasi w-100 mx-4'>
                            <%--<button type="button" class="btn btn-success w-100" data-toggle="modal" data-target="#konfirmasi">
                                Konfirmasi
                            </button>--%>
                            <asp:PlaceHolder ID="akses_konfirmasi" runat="server" />
                            
                            <div class="modal fade" id="konfirmasi" data-backdrop="static" data-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                                <div class="modal-dialog modal-dialog-centered">
                                    <div class="modal-content">
                                        <div class="modal-body text-center">
                                            <i class="bi bi-check-circle-fill" style="color: #0cf353; font-size: 10rem;"></i>
                                        </div>
                                        <div class="modal-footer">
                                            <button type="button" class="btn btn-secondary w-25" data-dismiss="modal">Kembali</button>
                                            <asp:Button Text="Konfirmasi" ID="tbl_konfirmasi" CssClass='btn btn-success w-25' runat="server" OnClick="tbl_konfirmasi_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>

                </div>
            </div>
        </div>
    </div>

    </div>

</asp:Content>
