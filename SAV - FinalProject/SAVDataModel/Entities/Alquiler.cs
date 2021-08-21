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
    public class Alquiler : BaseEntityClass
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int VehiculoId{ get; set; }
        public Vehiculo Vehiculo { get; set; }
        public string MetodoPago { get; set; }
        public double Costo { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public double Penalidad { get; set; }
        public int AtendidoPorId { get; set; }
        public Usuarios AtendidoPor { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
