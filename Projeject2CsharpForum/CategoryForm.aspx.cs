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


public partial class CategoryForm : System.Web.UI.Page
{
    double icx;
    SqlConnection conn = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadCategory();
            LoadCategoryNO();
            if (Request.QueryString["Namez"] != null)
                lblwelcome.Text = Request.QueryString["Namez"];

            if (Request.QueryString["IDS"] != null)
            {
                LabelIDS.Text = Request.QueryString["IDS"];
                icx = double.Parse(LabelIDS.Text);
                if (icx<=0)
                {
                    Response.Redirect("loginForm.aspx?"); 
                }
                else if (icx > 0)
                {

                }
                else
                {
                    Response.Redirect("loginForm.aspx?"); 
                }
            }

            if (Request.QueryString["EM"] != null)
                LabelEmails.Text = Request.QueryString["EM"];

            lblwelcome.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelIDS.Attributes.Add("style", "color:Black;font-weight:bold;");
            LabelEmails.Attributes.Add("style", "color:Black;font-weight:bold;");


            viewAllCategoryWithTopics();
            viewAllCategoryWithoutTopics();
            ALLCAT();
        }
    }
    protected void gridcategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("WelcomePage.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + gridcategory.Rows[index].Cells[0].Text);
        }
    }
    protected void gridnocategory_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName.Equals("Select"))
        {
            Response.Redirect("WelcomePage.aspx?Namez=" + lblwelcome.Text + "&IDS=" + LabelIDS.Text + "&EM=" + LabelEmails.Text + "&Iden=" + gridnocategory.Rows[index].Cells[0].Text);
        }
    }

    void LoadCategory()
    {
        gridcategory.DataSource = ClassDataManager.Category_LoadZERO();
        gridcategory.DataBind();
    }

    void LoadCategoryNO()
    {
        gridnocategory.DataSource = ClassDataManager.Category_LoadZEROzzzzzz();
        gridnocategory.DataBind();
    }

    void viewAllCategoryWithTopics()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT        COUNT(CategoryID) AS Withtopics  FROM dbo.tbl_categoryWEB   WHERE (CategoryStatus = 1)", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblcategorywTopics.Text = "[" + dr[0].ToString() + " Category]";

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

    void viewAllCategoryWithoutTopics()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT        COUNT(CategoryID) AS Withtopics  FROM dbo.tbl_categoryWEB   WHERE (CategoryStatus = 0)", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                   lblcategorywithoutTopics.Text = "[" + dr[0].ToString() + " Category]";

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

    void ALLCAT()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(CategoryID) AS AllCategory   FROM dbo.tbl_categoryWEB", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblAllCATEGORIES.Text = "[" + dr[0].ToString() + "] Category";

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
