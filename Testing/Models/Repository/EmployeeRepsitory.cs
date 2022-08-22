using Testing.Models.Interfaces;

namespace Testing.Models.Repository
{
    public class EmployeeRepsitory : IEmployeeRepository
    {
        public  List<Employee> employees;
        public EmployeeRepsitory()
        {
            employees= new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Adil" });
            employees.Add(new Employee { Id = 2, Name = "hamza" });
            employees.Add(new Employee { Id = 3, Name = "Molvi Ahmad Ashfaq" });
        }
        public List<Employee> GetALlEmployee()
        {
            return employees;
        }
    }
}
