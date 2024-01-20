using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using accesodatos;


namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> listar()
        {

            List<Marca> lista  = new List<Marca>();
            DataBase datos = new DataBase();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.IdMarca = (int)datos.Lector["Id"];
                    aux.DescripcionMarca = (string)datos.Lector["Descripcion"];

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
                datos.cerrarConexion();
            }





        }







    }
}
