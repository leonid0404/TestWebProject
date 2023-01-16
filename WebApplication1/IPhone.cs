namespace WebApplication1
{
    public class IPhone : BaseEntity
    {
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int BatteryLvl { get; set; }
        public Guid HumanId { get; set; }
    }
}
