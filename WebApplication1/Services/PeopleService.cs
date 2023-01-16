using WebApplication1.Interfaces;
using WebApplication1.Models.IncomeModels.PeopleModels;
using WebApplication1.Models.ViewModels.PeopleModels;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        public IEnumerable<HumanViewModel> GetAll()
        {
            return _peopleRepository.GetAll().Select(x => new HumanViewModel()
            {
                Age = x.Age,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Weight = x.Weight,
                Height = x.Height,
            }).ToList();
        }
        public HumanViewModel Get(Guid id)
        {
            var human = _peopleRepository.Get(id);

            return new HumanViewModel()
            {
                Age = human.Age,
                FirstName = human.FirstName,
                LastName = human.LastName,
                Weight = human.Weight,
                Height = human.Height,
            };
        }
        public void Create(HumanIncomeModel human)
        {
            var entity = new Human()
            {
                Age = human.Age,
                FirstName = human.FirstName,
                LastName = human.LastName,
                Weight = human.Weight,
                Height = human.Height,
            };
            _peopleRepository.Add(entity);
            _peopleRepository.SaveChanges();
        }
        public void Update(Guid id, Human human)
        {
            var entity = _peopleRepository.Get(id);
            if (entity != null)
            {
                entity.FirstName = human.FirstName;
                entity.LastName = human.LastName;
                entity.Age = human.Age;
                entity.Weight = human.Weight;
                entity.Height = human.Height;
                _peopleRepository.SaveChanges();
            }
        }
        public void Remove(Guid id)
        {
            var entity = _peopleRepository.Get(id);
            if (entity != null)
            {
                _peopleRepository.Remove(entity);
                _peopleRepository.SaveChanges();
            }
        }
    }
}
