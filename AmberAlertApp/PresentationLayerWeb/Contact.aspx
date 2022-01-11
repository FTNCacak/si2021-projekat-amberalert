<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PresentationLayerWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>You noticed something suspicious,<br /> you think you saw a missing person, contact us</h3>
    <address>
        Main department<br />
        st, Svetog Save 65<br />
        <abbr title="Phone">Phone:</abbr>
        +381677021469
    </address>
    
        <p>if you are not sure if you have seen a missing person, you have not been able to identify him, contact us, send us your current coordinates and we will send a patrol.</p>
    

    <address>
        <strong>Support:</strong>   <a href="mailto:amberalert@gmail.com">amberalert@gmail.com</a><br />
    </address>
</asp:Content>
