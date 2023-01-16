namespace WebApplication1
{
    public class House : BaseEntity
    {
        public House()
        {
            People = new List<Human>();
        }
        public List<Human> People { get; set; }
        public int Floors { get; set; }
        public double Area { get; set; }
    }
}
