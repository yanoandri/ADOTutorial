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
    public partial class Title : System.Web.UI.Page
    {
        public DataAccessSQL daSQL = new DataAccessSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlPublisher.DataSource = daSQL.ExecuteSelectCommand("select * from publishers", CommandType.Text);
                ddlPublisher.DataTextField = "pub_name";
                ddlPublisher.DataValueField = "pub_id";
                ddlPublisher.DataBind();
                ddlPublisher.Items.Insert(0, new ListItem("--Select One--", "0"));

                gridTitle.DataSource = daSQL.ExecuteSelectCommand("select * from titles", CommandType.Text);
                gridTitle.DataBind();
            }
        
        }

        protected void ddlPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlPublisher.SelectedValue.Trim() == "ALL")
            {
                gridTitle.DataSource = daSQL.ExecuteSelectCommand("select * from titles", CommandType.Text);
                gridTitle.DataBind();
            }
            else
            {
                string query = "select * from titles where pub_id = @pubid";
                SqlParameter param = new SqlParameter("@pubid", ddlPublisher.SelectedValue);
                gridTitle.DataSource = daSQL.ExecuteParamerizedSelectCommand(query, CommandType.Text, new SqlParameter[] { param });
                gridTitle.DataBind();
            }
        }
    }
}