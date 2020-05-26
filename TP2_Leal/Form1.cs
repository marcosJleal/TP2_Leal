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
using System.Security.Cryptography;

namespace TP2_Leal
{
    public partial class Form1 : Form
    {
        List<Articulo> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {

                lista = negocio.listar();

                dgvListado.DataSource = lista;
                dgvListado.Columns[0].Visible = false;
                dgvListado.Columns[1].Visible = false;
                dgvListado.Columns[3].Visible = false;
                dgvListado.Columns[6].Visible = false;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Articulo articulo;
                articulo = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                PbImagen.Load(articulo.URLImagen);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            AltaArticulo agregar = new AltaArticulo();
            agregar.ShowDialog();
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo modificar;
                modificar = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                AltaArticulo agregar = new AltaArticulo(modificar);
                agregar.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
           


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                DialogResult dr = MessageBox.Show("Seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {

                    int id = Convert.ToInt32(((Articulo)dgvListado.CurrentRow.DataBoundItem).IdArticulo);
                    negocio.Eliminar(id);
                    CargarDatos();
                }
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> Busqueda;
            try
            {
                if(txtBuscar.Text=="")
                {
                    dgvListado.DataSource = lista;

                }
                else

                {
                    if (rbtnNombre.Checked == true)
                    {
                        Busqueda = lista.FindAll(b => b.NombreArticulo.ToLower().Contains(txtBuscar.Text.ToLower()));
                        dgvListado.DataSource = Busqueda;
                    }
                    else if(rbtnMarca.Checked==true)
                    {
                        Busqueda = lista.FindAll(b => b.Marca.NombreMarca.ToLower().Contains(txtBuscar.Text.ToLower()));
                        dgvListado.DataSource = Busqueda;
                    }
                    else if(rbtnCategoria.Checked==true)
                    {
                        Busqueda = lista.FindAll(b => b.Categoria.NombreCategoria.ToLower().Contains(txtBuscar.Text.ToLower()));
                        dgvListado.DataSource = Busqueda;


                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo detalles;
                detalles = (Articulo)dgvListado.CurrentRow.DataBoundItem;
                VerDetalles ventana = new VerDetalles(detalles);
                ventana.ShowDialog();
                CargarDatos();


            }
            catch (Exception)
            {

                throw;
            }
           


        }
    }
}
