using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> listado = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Id,Descripcion from CATEGORIAS";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCategoria = (int)lector["Id"];
                    aux.NombreCategoria=(string)lector["Descripcion"];


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


        public void Agregar(Categoria categoria)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {

                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into CATEGORIAS (Descripcion) values (@Descripcion) ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Descripcion", categoria.NombreCategoria);
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
