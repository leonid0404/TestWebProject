using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class HouseRepository : IHouseRepository
    {
        private readonly ApplicationContext _applicationContext;

        public HouseRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public void Add(House house)
        {
            _applicationContext.Houses.Add(house);
        }

        public House Get(Guid id)
        {
            return _applicationContext.Houses.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<House> GetAll()
        {
            return _applicationContext.Houses.ToList();
        }

        public void Remove(House house)
        {
            _applicationContext.Houses.Remove(house);
        }

        public void SaveChanges()
        {
            _applicationContext.SaveChanges();
        }

        public void Update(Guid id, House house)
        {
        }
    }
}
