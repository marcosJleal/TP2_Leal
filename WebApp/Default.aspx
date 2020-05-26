<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Catalogo</h1>
        <p class="lead">Bienvenidos al catalogo online.</p>
        <p><a href="#" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2 class="h2">Futuro e-commerce</h2>
            <p class="lead">
               Nuevo catalogo de productos diseñado con el fin de satisfacer las
                necesidades de cualquier cliente.

            </p>
            <p class="lead">
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2 class="h2">Venta</h2>
            <p class="lead">
               Gracias a esta web conseguiras aumentar tus ventas de manera online a tan solo un click !
            </p>
            <p class="lead">
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2 class="h2">Stock</h2>
            <p class="lead">
                Mantene visualmente tu stock hacia el publico !
            </p>
            <p class="lead">
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
