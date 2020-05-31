<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="WebApp.Producto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form class="form-inline my-2 my-lg-0">
        <asp:TextBox ID="txtBuscar" runat="server" CssClass="form-control mr-sm-2" style="display:inline-block" ></asp:TextBox>
        <button class="btn btn-dark" type="submit"style="display:inline-block">Buscar</button>
    </form>
   
    <h1 class="h1" style="text-align: center;">Productos</h1>
    <a href="/ProductoCards.aspx" class="btn btn-dark">Cards</a>
    <%foreach (var prod in listado)%>
    <%{ %>
    <div class="card">
        <div class="card-header">
            <%=prod.Categoria %>
        </div>
        <div class="card-body">
            <h5 class="card-title"><%=prod.NombreArticulo %></h5>
            <p class="card-text"><%=prod.Descripcion %></p>
            <a href="/ProductoDetalles.aspx?idprod=<%=prod.IdArticulo %>" class="btn btn-primary">Ver detalles</a>
            <p class="d-inline p-2 bg-dark text-white">$ <%=prod.Precio.ToString() %></p>
        </div>
    </div>
    <%} %>
    <asp:Button Text="Volver" runat="server" ID="btnVolver" class="btn btn-dark" OnClick="btnVolver_Click" />
</asp:Content>







