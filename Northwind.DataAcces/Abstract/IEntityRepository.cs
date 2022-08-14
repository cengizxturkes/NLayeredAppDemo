using Nortwind.Entities.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAcces.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
    }
}
