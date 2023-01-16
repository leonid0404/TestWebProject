namespace WebApplication1.Models.IncomeModels.AnimalsModels
{
    public class AnimalIncomeModel
    {
        public Guid HumanId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int HealthLvl { get; set; }
        public bool IsAngry { get; set; }
    }
}
