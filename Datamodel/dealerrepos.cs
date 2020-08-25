using dealer1.Context;
using dealer1.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealer1.Datamodel
{
    public class dealerrepos<T> : idealer<T> where T : entidadbase
    {
        dealercontext dbcontext;
        DbSet<T> Set;
        public dealerrepos()
        {
            dbcontext = new dealercontext();
            Set = dbcontext.Set<T>();
        }
        public T create(T entity)
        {
            dbcontext.Set<T>().Add(entity);
            dbcontext.SaveChanges();
            return entity;
        }

        public Operationresult delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T findbyid(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Operationresult update(T entity)
        {
            throw new NotImplementedException();
        }

     
    }
}
