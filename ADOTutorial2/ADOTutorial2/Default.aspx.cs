using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using DataAccessLayer;

namespace ADOTutorial2
{
    public partial class Default : System.Web.UI.Page
    {
        EmployeeHandler emphandler = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
            emphandler = new EmployeeHandler();
            if (!IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            GridEmployee.DataSource = emphandler.GetEmployeeList();
            GridEmployee.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewEmployee.aspx");
        }

        protected void GridEmployee_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridEmployee.EditIndex = -1;
            BindData();
        }

        protected void GridEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridEmployee.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void GridEmployee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblID = (Label)GridEmployee.Rows[e.RowIndex].FindControl("lblID");
            TextBox txtLastName = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtLastName");
            TextBox txtFirstName = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtFirstName");
            TextBox txtTitle = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtTitle");
            TextBox txtAddress = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtAddress");
            TextBox txtCity = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtCity");
            TextBox txtRegion = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtRegion");
            TextBox txtPostalCode = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtPostalCode");
            TextBox txtCountry = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtCountry");
            TextBox txtExtension = (TextBox)GridEmployee.Rows[e.RowIndex].FindControl("txtExtension");

            if (txtLastName.Text != "" && txtFirstName.Text != "" && txtTitle.Text != "" &&
                txtAddress.Text != "" && txtCity.Text != "" && txtRegion.Text != "" &&
                txtPostalCode.Text != "" && txtCountry.Text != "" && txtExtension.Text != "")
            {
                Employee employee = new Employee();
                employee.EmployeeID = Convert.ToInt32(lblID.Text.Trim());
                employee.LastName = txtLastName.Text;
                employee.FirstName = txtFirstName.Text;
                employee.Title = txtTitle.Text;
                employee.Address = txtAddress.Text;
                employee.City = txtCity.Text;
                employee.Region = txtRegion.Text;
                employee.PostalCode = txtPostalCode.Text;
                employee.Country = txtCountry.Text;
                employee.Extension = txtExtension.Text;
                bool result = emphandler.UpdateEmployee(employee);
                if (result == true)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('Update Success!');</script>");
                }
            }

            GridEmployee.EditIndex = -1;
            BindData();
        }
    }
}