namespace WebApplication1.Interfaces
{
    public interface IHouseRepository : IBaseRepository
    {
        IEnumerable<House> GetAll();
        House Get(Guid id);
        void Add(House house);
        void Update(Guid id, House house);
        void Remove(House house);
    }
}
