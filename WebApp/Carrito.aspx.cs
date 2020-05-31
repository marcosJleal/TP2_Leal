using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Carrito : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }
        public List<ItemCarrito> carro;
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArt;

            try
            {
                listaArt = negocio.listar();
                carro = (List<ItemCarrito>)Session[Session.SessionID + "carro"];
                var item = Request.QueryString["idart"];
                //Quitar producto
                var quitar = Request.QueryString["idquitar"];
                if (quitar != null)
                {
                    ItemCarrito carroremover = new ItemCarrito();
                    ItemCarrito remover = carro.Find(J => J.Producto.IdArticulo == int.Parse(quitar));
                    carro.Remove(remover);
                    Session[Session.SessionID + "carro"] = carro;
                }
                else if (item != null)
                {

                    if (carro == null)
                    {
                        carro = new List<ItemCarrito>();
                    }

                    ItemCarrito itemcarro = new ItemCarrito();
                    itemcarro.Producto = new Articulo();

                    articulo = listaArt.Find(J => J.IdArticulo == int.Parse(item));
                    itemcarro.Producto = articulo;
                    itemcarro.Cantidad = 1;
                    itemcarro.Subtotal =itemcarro.Producto.Precio;
                    carro.Add(itemcarro);
                    Session[Session.SessionID + "carro"] = carro;

                }
                else
                {
                    if (carro == null)
                    {
                        carro = new List<ItemCarrito>();
                    }
                }
                decimal total = 0;
                //Acumulador de total
                foreach (var prod in carro)
                {
                    total = prod.Subtotal + total;

                }
                lblTotal.Text ="$"+ total.ToString();

                //Sumar cantidad
                var cant = Request.QueryString["idsumcantidad"];
                if(cant!=null)
                {
                    ItemCarrito sumarcant = carro.Find(J => J.Producto.IdArticulo == int.Parse(cant));
                    sumarcant.Cantidad = sumarcant.Cantidad + 1;
                    sumarcant.Subtotal = sumarcant.Producto.Precio * sumarcant.Cantidad;
                    Session[Session.SessionID + "carro"] = carro;
                }
                //Restar cantidad
                var resta = Request.QueryString["idrestcantidad"];
                if (resta != null)
                {
                    ItemCarrito restarcant = carro.Find(J => J.Producto.IdArticulo == int.Parse(resta));
                    if(restarcant.Cantidad>1)
                    { 
                    restarcant.Cantidad = restarcant.Cantidad - 1;
                    restarcant.Subtotal = restarcant.Producto.Precio * restarcant.Cantidad;
                    Session[Session.SessionID + "carro"] = carro;
                    }
                }



            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }

        }

        protected void btnSeguir_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductoCards.aspx");
        }
    }
}