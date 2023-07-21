namespace SimpleEmployer.Model.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public Employee(string name, int age, string role)
        {
            Name = name;
            Age = age;
            Role = role;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Имя: {Name}, Возраст: {Age}, Должность: {Role}";
        }
    }
}
