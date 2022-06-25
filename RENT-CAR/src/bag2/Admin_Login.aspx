<%@ Page Title="" Language="C#" MasterPageFile="~/src/bag2/Bagian_2.Master" AutoEventWireup="true" CodeBehind="Admin_Login.aspx.cs" Inherits="RENT_CAR.src.bag2.Admin_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Master2" runat="server">

    <div style="height: 95vh;">
        <div class="container-fluid mt-3" style="background-color: #F3F3F3;">
            <div class="bungkus-detail" style="background-color: #F3F3F3;">
                <div class="bungkus-luar row mx-auto" style="background-color: white;">
                    <%-- DATA KENDARAAN --%>
                    <div class="col-12 text-center">
                        <h2>ADMIN LOGIN</h2>
                    </div>
                    
                    <div class="col-8 offset-2 isi-data-admin mt-4" style="left: 0px; top: 0px">
                        <%-- USERNAME --%>
                        <div class="nama mb-3">
                            <small>Username</small>
                            <asp:TextBox runat="server" ID="username" CssClass="form-control" AutoCompleteType="Disabled" />
                        </div>
                        <%-- AKHIR USERNAME --%>

                        <%-- PASSWORD --%>
                        <div class="nama mb-3">
                            <small>Password</small>
                            <asp:TextBox runat="server" ID="pass" CssClass="form-control" TextMode="Password" AutoCompleteType="Disabled" />
                        </div>
                        <%-- AKHIR PASSWORD --%>
                    </div>

                    <%-- PILIHAN TOMBOL --%>
                    <div class="pil-tombol w-75 mx-auto d-flex justify-content-around">
                        <%-- KONFIRMASI --%>
                        <div class="ubah">
                            <asp:Button Text="Login" CssClass="btn btn-success w-100" ID="tbl_login" runat="server" OnClick="tbl_login_Click" />
                        </div>
                        <%-- AKHIR KONFIRMASI --%>
                    </div>
                    <%-- AKHIR PILIHAN TOMBOL --%>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
