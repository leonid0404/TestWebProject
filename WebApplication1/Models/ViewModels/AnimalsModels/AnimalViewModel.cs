namespace WebApplication1.Models.ViewModels.AnimalsModels
{
    public class AnimalViewModel
    {
        public Guid HumanId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int HealthLvl { get; set; }
        public bool IsAngry { get; set; }
    }
}
