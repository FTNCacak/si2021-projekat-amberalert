<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MissingPeople.aspx.cs" Inherits="PresentationLayerWeb.MissingPeople" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3 class="text-info text-center my-3">Welcome to the Amber Alert Finding Missing People Page</h3>

    <div class="container" style="text-align:center;">
    <section id="main-content"> 
        <section id="wrapper">


            <div class="row">
                <div class="col-lg-12">
                    <section class="panel text-center">
                        <header class="panel-heading">
                            <div class="col-md-12 col-md-offset-4 my-2 pb-4">
                                <h2 class="font-weight-bolder">Report person you find</h2>
                            </div>
                        </header>

                        <div style="border: 4px dotted #f08c00 ">
                        <div class="panel-body" style="border:30px solid #4c4c4c; display: grid; justify-items:center; align-items:center; background-color:#000000;">
                        <img src="img/logo.png" class="rounded float-left my-2" alt="Amber Alert logo" width="100" height="75">
                        <img src="img/AmberAlert.png" class="img-thumbnail my-3" alt="Amber Alert" >
                            <asp:Label Text="Lista Nestalih ljudi" runat="server" style="font-size: 30px; color:white; font-weight:500;"/>
                            <asp:ListBox ID="ListBoxMissingPeople" runat="server" Height="275px" Width ="300px" OnSelectedIndexChanged="ListBoxMissingPeople_SelectedIndexChanged"></asp:ListBox>

                               <div class="row">
                                <div class="col-md-12 col-md-offset-1 my-3 pb-2">
                                    <asp:Button runat="server" Text="Get All Missing People" ID="btnget" CssClass="btn btn-info" Width="200px" OnClick="btnget_Click" />
                                </div>
                                   <div class="col-md-12 col-md-offset-1 pb-4">
                                    <asp:Button runat="server" Text="Delete" ID="btndelete" CssClass="btn btn-danger" Width="200px" OnClick="btndelete_Click" />
                                </div>
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
