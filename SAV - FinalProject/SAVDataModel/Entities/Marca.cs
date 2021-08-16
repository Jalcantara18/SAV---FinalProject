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
    public class Marca : BaseEntityClass
    {
        public string Nombre { get; set; }
        public List<Modelo> Modelo { get; set; }
    }
}
