using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica3.Models
{
    public class Solicitud
    {
         public int Id{get;set;}
        
        public DateTime Fecha {get; set;}


       
        public string Producto {get; set;}

        public double Precio{get; set;}

        public string Categoria{ get; set;}

        public Usuario Usuario{get; set;}

        public int UsuarioId{ get; set;}

        public Solicitud(){
            
            Fecha = DateTime.Now;
        }
    }
}