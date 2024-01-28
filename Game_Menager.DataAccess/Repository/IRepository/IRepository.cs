using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Game_Menager.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Kategoria
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);    // link operator
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
