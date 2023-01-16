using WebApplication1.Models.IncomeModels.PeopleModels;
using WebApplication1.Models.ViewModels.PeopleModels;

namespace WebApplication1.Interfaces
{
    public interface IPeopleService
    {
        IEnumerable<HumanViewModel> GetAll();
        HumanViewModel Get(Guid id);
        void Create(HumanIncomeModel human);
        void Update(Guid id, Human human);
        void Remove(Guid id);
    }
}
