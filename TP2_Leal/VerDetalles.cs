using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TP2_Leal
{
    public partial class VerDetalles : Form
    {
       private Articulo articulo = null;
        public VerDetalles()
        {
            InitializeComponent();
        }
        public VerDetalles(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            
        }

     

        private void VerDetalles_Load(object sender, EventArgs e)
        {
            try
            {
                if (articulo == null)
                {
                    MessageBox.Show("nunca llego el objeto");
                }
                else
                {
                    string salida;
                    salida = "Codigo de articulo: " + articulo.CodigoArticulo + "\r\n";
                    salida += "Nombre: " + articulo.NombreArticulo + "\r\n";
                    salida += "Marca: " + articulo.Marca.NombreMarca + "\r\n";
                    salida += "Categoria: " + articulo.Categoria.NombreCategoria + "\r\n";
                    salida += "Precio: " + articulo.Precio + "\r\n";
                    txtboxDetalles.Text = salida;
                    imagen.Load(articulo.URLImagen);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
