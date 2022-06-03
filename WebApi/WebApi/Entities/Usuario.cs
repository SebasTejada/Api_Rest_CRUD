using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class Usuario
    {
        [Key]
        public string id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public int numero_cuenta { get; set; }

    }
}