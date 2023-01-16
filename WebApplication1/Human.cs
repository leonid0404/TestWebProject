namespace WebApplication1
{
    public class Human : BaseEntity
    {
        public Human()
        {
            Animals = new List<Animal>();
        }
        public List<Animal> Animals { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public IPhone? Phone { get; set; }
    }
}
