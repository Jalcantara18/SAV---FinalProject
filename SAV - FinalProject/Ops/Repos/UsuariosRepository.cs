using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAV___FinalProject.SAVDataModel.Entities;
using SAV___FinalProject.SAVDataModel.SAVContext;
using SAV___FinalProject.SAVDataModel.BaseEntity;
using System.Data.Entity;

namespace SAV___FinalProject.Ops.Repos
{
    
    public class UsuariosRepository:GenericRepository<Usuarios>
    {
        private SAVDBContext _Mycontext;
        private DbSet<Usuarios> _set;

        public UsuariosRepository()
        {
            _Mycontext = new SAVDBContext();
            _set = _Mycontext.Set<Usuarios>();
        }
        public Usuarios FindUser(string User, string Password)
        {
            return _set.FirstOrDefault(x => x.Username == User && x.Password == Password);
        }
    }
}
