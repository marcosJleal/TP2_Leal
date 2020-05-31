using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class ProductoDetalles : System.Web.UI.Page
    {
        public Articulo prodDetalle { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listado;
            try
            {
                listado = negocio.listar();
                var prod = Request.QueryString["idprod"];
                prodDetalle = listado.Find(J => J.IdArticulo == int.Parse(prod));

            }
            catch (Exception)
            {

                Response.Redirect("Error.aspx");
            }
           

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx");
        }
    }
}