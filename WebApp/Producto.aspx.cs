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
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio=new ArticuloNegocio();

            GVProducto.DataSource = negocio.listar();
            GVProducto.DataBind();

            
        }

        protected void btnCards_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductoCards.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
    }