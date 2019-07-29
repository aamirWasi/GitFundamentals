namespace GitFirst
{
    public class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Salary { get; set; }
        public void Bonus(double salary)
        {
            Salary = salary;
        }
    }
}
