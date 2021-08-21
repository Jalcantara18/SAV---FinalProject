using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAV___FinalProject.Ops.Generic;
using System.Data.Entity;
using SAV___FinalProject.SAVDataModel.SAVContext;
using SAV___FinalProject.SAVDataModel.BaseEntity;

namespace SAV___FinalProject.Ops.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntityClass
    {
        private SAVDBContext _Mycontext;
        private DbSet<T> _set;

        public GenericRepository()
        {
            _Mycontext = new SAVDBContext();
            _set = _Mycontext.Set<T>();
        }

        public T Create(T Crear)
        {
            _set.Add(Crear);
            _Mycontext.SaveChanges();
            return Crear;
        }

        public OperationResult Delete(T SoftDelete)
        {
            _Mycontext.Entry(SoftDelete).State = EntityState.Modified;
            SoftDelete.Borrado = true;
            SoftDelete.FechaModificacion = DateTime.Today;
            _Mycontext.SaveChanges();

            return new OperationResult() { Success = true };
        }

    

    public T FindById(int id)
        {
        return _set.FirstOrDefault(x => x.Id == id);
    }

        public T FindUser(string User, string Password)
        {
            throw new NotImplementedException();
        }

        public List<T> Getall()
        {
            return _set.Where(x => x.Borrado == false).ToList();
        }

        public OperationResult Update(T Actualiza)
        {
            _Mycontext.Entry(Actualiza).State = EntityState.Modified;

            _Mycontext.SaveChanges();

            return new OperationResult() { Success = true };
        }
     }
}

