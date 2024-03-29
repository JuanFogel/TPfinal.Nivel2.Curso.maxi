﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {

        public int IdArticulo { get; set; }
        [DisplayName ("Código")]
        public string Codigo { get; set; }

        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Imagen Url")]
        public string ImagenUrl { get; set; }

  
        public decimal Precio { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }




    }   
}
