using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Practica3.Controllers;

namespace Practica3.Models
{
    public class Usuario
    {
        public int Id{get; set;}
        [Required]
        public string Nombre{get; set;}

        [Required]
        public string Celular{get; set;}

        

     
        public ICollection<Solicitud> Solicitudes {get; set;}
    }
}