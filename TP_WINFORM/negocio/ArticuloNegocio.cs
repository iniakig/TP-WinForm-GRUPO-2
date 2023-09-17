using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //datos.SetearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion As Marca, IsNull (C.Descripcion, 'Sin categorizar') As Categoria, A.Precio\r\nFrom ARTICULOS As A\r\nLeft Join MARCAS As M\r\n\tOn A.IdMarca = M.Id\r\nLeft Join CATEGORIAS As C\r\n\tOn A.IdCategoria = C.Id");
                datos.SetearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion As Marca, IsNull (C.Descripcion, 'Sin categorizar') As Categoria, A.Precio As Precio, I.ImagenUrl As UrlImagen\r\nFrom ARTICULOS As A \r\n\tLeft Join MARCAS As M On A.IdMarca = M.Id \r\n\tLeft Join CATEGORIAS As C On A.IdCategoria = C.Id\r\n\tjoin IMAGENES As I On I.IdArticulo = A.Id");

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Nombre = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagen"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta("delete from ARTICULOS WHERE Id=@id");
                datos.setearParametro("@id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
