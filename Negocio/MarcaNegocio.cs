using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> listado = new List<Marca>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id,Descripcion from MARCAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IdMarca = (int)lector["Id"];
                    aux.NombreMarca = (string)lector["Descripcion"];


                    listado.Add(aux);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conexion.Close();
            }

            return listado;
        }
        public void Agregar(Marca marca)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {

                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into MARCAS (Descripcion) values (@Descripcion) ";
                comando.Parameters.Clear();         
                comando.Parameters.AddWithValue("@Descripcion", marca.NombreMarca);
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }


    }

}
