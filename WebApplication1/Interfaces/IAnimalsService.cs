namespace WebApplication1.Interfaces
{
    public interface IAnimalsService
    {
        IEnumerable<Animal> GetAll();
        Animal? Get(int id);
        void Create(Animal animal);
        void Update(int id, Animal animal);
        void Remove(int id);
    }
}
