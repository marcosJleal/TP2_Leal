using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
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
                if(quitar!=null)
                {
                    ItemCarrito carroremover = new ItemCarrito();
                   ItemCarrito remover = carro.Find(J => J.Producto.IdArticulo == int.Parse(quitar));
                    carro.Remove(remover);
                    Session[Session.SessionID + "carro"] = carro;
                }
                else if(item!=null )
                { 

                if(carro==null)
                {
                    carro = new List<ItemCarrito>(); 
                }

                ItemCarrito itemcarro = new ItemCarrito();
                itemcarro.Producto = new Articulo();
               
                articulo = listaArt.Find(J => J.IdArticulo==int.Parse(item));
                itemcarro.Producto = articulo;
                itemcarro.Cantidad = 1;
                    itemcarro.Subtotal = itemcarro.Cantidad * itemcarro.Producto.Precio;
                carro.Add(itemcarro);
                Session[Session.SessionID+"carro"]= carro;
                    
                }
                else
                {
                    if (carro == null)
                    {
                        carro = new List<ItemCarrito>();
                    }
                }
                //repetidor.DataSource = carro;
                //repetidor.DataBind();

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