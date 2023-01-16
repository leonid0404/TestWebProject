using WebApplication1.Interfaces;
using WebApplication1.Models.IncomeModels.HouseModels;
using WebApplication1.Models.ViewModels.HouseModels;

namespace WebApplication1.Services
{
    public class HouseService : IHouseService
    {
        private readonly IHouseRepository _houseRepository;
        public HouseService(IHouseRepository houseRepository)
        {
            _houseRepository = houseRepository;
        }

        public void Create(HouseIncomeModel human)
        {
            _houseRepository.Add(new House()
            {
                Floors = human.Floors,
                Area = human.Area,
            });
            _houseRepository.SaveChanges();
        }

        public HouseViewModel Get(Guid id)
        {
            var house = _houseRepository.Get(id);
            return new HouseViewModel()
            {
                Id = house.Id,
                Area = house.Area,
                Floors = house.Floors,
            };
        }

        public IEnumerable<HouseViewModel> GetAll()
        {
            return _houseRepository.GetAll().Select(x => new HouseViewModel()
            {
                Id = x.Id,
                Area = x.Area,
                Floors = x.Floors,
            }).ToList();
        }

        public void Remove(Guid id)
        {
            var house = _houseRepository.Get(id);
            if(house != null)
            {
                _houseRepository.Remove(house);
                _houseRepository.SaveChanges();
            }
        }

        public void Update(Guid id, HouseIncomeModel houseIncomeModel)
        {
            var house = _houseRepository.Get(id);
            if (house != null)
            {
                house.Area = houseIncomeModel.Area;
                house.Floors = houseIncomeModel.Floors;
                _houseRepository.SaveChanges();
            }
        }
    }
}
