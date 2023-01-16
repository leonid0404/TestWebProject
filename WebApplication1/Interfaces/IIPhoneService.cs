namespace WebApplication1.Interfaces
{
    public interface IIPhoneService
    {
        IEnumerable<IPhone> GetAll();
        IPhone? Get(Guid id);
        void Create(IPhone phone);
        void Update(Guid id, IPhone phone);
        void Remove(Guid id);
    }
}
