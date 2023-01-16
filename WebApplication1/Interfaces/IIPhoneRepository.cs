namespace WebApplication1.Interfaces
{
    public interface IIPhoneRepository : IBaseRepository
    {
        IEnumerable<IPhone> GetAll();
        IPhone? Get(Guid id);
        void Create(IPhone phone);
        void Remove(IPhone phone);
    }
}
