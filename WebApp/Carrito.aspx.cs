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
        protected void Page_Load(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArt;
            List<ItemCarrito> carrito = new List<ItemCarrito>();
            try
            {
                ItemCarrito itemcarro = new ItemCarrito();
                listaArt = negocio.listar();
                var item = Convert.ToInt32(Request.QueryString["idart"]);
                articulo = listaArt.Find(J => J.IdArticulo==item);
                var cant = Convert.ToInt32(Request.QueryString["cant"]);
                itemcarro.Producto = articulo;
                itemcarro.Cantidad = cant;
                carrito.Add(itemcarro);
                GVCarrito.DataSource = carrito;
                GVCarrito.DataBind();

                
               // lblCant.Text = lblCant.Text + Session[Session.SessionID + "producto"].ToString();
               

            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }
          
        }
    }
}