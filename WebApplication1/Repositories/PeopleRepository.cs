using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly ApplicationContext _applicationContext;

        public PeopleRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IEnumerable<Human> GetAll()
        {
            return _applicationContext.People;
        }
        public Human Get(Guid id)
        {
            return _applicationContext.People.FirstOrDefault(x => x.Id == id);
        }
        public void Add(Human human)
        {
            _applicationContext.People.Add(human);
        }
        public void Update(Guid id, Human human)
        {
        }
        public void Remove(Human human)
        {
            _applicationContext.People.Remove(human);
        }
        public void SaveChanges()
        {
            _applicationContext.SaveChanges();
        }
    }
}
