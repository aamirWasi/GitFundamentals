namespace GitFirst
{
    public class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Salary { get; set; }
        public double GetBonus()
        {
            return 0.15 * Salary;
        }
        public double GetBonus()
        {
            return 0.35 * Salary;
        }
    }
}
