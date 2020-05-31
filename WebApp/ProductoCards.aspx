<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductoCards.aspx.cs" Inherits="WebApp.ProductoCards" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form class="form-inline my-2 my-lg-0">
        <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control mr-sm-2" style="display:inline-block" ></asp:TextBox>
        <button class="btn btn-dark" type="submit"style="display:inline-block">Buscar</button>
    </form>
    <h1 style="text-align: center;">Productos</h1>
    <a href="/Producto.aspx" class="btn btn-dark">Lista</a>

    <div class="card-columns" style="margin: 20px 20px 20px 20px;">
        <%foreach (var item in listadoArticulos)
            {        %>
        <div class="card text-white bg-dark mb-3" style="width: 18rem;">
            <img src="<% =item.URLImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><% =item.NombreArticulo %></h5>
                <p class="card-text"><%=item.Descripcion %></p>
                <a href="Carrito.aspx?idart=<% =item.IdArticulo.ToString() %>" class="btn btn-primary">Agregar</a>
                <p class="d-inline p-2 bg-dark text-white">$ <%=item.Precio.ToString() %></p>
            </div>
        </div>
        <% } %>
    </div>
    <asp:Button Text="Volver" runat="server" ID="btnVolver" OnClick="btnVolver_Click" CssClass="btn btn-dark" />
</asp:Content>
