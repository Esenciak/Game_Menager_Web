using Game_Menager.Models;
using Game_Menager_Web.Repository.IRepository;

namespace Game_Menager_Web.Repository
{
    public interface IHeroesRepository : IRepository<Heroes>
    {
        void Update(Heroes obj);
        void Save();

    }
}