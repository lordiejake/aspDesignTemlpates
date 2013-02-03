using System;
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
using System.IO;
using System.Data.SqlClient;
using System.Collections;


public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Redirect("loginForm.aspx");
        if (!IsPostBack)
        {
            Load_GridData();
            if (Request.QueryString["Name"] != null)
                lblwelcome.Text = Request.QueryString["Name"];
            lblwelcome.Attributes.Add("style", "color:Black;font-weight:bold;");
        }
    }


    void Load_GridData()
    {

        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        SqlCommand command = new SqlCommand("SELECT LastN,FirstN, msgid FROM [msg]", conn);
        SqlDataAdapter daimages = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        daimages.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        GridView1.Attributes.Add("bordercolor", "black");
    }


    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert, System.Drawing.Imaging.ImageFormat formatOfImage)
    {
        byte[] Ret;
        try
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageToConvert.Save(ms, formatOfImage);
                Ret = ms.ToArray();
            }
        }
        catch (Exception) { throw; }
        return Ret;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        System.Drawing.Image imag = System.Drawing.Image.FromStream(
        flImage.PostedFile.InputStream);
        System.Data.SqlClient.SqlConnection conn = null;

        try
        {
            try
            {
                conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                conn.Open();
                System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [msg] (pic1,LastN,FirstN,MiddleN) Values (@Pic,@LN,@FN,@MN)", conn);
                insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value = ConvertImageToByteArray(imag, System.Drawing.Imaging.ImageFormat.Jpeg);
                insertCommand.Parameters.Add(new SqlParameter("@LN", txtlastname.Text));
                insertCommand.Parameters.Add(new SqlParameter("@FN", txtfirstname.Text));
                insertCommand.Parameters.Add(new SqlParameter("@MN", txtmiddlename.Text));
                int queryResult = insertCommand.ExecuteNonQuery();
                if (queryResult == 1)
                    lblRes.Text = "msg record Created Successfully";

            }
            catch (Exception ex)
            {
                lblRes.Text = "Error: " + ex.Message;
            }
        }
        finally
        {
            if (conn != null)
                conn.Close();
        }

        if (!IsPostBack)
        {
            Load_GridData();
        }
    }
    protected void btnSendEmail_Click(object sender, EventArgs e)
    {

        if (DropDownList1.Text == "Gmail Server")
        {
            if (MailSender.SendMail(txtSender.Text, txtPassword.Text, txtEmail.Text, txtSubject.Text, txtAreas.Text))
            {
                Label5.Text = "Successfull.....";
            }
            else
            {
                Label5.Text = "not successfull";
            }
        }
        if (DropDownList1.Text == "Yahoo Mail Server")
        {
            if (MailSender.SendYahooMail(txtSender.Text, txtPassword.Text, txtEmail.Text, txtSubject.Text, txtAreas.Text))
            {
                Label5.Text = "Successfull.....";
            }
            else
            {
                Label5.Text = "not successfull";
            }
        }
        if (DropDownList1.Text == "Hot Mail Server")
        {
            Label5.Text = "Hot Mail Server";
        }
        if (DropDownList1.Text == "Duldulao Mail Server")
        {
            Label5.Text = "Duldulao Mail Server";
        }
    }
}
