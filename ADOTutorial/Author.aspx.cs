using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOTutorial
{
    public partial class Author : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataAccessSQL dbAccess = new DataAccessSQL();

                ddlSelect.DataSource = dbAccess.ExecuteSelectCommand("GetAuthorStates", CommandType.StoredProcedure);
                ddlSelect.DataTextField = "state";
                ddlSelect.DataValueField = "state";
                ddlSelect.DataBind();
                ddlSelect.Items.Insert(0, new ListItem("--Select One--", "0"));

                GridAuthor.DataSource = dbAccess.ExecuteSelectCommand("GetAuthors", CommandType.StoredProcedure);
                GridAuthor.DataBind();
            }
        }

        protected void ddlSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccessSQL dbAccess = new DataAccessSQL();
            if (ddlSelect.SelectedValue.Trim() == "ALL")
            {
                GridAuthor.DataSource = dbAccess.ExecuteSelectCommand("GetAuthors", CommandType.StoredProcedure);
            }
            else
            {
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@state", ddlSelect.SelectedValue)};
                GridAuthor.DataSource = dbAccess.ExecuteParamerizedSelectCommand("GetAuthorByState", CommandType.StoredProcedure, param);
                GridAuthor.DataBind();
            }
        }
    }
}