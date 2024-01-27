using Game_Menager_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Menager_Web.Repository.IRepository
{
    public interface IHeroesRepository : IRepository<Heroes> //na co mamy zamienione "Category"?
    {
        void Update(Heroes obj);
        void Save();
    }
}
