using WebApplication1.Interfaces;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class AnimalsService : IAnimalsService
    {
        private readonly IAnimalsRepository _animalsRepository;
        private readonly IPeopleRepository _peopleRepository;

        public AnimalsService(IAnimalsRepository animalsRepository, IPeopleRepository peopleRepository)
        {
            _animalsRepository = animalsRepository;
            _peopleRepository = peopleRepository;
        }
        public IEnumerable<Animal> GetAll()
        {
            return _animalsRepository.GetAll();
        }
        public Animal? Get(int id)
        {
            return _animalsRepository.Get(id);
        }
        public void Create(Animal animal)
        {
            var human = _peopleRepository.Get(animal.HumanId);
            if (human != null)
            {
                _animalsRepository.Create(animal);
                human.Animals.Add(animal);
                _animalsRepository.SaveChanges();
            }
        }
        public void Update(int id, Animal animal)
        {
            var entity = _animalsRepository.Get(id);
            if (entity != null)
            {
                entity.Name = animal.Name;
                entity.Age = animal.Age;
                entity.HealthLvl = animal.HealthLvl;
                entity.IsAngry = animal.IsAngry;
                _animalsRepository.SaveChanges();
            }
        }
        public void Remove(int id)
        {
            var entity = _animalsRepository.Get(id);
            if (entity != null)
            {
                _animalsRepository.Remove(entity);
                _animalsRepository.SaveChanges();
            }
        }
    }
}
