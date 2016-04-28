using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class EmployeeHandler
    {
        DataAccessHandler daHandler = null;

        public EmployeeHandler()
        {
            daHandler = new DataAccessHandler();
        }

        public List<Employee> GetEmployeeList()
        {
            return daHandler.GetEmployeeList();
        }

        public bool UpdateEmployee(Employee employee)
        {
            return daHandler.UpdateEmployee(employee);
        }

        public Employee GetEmployeeDetails(int empID)
        {
            return daHandler.GetEmployeeDetails(empID);
        }

        public bool DeleteEmployee(int empID)
        {
            return daHandler.DeleteEmployee(empID);
        }

        public bool AddNewEmployee(Employee employee)
        {
            return daHandler.AddNewEmployee(employee);
        }
    }
}
