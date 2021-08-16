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
    public class Modelo : BaseEntityClass
    {
        public List<Vehiculo> Vehiculos { get; set; }//Todos los vehiculos que hagan Match con el nombre
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }//Desde la clase de marca
        public string Nombre { get; set; }
    }
}
