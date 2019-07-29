namespace GitFirst
{
    public class Customer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public double Salary { get; set; }
        public double GetBonus(double salary)
        {
            return 0.25 * salary;
        }
        //Added a Sub Method
        public int Sub(int x, int y)
        {
            return x - y;
        }
        
    }
}
