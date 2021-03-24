using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CalisanTakipDAL.Abstract
{
    public interface IRepository<T> where T:class,new()
    {
        IQueryable<T> GetAll(Expression<Func<T,bool>>filter=null, Func<IQueryable<T>,IOrderedQueryable<T>> 
            orderBy=null,string includeProperties=null); // Database çoklu baglantı olmaması için kullanıldı

        T Get(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);

    }
}
