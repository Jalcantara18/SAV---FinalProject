using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SAV___FinalProject.SAVDataModel.BaseEntity;

namespace SAV___FinalProject.SAVDataModel.Entities
{
    public class Usuarios : BaseEntityClass
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public char Sexo { get; set; }
        public string Rol { get; set; }
        public int Logged { get; set; }
        public List<Alquiler> Alquiler { get; set; }

    }
}
