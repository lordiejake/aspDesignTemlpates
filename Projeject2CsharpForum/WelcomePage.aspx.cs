using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class WelcomePage : System.Web.UI.Page
{
    double catIDZ;
    SqlConnection conn = null;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            if (Request.QueryString["Namez"] != null)
                lblwelcome.Text = Request.QueryString["Namez"];

            if (Request.QueryString["IDS"] != null)
                LabelIDS.Text = Request.QueryString["IDS"];

            if (Request.QueryString["EM"] != null)
                LabelEmails.Text = Request.QueryString["EM"];

            if (Request.QueryString["Iden"] != null)
                catIDZ = double.Parse(Request.QueryString["Iden"]);
                vid.Text = Request.QueryString["Iden"];

            lblwelcome.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelIDS.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelEmails.Attributes.Add("style", "color:Black;font-weight:bold;");

            LoadSelect();
            LoadSelect2();
            ViewAllTopicsCountWith_Threads();
            ViewAllTopicsCountWith_NOThreads();
            LoadSpecificCategoryName();
            AllTOPIcZZZZZZZZZZ();
        }
    }


    void LoadSelect()
    {
       gridTOPIC_wTHREADS.DataSource = ClassDataManager.Subject_Load(catIDZ);
       gridTOPIC_wTHREADS.DataBind();
    }

    void LoadSpecificCategoryName()
    {
        gridDisplayCAtegory.DataSource = ClassDataManager.DisplaySpecificCategory(catIDZ);
        gridDisplayCAtegory.DataBind();
    }

    void LoadSelect2()
    {
        grid2TOPIC_wTHREADS0.DataSource = ClassDataManager.Subject_LoadZERO(catIDZ);
         grid2TOPIC_wTHREADS0.DataBind();
    }
    protected void grid2TOPIC_wTHREADS0_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void gridTOPIC_wTHREADS_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("ThreadsFormbyTOPIC.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + vid.Text + "&Topics=" + gridTOPIC_wTHREADS.Rows[index].Cells[0].Text);
        }
    }
    protected void grid2TOPIC_wTHREADS0_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("ThreadsFormbyTOPIC.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + vid.Text + "&Topics=" + grid2TOPIC_wTHREADS0.Rows[index].Cells[0].Text);
        }
    }
    protected void txtSaveTopic_Click(object sender, EventArgs e)
    {
        try
        {
            try
            {
                conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                conn.Open();
                System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [tbl_TopicWEB] (TopicDecription,topicstatus,CategoryID,UserCID) Values (@TopicDecription,@topicstatus,@CategoryID,@UserCID)", conn);
                // insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value = ConvertImageToByteArray(imag, System.Drawing.Imaging.ImageFormat.Jpeg);
                insertCommand.Parameters.Add(new SqlParameter("@TopicDecription", txtTopic.Text));
                insertCommand.Parameters.Add(new SqlParameter("@topicstatus", "0"));
                insertCommand.Parameters.Add(new SqlParameter("@CategoryID", double.Parse(vid.Text)));
                insertCommand.Parameters.Add(new SqlParameter("@UserCID", double.Parse(LabelIDS.Text)));
                int queryResult = insertCommand.ExecuteNonQuery();
                if (queryResult == 1)
                {

                    txtCreatetopic.Text = "Post Successful";
                    txtCreatetopic.Attributes.Add("style", "color:DarkGreen;font-weight:bold;");
                    try
                    {
                        conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                        conn.Open();
                        System.Data.SqlClient.SqlCommand UpdateCommand = new System.Data.SqlClient.SqlCommand("UPDATE tbl_categoryWEB SET CategoryStatus = '" + 1 + "'WHERE CategoryID ='" + double.Parse(vid.Text) + "'", conn);
                        UpdateCommand.CommandType = CommandType.Text;
                        UpdateCommand.ExecuteNonQuery();
                        txtTopic.Text = "";
                        Response.Redirect("WelcomePage.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + vid.Text);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }

            }
            catch (Exception ex)
            {

                txtCreatetopic.Text = "Error: " + ex.Message;
                txtCreatetopic.Attributes.Add("style", "color:Red;font-weight:bold;");

            }
        }
        finally
        {
            if (conn != null)
                conn.Close();
        }
    }

    void ViewAllTopicsCountWith_Threads()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(TopicID) AS TopicWithTHREADS   FROM  dbo.tbl_TopicWEB   WHERE (topicstatus = 1) AND CategoryID = '" + double.Parse(vid.Text) + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblTopicWITH_THREADS.Text = "[" + dr[0].ToString() + " Topic]";

                }
            }

        }
        catch (Exception)
        {

        }
        finally
        {
            conn.Close();
        }
    }

    void ViewAllTopicsCountWith_NOThreads()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(TopicID) AS TopicWithTHREADS   FROM  dbo.tbl_TopicWEB   WHERE (topicstatus = 0) AND CategoryID = '" + double.Parse(vid.Text) + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblTopicWITH_THREADSwithout.Text = "[" + dr[0].ToString() + "Topic]";

                }
            }

        }
        catch (Exception)
        {

        }
        finally
        {
            conn.Close();
        }
    }

    void AllTOPIcZZZZZZZZZZ()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(TopicID) AS AllTopicszx   FROM dbo.tbl_TopicWEB WHERE CategoryID = '" + double.Parse(vid.Text) + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    AllTOPICS.Text = "[" + dr[0].ToString() + "]" + " Topic";

                }
            }

        }
        catch (Exception)
        {

        }
        finally
        {
            conn.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("CategoryForm.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text);
    }
}
