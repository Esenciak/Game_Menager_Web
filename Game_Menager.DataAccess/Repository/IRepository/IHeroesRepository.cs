using Game_Menager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Menager.DataAccess.Repository.IRepository
{
    public interface IHeroesRepository : IRepository<Heroes> //na co mamy zamienione "Category"?
    {
		IEnumerable<Heroes> GetHeroesForUser(string user);
		void Update(Heroes obj);
        void Save();
    }
}
