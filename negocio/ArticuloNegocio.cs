using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using accesodatos;

namespace negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> listArticulos()
        {
            List<Articulo> articulo = new List<Articulo>();
            DataBase datos = new DataBase();

            try
            {

                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, C.Descripcion Categoria, M.Descripcion Marca, ImagenUrl, A.IdCategoria, A.IdMarca, Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where IdMarca = M.id and IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo artaux = new Articulo();
                    artaux.IdArticulo = (int)datos.Lector["Id"];
                    artaux.Codigo = (string)datos.Lector["Codigo"];
                    artaux.Nombre = (string)datos.Lector["Nombre"];
                    artaux.Descripcion = (string)datos.Lector["Descripcion"];
                    artaux.Marca = new Marca();
                    artaux.Marca.DescripcionMarca = (string)datos.Lector["Marca"];
                    artaux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    artaux.Categoria = new Categoria();
                    artaux.Categoria.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    artaux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        artaux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        artaux.Precio = (decimal)datos.Lector["Precio"];

                    articulo.Add(artaux);
                }

                return articulo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void agregarArticulo(Articulo nuevo)
        {
            DataBase datos = new DataBase();

            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion, IdCategoria,IdMarca, ImagenUrl, Precio) values(@Codigo,@Nombre,@Descripcion,@IdCategoria,@IdMarca,@ImagenUrl,@Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.IdCategoria);
                datos.setearParametro("@IdMarca", nuevo.Marca.IdMarca);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public void modificarArticulo(Articulo modificar)
        {
            DataBase datos = new DataBase();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @IdMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@imagenUrl", modificar.ImagenUrl);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@idMarca", modificar.Marca.IdMarca);
                datos.setearParametro("@idCategoria", modificar.Categoria.IdCategoria);
                datos.setearParametro("@id", modificar.IdArticulo);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        
        }

        public void eliminar(int Id)
        {
                DataBase datos = new DataBase();
            try
            {               
                datos.setearConsulta("delete from ARTICULOS where Id=" + Id);
                datos.setearParametro("@IdArticulo", Id);
                datos.ejecutarAccion();             
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            DataBase datos = new DataBase();

            try
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, C.Descripcion Categoria, M.Descripcion Marca, ImagenUrl, Precio, A.IdCategoria, A.IdMarca from ARTICULOS A, CATEGORIAS C, MARCAS M where M.id = A.IdMarca and C.Id = A.IdCategoria And ";

                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio >" + filtro;
                                break;
                            case "Menor a":
                                consulta += "Precio <" + filtro;
                                break;
                            default:
                                consulta += "Precio =" + filtro;
                            break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Nombre like '%" + filtro + "%' ";
                            break;
                        }
                        break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "M.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "M.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "M.Descripcion like '%" + filtro + "%' ";
                            break;
                        }
                        break;
                    default:
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "C.Descripcion like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += "C.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "C.Descripcion like '%" + filtro + "%' ";
                            break;
                        }
                        break;
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo artaux = new Articulo();
                    artaux.IdArticulo = (int)datos.Lector["Id"];
                    artaux.Codigo = (string)datos.Lector["Codigo"];
                    artaux.Nombre = (string)datos.Lector["Nombre"];
                    artaux.Descripcion = (string)datos.Lector["Descripcion"];
                    artaux.Marca = new Marca();
                    artaux.Marca.DescripcionMarca = (string)datos.Lector["Marca"];
                    artaux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    artaux.Categoria = new Categoria();
                    artaux.Categoria.DescripcionCategoria = (string)datos.Lector["Categoria"];
                    artaux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        artaux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    if (!(datos.Lector["Precio"] is DBNull))
                        artaux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(artaux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }        
        }

        
    }
    
}
