using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace htmlHelpersFormulario.Models
{
    public class Persona
    {
        [DisplayName("Cedula")]
        [MinLength(10)]
        [Required]
        public string Cedula { get; set; }

        [DisplayName("Nombre")]
        [MinLength(10)]
        [Required]
        public string Nombre { get; set; }

        [DisplayName("Apellido")]
        [MinLength(10)]
        [Required]
        public string Apellido { get; set; }

        [DisplayName("Email")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DisplayName("Clave")]
        [PasswordPropertyText]
        public string Password { get; set; }

        [DisplayName("Edad")]
        [Range(15, 100)]
        public int Edad { get; set; }

        [DisplayName("Estado Civil")]
        public string Estado { get; set; }

        [DisplayName("Carrera")]
        public string Carrera { get; set; }

        [DisplayName("Tel")]
        [Required]
        public string Tel { get; set; }

        [DisplayName("Tiempo Libre")]
        public string[] TiempoLibre { get; set; }

        [DisplayName("Género:")]
        public string Genero { get; set; }
    }
}
