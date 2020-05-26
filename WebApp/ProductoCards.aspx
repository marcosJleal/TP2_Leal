
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductoCards.aspx.cs" Inherits="WebApp.ProductoCards" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="text-align:center;">Productos</h1>
   
    <div class="card-columns" style="margin: 20px 20px 20px 20px;" >
    <%foreach (var item in listadoArticulos )
        {        %>
    <div class="card text-white bg-dark mb-3" style="width: 18rem;">
  <img src="<% =item.URLImagen %>" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title"><% =item.NombreArticulo %></h5>
    <p class="card-text"><%=item.Descripcion %></p>
      <a href="Carrito.aspx?idart=<% =item.IdArticulo.ToString() %>&cant=<%=txtCantidad.ToString() %>" class="btn btn-primary" >Agregar</a>
      <asp:Label Text="Cantidad" runat="server" CssClass="d-inline p-2 bg-dark text-white" />
      <asp:TextBox runat="server" type="number" ID="txtCantidad" CssClass="d-inline p-2 bg-dark text-white" BorderStyle="Inset" Height="21px" MaxLength="2"  Width="39px"/>|
  </div>
</div>
    <% } %>
    </div>
    <asp:Button Text="Volver" runat="server" ID="btnVolver" OnClick="btnVolver_Click" CssClass="btn btn-dark" />
</asp:Content>
