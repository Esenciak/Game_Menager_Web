using Game_Menager.Models;
using Game_Menager.DataAccess.Repository.IRepository;

namespace Game_Menager.DataAccess.Repository
{
    public interface IHeroesRepository : IRepository<Heroes>
    {
        void Update(Heroes obj);
        void Save();

    }
}