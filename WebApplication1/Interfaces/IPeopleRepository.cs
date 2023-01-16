namespace WebApplication1.Interfaces
{
    public interface IPeopleRepository : IBaseRepository
    {
        IEnumerable<Human> GetAll();
        Human Get(Guid id);
        void Add(Human human);
        void Update(Guid id, Human human);
        void Remove(Human human);
    }
}
