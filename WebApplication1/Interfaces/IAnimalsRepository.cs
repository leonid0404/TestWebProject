namespace WebApplication1.Interfaces
{
    public interface IAnimalsRepository : IBaseRepository
    {
        public IEnumerable<Animal> GetAll();
        public Animal? Get(int id);
        public void Create(Animal animal);
        public void Remove(Animal animal);
    }
}
