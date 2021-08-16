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
    public class Vehiculo : BaseEntityClass
    {
        public int TipoTransmisionId { get; set; }
        public TipoTransmision TipoTransmision { get; set; }
        public int TipoCombustibleId { get; set; }
        public TipoCombustible TipoCombustible { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
        public string Chasis{ get; set; }
        public string Placa { get; set; }
        public string Anio { get; set; }
        public string Color { get; set; }
        public string Cilindraje { get; set; }
        public string KilometrosTablero { get; set; }
        public int CantidadPuertas { get; set; }
        public double Precio { get; set; }

    }
}
