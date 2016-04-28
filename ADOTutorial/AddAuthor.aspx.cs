using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;



namespace ADOTutorial
{
    public partial class AddAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@au_fname", txtfName.Text),
                new SqlParameter("@au_lname", txtLName.Text),
                new SqlParameter("@phone", txtPhone.Text),
                new SqlParameter("@address", txtAddress.Text),
                new SqlParameter("@city", txtCity.Text),
                new SqlParameter("@state", txtState.Text),
                new SqlParameter("@zip", txtZip.Text)
            };

            DataAccessSQL daSQL = new DataAccessSQL();
            bool retVal = daSQL.ExecuteNonQuery("AddNewAuthor", CommandType.StoredProcedure, parameter);

            if (retVal == true)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('Save Successful!');</script>");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('Save Failed!');</script>");
            }

        }
    }
}