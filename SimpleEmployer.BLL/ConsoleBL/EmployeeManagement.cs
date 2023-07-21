using SimpleEmployer.Model.Entities;

namespace SimpleEmployer.BLL.ConsoleBL
{
    public class EmployeeManagement
    {
        private List<Employee> _employees;
        public EmployeeManagement()
        {
            _employees = new List<Employee>();
        }
        
        public void AddEmployee(string name, int age, string role)
        {
            var highestId = _employees.Any() ? _employees.Max(x => x.Id) : 1;
            var employee = new Employee(name, age, role);
            employee.Id = highestId + 1;
            _employees.Add(employee);
        }

        public bool RemoveEmployee(int id)
        {
            try
            {
                var employee = _employees.Find(e => e.Id == id);
                _employees.Remove(employee);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void GetAllEmployees()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
