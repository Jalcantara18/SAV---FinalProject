using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAV___FinalProject.Ops.Repos;
using SAV___FinalProject.SAVDataModel.Entities;

namespace SAV___FinalProject.Ops.Generic
{
    public interface IGenericRepository<T>
    {
        T Create(T Crear);
        T FindById(int id);
        //Usuarios FindUser(string User, string Password);
        List<T> Getall();
        OperationResult Update(T Actualiza);
        OperationResult Delete(T SoftDelete);

        
    }
}
