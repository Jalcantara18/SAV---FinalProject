using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAV___FinalProject.Ops.Repos;

namespace SAV___FinalProject.Ops.Generic
{
    public interface IGenericRepository<T>
    {
        T Create(T Crear);
        T FindById(int id);
        T FindUser(string User, string Password);
        List<T> Getall();
        OperationResult Update(T Actualiza);
        OperationResult Delete(T SoftDelete);

        
    }
}
