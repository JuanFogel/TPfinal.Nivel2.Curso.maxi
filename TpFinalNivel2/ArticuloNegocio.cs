using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TpFinalNivel2
{
    internal class ArticuloNegocio
    {

        public List<Articulo> listArticulos()
        {
            List<Articulo> articulo = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Nombre, A.Descripcion, A.Codigo, A.ImagenUrl, A.Precio, M.Descripcion Marca, C.Descripcion Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.Id = M.Id and C.Id = A.IdCategoria";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo artaux = new Articulo();
                    artaux.Codigo = (string)lector["Codigo"];
                    artaux.Nombre = (string)lector["Nombre"];
                    artaux.Descripcion = (string)lector["Descripcion"];
                    artaux.ImagenUrl = (string)lector["ImagenUrl"];
                    artaux.Precio = (decimal)lector["Precio"];
                    artaux.Empresa = new Marca();
                    artaux.Empresa.Descripcion = (string)lector["Marca"];
                    artaux.Tecnologia = new Categoria();
                    artaux.Tecnologia.Descripcion = (string)lector["Categoria"];


                    articulo.Add(artaux);

                }


                conexion.Close();
                return articulo;

            }
            catch (Exception ex)
            {

               throw ex;
            }

        }
            





    }
}
