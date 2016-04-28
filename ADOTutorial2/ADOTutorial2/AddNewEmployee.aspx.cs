using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADOTutorial2
{
    public partial class AddNewEmployee : System.Web.UI.Page
    {
        public EmployeeHandler empHandler = new EmployeeHandler();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    btnSubmit.Text = "Delete";
                    LockedTextBox();
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    Employee employee = empHandler.GetEmployeeDetails(id);
                    txtLName.Text = employee.LastName;
                    txtFName.Text = employee.FirstName;
                    txtTitle.Text = employee.Title;
                    txtAddress.Text = employee.Address;
                    txtCity.Text = employee.City;
                    txtRegion.Text = employee.Region;
                    txtCode.Text = employee.PostalCode;
                    txtCountry.Text = employee.Country;
                    txtExtension.Text = employee.Extension;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Request.QueryString["id"]) != 0)
            {

                int id = Convert.ToInt32(Request.QueryString["id"]);
                bool result = empHandler.DeleteEmployee(id);
                if (result != false)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('Delete Success!'); window.location = 'Default.aspx';</script>");
                }
            }
            else
            {
                AddEmployee();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        private void AddEmployee()
        {
            Employee employee = new Employee();
            employee.LastName = txtLName.Text;
            employee.FirstName = txtFName.Text;
            employee.Title = txtTitle.Text;
            employee.Address = txtAddress.Text;
            employee.City = txtCity.Text;
            employee.Region = txtRegion.Text;
            employee.PostalCode = txtCode.Text;
            employee.Country = txtCountry.Text;
            employee.Extension = txtExtension.Text;

            bool result = empHandler.AddNewEmployee(employee);
            if (result == true)
            {
                Response.Redirect("Default.aspx");
            }
        }

        private void LockedTextBox()
        {
            txtLName.ReadOnly = true;
            txtFName.ReadOnly = true;
            txtTitle.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtRegion.ReadOnly = true;
            txtCode.ReadOnly = true;
            txtCountry.ReadOnly = true;
            txtExtension.ReadOnly = true;
        }
    }
}