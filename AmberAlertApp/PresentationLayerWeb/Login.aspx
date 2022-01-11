<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentationLayerWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" style="text-align:center;>
    <section id="main-content"> 
        <section id="wrapper">

            <div class="row">
                <div class="col-lg-12">
                    <section class="panel text-center">
                        <header class="panel-heading">
                            <div class="col-md-12 col-md-offset-4 my-2 pb-4">
                                <h2 class="font-weight-bolder">Police Login</h2>
                            </div>
                        </header>


                        <div class="panel-body" style="border:30px solid #444; display: grid; justify-items:center; align-items:center; background-color:#c7dcff">
                            
                            <div class="row">
                                <div class="col-md-12 col-md-offset-1 pb-2">
                                    <div class="form-group" style="font-weight:650;">
                                        <asp:Label Text="User Name" runat="server"/>
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="User Name"/>
                                    </div>
                                </div>

                            </div>
                              <div class="row">
                                <div class="col-md-12 col-md-offset-1 pb-2">
                                    <div class="form-group" style="font-weight:650;">
                                        <asp:Label Text="Password" runat="server"/>
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Password"/>
                                    </div>
                                </div>
                            </div>
                              <div class="row">
                                <div class="col-md-12 col-md-offset-1 pb-2">
                                    <div class="form-group" style="font-weight:650;">
                                        <asp:Label Text="Police Badge Number" runat="server" class="my-2"/>
                                        <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" placeholder="Police Badge Number"/>
                                    </div>
                                </div>
                            </div>

                               <div class="row">
                                <div class="col-md-12 col-md-offset-1 pb-2">
                                    <asp:Button runat="server" Text="Log in" ID="btnlogin" CssClass="btn btn-success" Width="200px" />
                                </div>
                            </div>

                        </div>

                    </section>
                </div>
            </div>
        </section>
    </section>
        </div>

</asp:Content>


