using dealer1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealer1.Datamodel
{
    public interface idealer<T>
    {
        T create(T entity);
        IQueryable<T> GetAll();
        T findbyid(int id);
        Operationresult update(T entity);
        Operationresult delete(T entity);
    }
}
