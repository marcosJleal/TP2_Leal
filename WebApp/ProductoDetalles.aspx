<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductoDetalles.aspx.cs" Inherits="WebApp.ProductoDetalles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="card" style="width: 40rem;">
  <img src="<%=prodDetalle.URLImagen %>" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title"><%=prodDetalle.NombreArticulo %></h5>
    <p class="card-text"><%=prodDetalle.Descripcion %></p>
  <a href="Carrito.aspx?idart=<% =prodDetalle.IdArticulo.ToString() %>" class="btn btn-primary">Agregar al carro</a>
    <p class="d-inline p-2 bg-dark text-white">$ <%=prodDetalle.Precio.ToString() %></p>
  </div>
</div>
    <a href="/Producto.aspx" class="btn btn-dark">Volver</a>
</asp:Content>
