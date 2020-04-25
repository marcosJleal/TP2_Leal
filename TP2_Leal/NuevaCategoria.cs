using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP2_Leal
{
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio neg = new CategoriaNegocio();
            Categoria cat = new Categoria();
            try
            {
                cat.NombreCategoria = txtNombre.Text;
                neg.Agregar(cat);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }

    }
}
