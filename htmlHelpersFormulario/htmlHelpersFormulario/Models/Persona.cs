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
        public string IdNational { get; set; }

        [DisplayName("Nombre")]
        [MinLength(10)]
        [Required]
        public string Name { get; set; }

        [DisplayName("Apellido")]
        [MinLength(10)]
        [Required]
        public string LastName { get; set; }

        [DisplayName("Correo Electronico")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [DisplayName("Clave")]
        [PasswordPropertyText]
        public string Password { get; set; }

        [DisplayName("Edad")]
        [Range(15, 100)]
        public int Age { get; set; }

        [DisplayName("Estado Civil")]
        public string Status { get; set; }

        [DisplayName("Carrera")]
        public string Career { get; set; }

        [DisplayName("Numero De Telefono")]
        [Required]
        public string PhoneNumber { get; set; }

        [DisplayName("Hobbys")]
        public string[] Hobbys { get; set; }

        [DisplayName("Género:")]
        public string Genero { get; set; }
    }
}
