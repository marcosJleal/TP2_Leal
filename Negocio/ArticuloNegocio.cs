using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listado = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Id,a.Codigo,a.Nombre,a.Descripcion,a.IdMarca,a.IdCategoria,a.ImagenUrl,a.Precio,m.Descripcion as 'Marca',c.Descripcion as 'Categoria' from ARTICULOS as a inner join MARCAS as m on m.Id=a.IdMarca inner join CATEGORIAS as c on c.Id=a.IdCategoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)lector["Id"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.NombreArticulo = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.URLImagen = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.IdMarca = (int)lector["IdMarca"];
                    aux.Marca.NombreMarca = (string)lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (int)lector["IdCategoria"];
                    aux.Categoria.NombreCategoria = (string)lector["Categoria"];


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

        public void Eliminar(int id)
        {

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "DELETE from ARTICULOS where id=" + id; ;
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

        public void Agregar(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {

                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio) ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", articulo.CodigoArticulo);
                comando.Parameters.AddWithValue("@Nombre", articulo.NombreArticulo);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.IdMarca);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.IdCategoria);
                comando.Parameters.AddWithValue("@ImagenUrl", articulo.URLImagen);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);
               
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

        public void Modificar(Articulo articulo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {

                conexion.ConnectionString = "data source = DESKTOP-BDJOUS3\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security= sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "update ARTICULOS set Codigo=@Codigo,Nombre=@Nombre,Descripcion=@Descripcion,IdMarca=@IdMarca,IdCategoria=@IdCategoria,ImagenUrl=@ImagenUrl,Precio=@Precio where Id=@IdArticulo ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", articulo.CodigoArticulo);
                comando.Parameters.AddWithValue("@IdArticulo", articulo.IdArticulo);
                comando.Parameters.AddWithValue("@Nombre", articulo.NombreArticulo);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.IdMarca);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.IdCategoria);
                comando.Parameters.AddWithValue("@ImagenUrl", articulo.URLImagen);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);

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

