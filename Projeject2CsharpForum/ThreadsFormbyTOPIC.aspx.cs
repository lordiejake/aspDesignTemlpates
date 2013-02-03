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
using System.Data;
using System.Data.SqlClient;

public partial class ThreadsFormbyTOPIC : System.Web.UI.Page
{
    System.Data.SqlClient.SqlConnection conn = null;
    double textlegth;
    double id;
    double finalID;
    double IDENZ;
    double ThreadIDSecond;
    double ThreadIDFirst;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Request.QueryString["ThreadIDSecond"] != null)
            {
                ThreadIDSecond = double.Parse(Request.QueryString["ThreadIDSecond"]);
            }


            if (Request.QueryString["ThreadIDfirst"] != null)
            {
                ThreadIDFirst = double.Parse(Request.QueryString["ThreadIDfirst"]);
                Label5.Text = ThreadIDFirst.ToString();
            }


            //=================================================================================

            if (Request.QueryString["Namez"] != null)
            {
                lblwelcome.Text = Request.QueryString["Namez"];
            }

            if (Request.QueryString["IDS"] != null)
            {
                LabelIDS.Text = Request.QueryString["IDS"];
                Label3.Text = Request.QueryString["IDS"];
            }

             if (Request.QueryString["EM"] != null)
             {
                 LabelEmails.Text = Request.QueryString["EM"];
             }

            if (Request.QueryString["Topics"] != null)
            {
                id = double.Parse(Request.QueryString["Topics"]);
                Label2.Text = id.ToString();
                finalID = id;
            }

            if (Request.QueryString["Iden"] != null)
            {
                lblIDEN.Text = Request.QueryString["Iden"];
            }

            lblwelcome.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelIDS.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelEmails.Attributes.Add("style", "color:Black;font-weight:bold;");

            LoadTopic();
            LoadTopicwThreads();
            LoadTopicwoThreads();
            ViewAllThredsCountWith_replies();
            ViewAllThredsCountWithno_replies();
            ViewAllThredsALLALLALL();
            LoadTopicwoThreadsxxx();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void LoadTopic()
    {
       //ClassFields fx = new ClassFields();
       //finalID = double.Parse(fx.TopicID.ToString());

       GridTopic.DataSource = ClassDataManager.Topics_LoadwIDENTIFICATION(finalID); 
       GridTopic.DataBind();
    }

    void LoadTopicwThreads()
    {
        //ClassFields fx = new ClassFields();
        //finalID = double.Parse(fx.TopicID.ToString());

         ThreadsAvailable.DataSource = ClassDataManager.Topics_LoadwIDENTIFICATIONwthreads(finalID);
         ThreadsAvailable.DataBind();
    }

    void LoadTopicwoThreads()
    {
        //ClassFields fx = new ClassFields();
        //finalID = double.Parse(fx.TopicID.ToString());

        ThreadsnotAvailablezzz.DataSource = ClassDataManager.ThreadsWoPostsz(finalID);
        ThreadsnotAvailablezzz.DataBind();
    }

    void LoadTopicwoThreadsxxx()
    {
        //ClassFields fx = new ClassFields();
        //finalID = double.Parse(fx.TopicID.ToString());

         GridView1.DataSource = ClassDataManager.ThreadsWoPostsz(finalID);
         GridView1.DataBind();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        textlegth = double.Parse(TextBox1.Text.Length.ToString());
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (textlegth>0)
        {
            double mmm = 0;
            try
            {
                conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                conn.Open();
                System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [tbl_ThreadWEB] (ThreadTopic,TopicID,UserCID,ThreadStatus,ThreadViewCount)Values(@ThreadTopicx,@TopicIDx,@UserCIDx,@ThreadStatusx,@ThreadViewCountz)", conn);
                insertCommand.Parameters.Add(new SqlParameter("@ThreadTopicx", TextBox1.Text));
                insertCommand.Parameters.Add(new SqlParameter("@TopicIDx", double.Parse(Label2.Text)));
                insertCommand.Parameters.Add(new SqlParameter("@UserCIDx", double.Parse(Label3.Text)));
                insertCommand.Parameters.Add(new SqlParameter("@ThreadStatusx", double.Parse(mmm.ToString())));
                insertCommand.Parameters.Add(new SqlParameter("@ThreadViewCountz", "0"));
                int queryResult = insertCommand.ExecuteNonQuery();
                if (queryResult == 1)
                {
                    Resulting.Text = "Submitted";
                    Resulting.Attributes.Add("style", "color:DarkGreen;font-weight:bold;");
                    TextBox1.Text = "";
                    //if (!IsPostBack)
                    //{
                    //    //LoadTopic();
                    //    //LoadTopicwThreads();
                    //    LoadTopicwoThreads();
                    //}

                    try
                    {
                        conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                        conn.Open();
                        System.Data.SqlClient.SqlCommand UpdateCommand = new System.Data.SqlClient.SqlCommand("UPDATE tbl_TopicWEB SET topicstatus = '" + 1 + "'WHERE TopicID ='" + double.Parse(Label2.Text) + "'", conn);
                        UpdateCommand.CommandType = CommandType.Text;
                        UpdateCommand.ExecuteNonQuery();
                        Response.Redirect("ThreadsFormbyTOPIC.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text + "&Topics=" + Label2.Text);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            catch (Exception)
            {
                Resulting.Text = "Please Check the input";
                Resulting.Attributes.Add("style", "color:Red;font-weight:bold;");
            }
            
        }
        
        else
        {
            Resulting.Text = "Unable to submitt";
            Resulting.Attributes.Add("style", "color:Red;font-weight:bold;");
        }
    }
    protected void ThreadsnotAvailablezzz_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //int index = int.Parse(e.CommandArgument.ToString());
        //if (e.CommandName.Equals("Select"))
        //{
        //    try
        //    {
        //        conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        //        conn.Open();
        //        System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [tbl_CountPost] (ThreadID)Values(@ThreadIDx)", conn);
        //        insertCommand.Parameters.Add(new SqlParameter("@ThreadIDx", double.Parse(ThreadsnotAvailablezzz.Rows[index].Cells[0].Text)));
        //        int queryResult = insertCommand.ExecuteNonQuery();
        //        if (queryResult == 1)
        //        {
        //            conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        //            try
        //            {
        //                SqlCommand command = new SqlCommand("SELECT COUNT(dbo.tbl_CountPost.ThreadID) AS CountedPost, dbo.tbl_ThreadWEB.ThreadID      FROM            dbo.tbl_ThreadWEB INNER JOIN   dbo.tbl_CountPost ON dbo.tbl_ThreadWEB.ThreadID = dbo.tbl_CountPost.ThreadID WHERE   dbo.tbl_ThreadWEB.ThreadID = '" + double.Parse(ThreadsnotAvailablezzz.Rows[index].Cells[0].Text) + "'GROUP BY dbo.tbl_ThreadWEB.ThreadID", conn);
        //                conn.Open();
        //                SqlDataReader dr = command.ExecuteReader();
        //                if (dr.HasRows)
        //                {
        //                    while (dr.Read())
        //                    {
        //                        double threadCountID;
        //                        threadCountID = double.Parse(dr[0].ToString());
        //                        Label4.Text = threadCountID.ToString();

        //                        try
        //                        {
        //                            conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        //                            conn.Open();
        //                            System.Data.SqlClient.SqlCommand UpdateCommand = new System.Data.SqlClient.SqlCommand("UPDATE tbl_ThreadWEB SET ThreadViewCount = '" + double.Parse(threadCountID.ToString()) + "'WHERE ThreadID ='" + ThreadsnotAvailablezzz.Rows[index].Cells[0].Text + "'", conn);
        //                            UpdateCommand.CommandType = CommandType.Text;
        //                            UpdateCommand.ExecuteNonQuery();
        //                            Response.Redirect("PostWEB.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text + "&Topics=" + Label2.Text + "&ThreadID=" + ThreadsnotAvailablezzz.Rows[index].Cells[0].Text);
        //                        }
        //                        catch (Exception)
        //                        {

        //                            throw;
        //                        }
        //                    }
        //                }

        //            }
        //            catch (Exception)
        //            {

        //            }
        //            finally
        //            {
        //                conn.Close();
        //            }
                    
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
         
        //}

        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("ThreadsFormbyTOPIC.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text + "&Topics=" + Label2.Text + "&ThreadIDfirst=" + ThreadsnotAvailablezzz.Rows[index].Cells[0].Text);
        }
    }
    protected void ThreadsAvailable_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            try
            {
                conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                conn.Open();
                System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [tbl_CountPost] (ThreadID)Values(@ThreadIDx)", conn);
                insertCommand.Parameters.Add(new SqlParameter("@ThreadIDx", double.Parse(ThreadsAvailable.Rows[index].Cells[0].Text)));
                int queryResult = insertCommand.ExecuteNonQuery();
                if (queryResult == 1)
                {
                    conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                    try
                    {
                        SqlCommand command = new SqlCommand("SELECT COUNT(dbo.tbl_CountPost.ThreadID) AS CountedPost, dbo.tbl_ThreadWEB.ThreadID      FROM            dbo.tbl_ThreadWEB INNER JOIN   dbo.tbl_CountPost ON dbo.tbl_ThreadWEB.ThreadID = dbo.tbl_CountPost.ThreadID WHERE   dbo.tbl_ThreadWEB.ThreadID = '" + double.Parse(ThreadsAvailable.Rows[index].Cells[0].Text) + "'GROUP BY dbo.tbl_ThreadWEB.ThreadID", conn);
                        conn.Open();
                        SqlDataReader dr = command.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                double threadCountID;
                                threadCountID = double.Parse(dr[0].ToString());
                                Label4.Text = threadCountID.ToString();

                                try
                                {
                                    conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                                    conn.Open();
                                    System.Data.SqlClient.SqlCommand UpdateCommand = new System.Data.SqlClient.SqlCommand("UPDATE tbl_ThreadWEB SET ThreadViewCount = '" + double.Parse(threadCountID.ToString()) + "'WHERE ThreadID ='" + ThreadsAvailable.Rows[index].Cells[0].Text + "'", conn);
                                    UpdateCommand.CommandType = CommandType.Text;
                                    UpdateCommand.ExecuteNonQuery();
                                    Response.Redirect("PostWEB.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text + "&Topics=" + Label2.Text + "&ThreadID=" + ThreadsAvailable.Rows[index].Cells[0].Text);
                                }
                                catch (Exception)
                                {

                                    throw;
                                }
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
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }
    }

    void ViewAllThredsCountWith_replies()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT        COUNT(ThreadID) AS ThreadWtopic  FROM dbo.tbl_ThreadWEB   WHERE  (ThreadStatus = 1) AND TopicID = '" + double.Parse(finalID.ToString()) + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtThreadsWITHreplies.Text = "[" + dr[0].ToString() + " Thread/s]";

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

    void ViewAllThredsCountWithno_replies()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT        COUNT(ThreadID) AS ThreadWtopic  FROM dbo.tbl_ThreadWEB   WHERE  (ThreadStatus = 0) AND TopicID = '" + double.Parse(finalID.ToString()) + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    txtThreadsWITHoutreplies.Text = "[" + dr[0].ToString() + " Thread]";

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

    void ViewAllThredsALLALLALL()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(ThreadID) AS AllTHREADS   FROM   dbo.tbl_ThreadWEB WHERE TopicID = '" + double.Parse(finalID.ToString()) + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblALLTHREADS.Text = "[" + dr[0].ToString() + "]" + " Thread/s";

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
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("WelcomePage.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text);
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("ThreadsFormbyTOPIC.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + lblIDEN.Text + "&Topics=" + Label2.Text + "&ThreadIDSecond=" + GridView1.Rows[index].Cells[0].Text + "&ThreadIDfisrt=" + Label5.Text);
        }
    }
}
