using WebApplication1.Models.IncomeModels.HouseModels;
using WebApplication1.Models.ViewModels.HouseModels;

namespace WebApplication1.Interfaces
{
    public interface IHouseService
    {
        IEnumerable<HouseViewModel> GetAll();
        HouseViewModel Get(Guid id);
        void Create(HouseIncomeModel human);
        void Update(Guid id, HouseIncomeModel houseIncomeModel);
        void Remove(Guid id);
    }
}
