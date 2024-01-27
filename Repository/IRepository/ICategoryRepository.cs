using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Menager_Web.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category> //na co mamy zamienione "Category"?
    {
        void Update(Category obj);
        void Save();
    }
}
