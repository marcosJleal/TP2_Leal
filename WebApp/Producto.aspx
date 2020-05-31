<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="WebApp.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="h1" style="text-align:center;">Producto</h1>
    <a href="/ProductoCards.aspx" class="btn btn-dark">Cards</a>
    <asp:GridView runat="server" ID="GVProducto" CssClass="table table-dark"></asp:GridView>
    <asp:Button Text="Volver" runat="server" ID="btnVolver" class="btn btn-dark" OnClick="btnVolver_Click" />
    

    

</asp:Content>



       



