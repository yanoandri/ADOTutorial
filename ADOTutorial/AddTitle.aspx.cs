using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADOTutorial
{
    public partial class AddTitle : System.Web.UI.Page
    {
        public DataAccessSQL daSQL = new DataAccessSQL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //DataAccessSQL daSQL = new DataAccessSQL();
                ddlPublisher.DataSource = daSQL.ExecuteSelectCommand("select * from publishers", CommandType.Text);
                ddlPublisher.DataTextField = "pub_name";
                ddlPublisher.DataValueField = "pub_id";
                ddlPublisher.DataBind();
                ddlPublisher.Items.Insert(0, new ListItem("--Select One--", "0"));
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            string insertCommand = "insert into titles values(@title, @type, @pubid, @price, @advance, @royalty , @ytd, @notes, GetDate())";
            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@title",txtTitle.Text),
                new SqlParameter("@type",txtType.Text),
                new SqlParameter("@pubid",ddlPublisher.SelectedValue.ToString()),
                new SqlParameter("@price",txtPrice.Text),
                new SqlParameter("@advance",txtAdvance.Text),
                new SqlParameter("@royalty",txtRoyalty.Text),
                new SqlParameter("@ytd",txtYtd.Text),
                new SqlParameter("@notes",txtNotes.Text)
            };
            bool insertAuthor = daSQL.ExecuteNonQuery(insertCommand, CommandType.Text, param);
            if (insertAuthor == true)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('Save Successful!'); window.location : 'Title.aspx'; </script>");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "", "<script>alert('Save Failed!');</script>");
            }
        }

    }
}