using System;
using System.Collections.Generic;
//necesario realizar el usung de DataAnnotations
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidacionesMVC.Models
{
    public class Usuario
    {
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [RegularExpression("[a-zA-Z]{2,20}",ErrorMessage ="Solo admite letras entre 2 y 20")]
        public String Nombre{ get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [RegularExpression("[a-zA-Z]{2,20}", ErrorMessage = "Solo admite letras entre 2 y 20")]
        public String Apellido { get; set; }

        [RegularExpression("[0-9]{2}",ErrorMessage ="Solo numeros")]
        [Range(18,99,ErrorMessage ="La edad debe estar comprendida entre 18 y 99 años")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage ="No tiene el formato de email")]
        public String Correo { get; set; }

        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        public String NombreUsuario{ get; set; }

        [Required(ErrorMessage = "La password es obligatorio")]
        [DataType(DataType.Password)]
        public String PassWord{ get; set; }

        [Required(ErrorMessage = "El password2 es obligatorio")]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage ="Las password no coinciden")]
        public String PassWord2{ get; set; }

    }
}