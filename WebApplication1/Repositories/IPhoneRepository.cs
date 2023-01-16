using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class IPhoneRepository : IIPhoneRepository
    {
        private readonly ApplicationContext _applicationContext;

        public IPhoneRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public IEnumerable<IPhone> GetAll()
        {
            return _applicationContext.Phones;
        }
        public IPhone? Get(Guid id)
        {
            return _applicationContext.Phones.FirstOrDefault(x => x.Id == id);
        }
        public void Create(IPhone phone)
        {
            _applicationContext.Phones.Add(phone);
        }
        public void Remove(IPhone phone)
        {
            _applicationContext.Phones.Remove(phone);
        }
        public void SaveChanges()
        {
            _applicationContext.SaveChanges();
        }
    }
}
