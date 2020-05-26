using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace WebApp
{
    public partial class ProductoCards : System.Web.UI.Page
    {
       public List<Articulo> listadoArticulos;
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listadoArticulos = negocio.listar();
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Producto.aspx");

        }

        
    }
}