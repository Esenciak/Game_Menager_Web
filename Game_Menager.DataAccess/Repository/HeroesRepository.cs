using Game_Menager.DataAccess.Data;
using Game_Menager.Models;
using Game_Menager.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Game_Menager.DataAccess.Repository.IRepository;

namespace Game_Menager.DataAccess.Repository
{
    public class HeroesRepository : Repository<Heroes>, IHeroesRepository
    {
        private ApplicationDbContext _db;

        public HeroesRepository(ApplicationDbContext db) : base(db) // dajemy do wszystkich podstawowych klas
        {
            _db = db;
        }

		public  IEnumerable<Heroes> GetHeroesForUser(string Id)
		{
			return _db.Heroes.Where(h => h.Name == Id).ToList();
		}


		public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Heroes obj)
        {
            _db.Heroes.Update(obj);
        }
    }
}
