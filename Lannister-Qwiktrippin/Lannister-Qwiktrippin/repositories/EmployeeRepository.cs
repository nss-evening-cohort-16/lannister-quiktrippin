using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lannister_Qwiktrippin.repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> Employees = new List<Employee>();

        public static List<Employee> GetEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.Name);
            }
            return Employees;
        }

        public static void SaveNewEmployee(Employee _employee)
        {
            Employees.Add(_employee);
        }
    }
}
