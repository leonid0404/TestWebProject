using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class AnimalsRepository : IAnimalsRepository 
    {
        private readonly ApplicationContext _applicationContext;

        public AnimalsRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IEnumerable<Animal> GetAll()
        {
            return _applicationContext.Animals;
        }
        public Animal? Get(int id)
        {
            return _applicationContext.Animals.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Animal animal)
        {
            _applicationContext.Animals.Add(animal);
        }
        public void Remove(Animal animal)
        {
            _applicationContext.Animals.Remove(animal);
        }
        public void SaveChanges()
        {
            _applicationContext.SaveChanges();
        }
    }
}
