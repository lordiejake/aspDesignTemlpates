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
using System.Data;

public partial class PostWEB : System.Web.UI.Page
{
    double txt;
    double id;
    double finalID;
    SqlConnection conn = null;
    string IDENZ;
    double Topiczzz;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["Namez"] != null)
            {
                lblwelcome.Text = Request.QueryString["Namez"];
            }

            if (Request.QueryString["IDS"] != null)
            {
                LabelIDS.Text = Request.QueryString["IDS"];
                Label3.Text = Request.QueryString["IDS"];
            }

            //if (Request.QueryString["EM"] != null)
            //    LabelEmails.Text = Request.QueryString["EM"];
            if (Request.QueryString["EM"] != null)
            {
                LabelEmails.Text = Request.QueryString["EM"].ToString();
            }

            if (Request.QueryString["Iden"] != null)
            {
                lblIDEN.Text = Request.QueryString["Iden"];
            }

            if (Request.QueryString["Topics"] != null)
            {
                lblTopics.Text = Request.QueryString["Topics"];
            }

            if (Request.QueryString["ThreadID"] != null)
            {
                finalID = double.Parse(Request.QueryString["ThreadID"].ToString());
                id = finalID;
                LabelThreadID.Text = Request.QueryString["ThreadID"].ToString();
            }

            lblwelcome.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelIDS.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelEmails.Attributes.Add("style", "color:Black;font-weight:bold;");

            PostLoads();
            PostLoadsn();
            PostLoadsthreadz();
            viewnumberPOST();
            UserPOSTSby();
        }
    }


    void PostLoads()
    {
         Posting.DataSource = ClassDataManager.POSTSz(id);
         Posting.DataBind();
    }

    void PostLoadsn()
    {
        Posting0.DataSource = ClassDataManager.POSTSz(id);
        Posting0.DataBind();
    }

    void PostLoadsthreadz()
    {
        ThreadNo.DataSource = ClassDataManager.THREADINGZ(id);
        ThreadNo.DataBind();
    }

    void viewnumberPOST()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT        COUNT(dbo.tbl_ThreadWEB.ThreadID) AS Number  FROM            dbo.tbl_ThreadWEB INNER JOIN   dbo.tbl_PostWEB ON dbo.tbl_ThreadWEB.ThreadID = dbo.tbl_PostWEB.ThreadID WHERE dbo.tbl_PostWEB.ThreadID = '" + id + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   
                   PostsStatus.Text = "[" + dr[0].ToString() + " Post/s]";
                  
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


    void UserPOSTSby()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT        tbl_usersWEB.LastNamez + ',' + tbl_usersWEB.FirstNamez AS UserBy, tbl_usersWEB.EmailAddressz    FROM            tbl_ThreadWEB INNER JOIN        tbl_usersWEB ON tbl_ThreadWEB.UserCID = tbl_usersWEB.UserCID WHERE tbl_ThreadWEB.ThreadID = '" + id + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                   // PostsStatus.Text = "[" + dr[0].ToString() + " Post/s]";
                    linkby.Text = dr[0].ToString();
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


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txt > 0)
        {

            try
            {
                try
                {
                    conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                    conn.Open();
                    System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [tbl_PostWEB] (Post,PostDate,UserCID,ThreadID,Status) Values (@Posta,@PostDatea,@UserCIDa,@ThreadIDa,@Statusa)", conn);
                    // insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value = ConvertImageToByteArray(imag, System.Drawing.Imaging.ImageFormat.Jpeg);
                    insertCommand.Parameters.Add(new SqlParameter("@Posta", TextBox1.Text));
                    insertCommand.Parameters.Add(new SqlParameter("@PostDatea", DateTime.Now.ToString()));
                    insertCommand.Parameters.Add(new SqlParameter("@UserCIDa", double.Parse(Label3.Text)));
                    insertCommand.Parameters.Add(new SqlParameter("@ThreadIDa", double.Parse(LabelThreadID.Text)));
                    insertCommand.Parameters.Add(new SqlParameter("@Statusa", "1 star"));
                    int queryResult = insertCommand.ExecuteNonQuery();
                    if (queryResult == 1)
                    {
                        //PostLoads();
                        //PostLoadsthreadz();
                       // viewnumberPOST();
                       // UserPOSTSby();

                        Resulting.Text = "Post Successful";
                        Resulting.Attributes.Add("style", "color:DarkGreen;font-weight:bold;");
                        try
                        {
                            conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                            conn.Open();
                            System.Data.SqlClient.SqlCommand UpdateCommand = new System.Data.SqlClient.SqlCommand("UPDATE tbl_ThreadWEB SET ThreadStatus = '" + 1 + "'WHERE ThreadID ='" + double.Parse(LabelThreadID.Text) + "'", conn);
                            UpdateCommand.CommandType = CommandType.Text;
                            UpdateCommand.ExecuteNonQuery();
                            TextBox1.Text = "";
                            Response.Redirect("PostWEB.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text + "&Topics=" + lblTopics.Text + "&ThreadID=" + LabelThreadID.Text);
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }

                }
                catch (Exception ex)
                {

                    Resulting.Text = "Error: " + ex.Message;
                    Resulting.Attributes.Add("style", "color:Red;font-weight:bold;");

                }
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        else
        {
            Resulting.Text = "Error: enter a comment(post/s)";
            Resulting.Attributes.Add("style", "color:Red;font-weight:bold;");
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        txt = double.Parse(TextBox1.Text.Length.ToString());
    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("CategoryForm.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text);
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("WelcomePage.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text);
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ThreadsFormbyTOPIC.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text + "&Topics=" + lblTopics.Text);
    }
}
