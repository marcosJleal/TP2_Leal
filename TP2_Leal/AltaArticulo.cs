using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TP2_Leal
{
    public partial class AltaArticulo : Form
    {
        private Articulo articulo=null;
        public AltaArticulo()
        {
            InitializeComponent();
        }
        public AltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;

        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            cargar();
            
        }

        private void cargar()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio cat = new CategoriaNegocio();
            try
            {
                cmbCategoria.DataSource = cat.listar();
                cmbMarca.DataSource = marca.listar();
                cmbCategoria.DisplayMember = "NombreCategoria";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbMarca.DisplayMember = "NombreMarca";
                cmbMarca.ValueMember = "IdMarca";

                if (articulo!=null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.URLImagen;
                    txtNombre.Text = articulo.NombreArticulo;
                    txtPrecio.Text = Convert.ToString(articulo.Precio);
                    cmbCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    cmbMarca.SelectedValue = articulo.Marca.IdMarca;





                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulonegocio = new ArticuloNegocio();
           

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                    articulo.NombreArticulo = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.CodigoArticulo = txtCodigo.Text;
                decimal p = Convert.ToDecimal(txtPrecio.Text);
                articulo.Precio =  p;
                articulo.URLImagen = txtImagen.Text;
                articulo.Marca = (Marca)cmbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbCategoria.SelectedItem;
              
                
               if(articulo.IdArticulo==null)
                {

                    articulonegocio.Agregar(articulo);
                }
               else
                {
                    articulonegocio.Modificar(articulo);
                    
                }

                Dispose();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            NuevaMarca nuevo = new NuevaMarca();
            nuevo.ShowDialog();
            cargar();

        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            NuevaCategoria cat = new NuevaCategoria();
            cat.ShowDialog();
            cargar();
        }
    }
}
