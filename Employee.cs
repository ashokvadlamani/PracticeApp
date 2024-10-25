namespace PracticeApp
{
    public class Employee
    {
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Employee(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name) : base(id)
        {
            Name = name;
        }
        public double Salary { get; set; }

    }



}