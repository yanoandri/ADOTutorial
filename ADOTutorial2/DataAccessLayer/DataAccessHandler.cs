using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccessHandler
    {
        public bool AddNewEmployee(Employee employee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LastName", employee.LastName),
                new SqlParameter("@FirstName", employee.FirstName),
                new SqlParameter("Title", employee.Title),
                new SqlParameter("@Address", employee.Address),
                new SqlParameter("@City", employee.City),
                new SqlParameter("@Region", employee.Region),
                new SqlParameter("@PostalCode", employee.PostalCode),
                new SqlParameter("@Country", employee.Country),
                new SqlParameter("@Extension", employee.Extension)
            };

            return DataAccessSQL.ExecuteNonQuery("AddNewEmployee",CommandType.StoredProcedure,parameters);
        }

        public bool UpdateEmployee(Employee employee)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeID", employee.EmployeeID),
                new SqlParameter("@LastName", employee.LastName),
                new SqlParameter("@FirstName", employee.FirstName),
                new SqlParameter("@Title", employee.Title),
                new SqlParameter("@Address", employee.Address),
                new SqlParameter("@City", employee.City),
                new SqlParameter("@Region", employee.Region),
                new SqlParameter("@PostalCode", employee.PostalCode),
                new SqlParameter("@Country", employee.Country),
                new SqlParameter("@Extension", employee.Extension)
            };

            return DataAccessSQL.ExecuteNonQuery("UpdateEmployee", CommandType.StoredProcedure, parameters);
        }

        public bool DeleteEmployee(int empID)
        {
            SqlParameter[] parameter = new SqlParameter[] 
            { 
                new SqlParameter("@empId", empID)
            };

            return DataAccessSQL.ExecuteNonQuery("DeleteEmployee", CommandType.StoredProcedure, parameter);
        }

        public Employee GetEmployeeDetails(int empID)
        {
            Employee employee = null;
            SqlParameter[] parameter = new SqlParameter[]{new SqlParameter("@empId", empID)};


            using (DataTable dt = DataAccessSQL.ExecuteParamSelectCommand("GetEmployeeDetails", CommandType.StoredProcedure, parameter))
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow drow = dt.Rows[0];
                    employee = new Employee();
                    employee.EmployeeID = Convert.ToInt32(drow["EmployeeID"]);
                    employee.FirstName = drow["FirstName"].ToString();
                    employee.LastName = drow["LastName"].ToString();
                    employee.Title = drow["Title"].ToString();
                    employee.Address = drow["Address"].ToString(); ;
                    employee.City = drow["City"].ToString();
                    employee.Region = drow["Region"].ToString();
                    employee.PostalCode = drow["PostalCode"].ToString();
                    employee.Country = drow["Country"].ToString();
                    employee.Extension = drow["Extension"].ToString();
                }
            }
            return employee;
        }

        public List<Employee> GetEmployeeList()
        {
            List<Employee> listEmployee = null;
            using (DataTable dt = DataAccessSQL.ExecuteSelectCommand("GetEmployeeList", CommandType.StoredProcedure))
            {
                if (dt.Rows.Count != 0)
                {
                    listEmployee = new List<Employee>();

                    foreach (DataRow drow in dt.Rows)
                    {
                        Employee employee = new Employee();
                        employee.EmployeeID = Convert.ToInt32(drow["EmployeeID"]);
                        employee.FirstName = drow["FirstName"].ToString();
                        employee.LastName = drow["LastName"].ToString();
                        employee.Title = drow["Title"].ToString();
                        employee.Address = drow["Address"].ToString();
                        employee.City = drow["City"].ToString();
                        employee.Region = drow["Region"].ToString();
                        employee.PostalCode = drow["PostalCode"].ToString();
                        employee.Country = drow["Country"].ToString();
                        employee.Extension = drow["Extension"].ToString();
                        listEmployee.Add(employee);
                    }
                }
            }
            return listEmployee;
        }
    }
}
