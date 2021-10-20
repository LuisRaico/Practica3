using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica3.Controllers;

namespace Practica3.Models
{
    public class Producto
    {
        public int Id{get; set;}

        public string NombreProducto{get; set;}

        public string foto{get; set;}

        public double Precio{get; set;}

        public string Celular{get; set;}

        public Categoria Categoria{get; set;}

        public ICollection<Solicitud> Solicitudes {get; set;}
    }
}