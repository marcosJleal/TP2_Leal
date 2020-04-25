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
    public partial class NuevaMarca : Form
    {
        public NuevaMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio marcaneg = new MarcaNegocio();
            try
            {
                marca.NombreMarca = txtNombre.Text;
                marcaneg.Agregar(marca);
                Dispose();

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
