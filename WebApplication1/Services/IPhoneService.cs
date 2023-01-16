using WebApplication1.Interfaces;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class IPhoneService : IIPhoneService
    {
        private readonly IIPhoneRepository _iPhoneRepository;
        private readonly IPeopleRepository _peopleRepository;

        public IPhoneService(IIPhoneRepository iPhoneRepository, IPeopleRepository peopleRepository )
        {
            _iPhoneRepository = iPhoneRepository;
            _peopleRepository = peopleRepository;
        }
        public IEnumerable<IPhone> GetAll()
        {
            return _iPhoneRepository.GetAll();
        }
        public IPhone? Get(Guid id)
        {
            return _iPhoneRepository.Get(id);
        }
        public void Create(IPhone phone)
        {
            var human = _peopleRepository.Get(phone.HumanId);
            if (human != null)
            {
                _iPhoneRepository.Create(phone);
                human.Phone = phone;
                _iPhoneRepository.SaveChanges();
            }
        }
        public void Update(Guid id, IPhone phone)
        {
            var entity = _iPhoneRepository.Get(id);
            if (entity != null)
            {
                entity.Model = phone.Model;
                entity.BrandName = phone.BrandName;
                entity.BatteryLvl = phone.BatteryLvl;
                if (phone.HumanId == default)
                {
                    var human = _peopleRepository.Get(entity.HumanId);
                    if (human != null)
                    {
                        human.Phone = null;
                    }
                }
                entity.HumanId = phone.HumanId;
                _iPhoneRepository.SaveChanges();
            }
        }
        public void Remove(Guid id)
        {
            var entity = _iPhoneRepository.Get(id);
            if (entity != null)
            {
                _iPhoneRepository.Remove(entity);
                _iPhoneRepository.SaveChanges();
            }
        }
    }
}
