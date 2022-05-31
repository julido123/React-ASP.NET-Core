using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiUsuarios.Models
{
    [Table("usuarios")]
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public String apellidos { get; set; }
        public String nombre { get; set; }
        public String correo { get; set; }
        public String username { get; set; }
        public String password { get; set; }






    }
}
