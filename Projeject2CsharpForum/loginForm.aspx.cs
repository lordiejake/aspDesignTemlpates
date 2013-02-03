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

public partial class loginForm : System.Web.UI.Page
{
    System.Data.SqlClient.SqlConnection conn = null;
    //SqlConnection connz = null;
    MailSender log = new MailSender();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            if (Request.QueryString["Namesz"] != null)
            {
                Resultdz.Text = Request.QueryString["Namesz"];
            }

            PostAllMembers();
            ALLmembers();
        }
    }
    protected void BtnSubmitt_Click(object sender, EventArgs e)
    {

    }
    protected void BtnSubmitt_Click1(object sender, EventArgs e)
    {
        try
        {
            conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM tbl_usersWEB WHERE UserNamez ='" + TextUN.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string USERNAME = dr[3].ToString();
                    if (TextUN.Text == USERNAME.ToString())
                    {
                        Resultdz.Text = "UserName Is Already Used. Try other UserName";
                    }
                   
                }
            }
            else
            {
                double tln = double.Parse(TextLN.Text.Length.ToString());
                double tfn = double.Parse(TextFN.Text.Length.ToString());
                double tun = double.Parse(TextUN.Text.Length.ToString());
                double tpass = double.Parse(TextPASS.Text.Length.ToString());
                double temeil = double.Parse(TextEmail.Text.Length.ToString());

                double xtln = 0;
                double xtfn = 0;
                double xtun = 0;
                double xtpass = 0;
                double xtemeil = 0;


                if (tln > 0)
                {
                    xtln = 1;
                }
                else
                {
                    xtln = 0;
                }

                if (tfn > 0)
                {
                    xtfn = 1;
                }
                else
                {
                    xtfn = 0;
                }

                if (tun > 0)
                {
                    xtun = 1;
                }
                else
                {
                    xtun = 0;
                }

                if (tpass > 0)
                {
                    xtpass = 1;
                }
                else
                {
                    xtpass = 0;
                }

                if (temeil > 0)
                {
                    xtemeil = 1;
                }
                else
                {
                    xtemeil = 0;
                }

                double resultforCOUNTING = xtfn + xtln + xtpass + xtun + xtemeil;

                if (resultforCOUNTING == 5)
                {


                    try
                    {
                        try
                        {
                            conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
                            conn.Open();
                            System.Data.SqlClient.SqlCommand insertCommand = new System.Data.SqlClient.SqlCommand("Insert into [tbl_usersWEB] (LastNamez,FirstNamez,UserNamez,Passwordz,EmailAddressz) Values (@LN,@FN,@user,@Pass,@Em)", conn);
                            // insertCommand.Parameters.Add("Pic", SqlDbType.Image, 0).Value = ConvertImageToByteArray(imag, System.Drawing.Imaging.ImageFormat.Jpeg);
                            insertCommand.Parameters.Add(new SqlParameter("@LN", TextLN.Text));
                            insertCommand.Parameters.Add(new SqlParameter("@FN", TextFN.Text));
                            insertCommand.Parameters.Add(new SqlParameter("@user", TextUN.Text));
                            insertCommand.Parameters.Add(new SqlParameter("@Pass", TextPASS.Text));
                            insertCommand.Parameters.Add(new SqlParameter("@Em", TextEmail.Text));
                            int queryResult = insertCommand.ExecuteNonQuery();
                            if (queryResult == 1)
                            {
                                Resultdz.Text = "Registered Successfully";
                                Resultdz.Attributes.Add("style", "color:DarkGreen;font-weight:bold;");

                                if (MailSender.SendMailAdministrator(TextEmail.Text))
                                {

                                    //TextLN.Text = "";
                                    //TextFN.Text = "";
                                    //TextUN.Text = "";
                                    //TextPASS.Text = "";
                                    //TextEmail.Text = "";
                                    Sendmailsz.Text = "The confirmation is sent to your email address";
                                    Sendmailsz.Attributes.Add("style", "color:DarkGreen;font-weight:bold;");

                                    //Sendmailsz.Attributes.Add("style", "color:DarkGreen;font-weight:bold;");

                                }
                                else
                                {

                                    //TextLN.Text = "";
                                    //TextFN.Text = "";
                                    //TextUN.Text = "";
                                    //TextPASS.Text = "";
                                    //TextEmail.Text = "";

                                    Sendmailsz.Text = "Error: confirmation";
                                    Sendmailsz.Attributes.Add("style", "color:DarkGreen;font-weight:bold;");

                                }
                                Response.Redirect("loginForm.aspx?Namesz=" + "Registered Successfully");
                            }

                        }
                        catch (Exception ex)
                        {

                            Resultdz.Text = "Error: " + ex.Message;
                            Resultdz.Attributes.Add("style", "color:Red;font-weight:bold;");
                            Response.Redirect("loginForm.aspx?");

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
                    Resultdz.Text = "Enter all the data";
                }
            }

        }
        catch (Exception)
        {
            succes.Text = "failed to login";
        }
        finally
        {
            conn.Close();
        }

       
    }



    double uid;
    string emails = "lll";
    protected void login_Click(object sender, EventArgs e)
    {
       SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);    
       try
       {
           SqlCommand command = new SqlCommand("SELECT * FROM tbl_usersWEB WHERE UserNamez ='" + LogName.Text + "' AND Passwordz ='" + pass.Text + "'", conn);
           conn.Open();
           SqlDataReader dr = command.ExecuteReader();
           if (dr.HasRows)
           {
               while (dr.Read())
               {
                   //succes.Text = dr[1].ToString();
                   succes.Text = "Successfully login";
                   succes.Attributes.Add("style", "color:Green;font-weight:bold;");
                   LoginPerson.Text = dr[1].ToString() + " " + dr[2].ToString();
                   uid = double.Parse(dr[0].ToString());
                   emails = dr[5].ToString();
                   LoginPerson.Attributes.Add("style", "color:Black;font-weight:bold;");
                   LogName.Text = "";
                   pass.Text = "";
                  // Response.Redirect("Default.aspx");
                   Response.Redirect("CategoryForm.aspx?Namez=" + LoginPerson.Text + "&IDS=" + uid.ToString() + "&EM=" + emails.ToString());
               }
           }
           else 
           {
               succes.Text = "Incorrect Password or Email";
               succes.Attributes.Add("style", "color:Red;font-weight:bold;");
               LoginPerson.Text = "";
           }
           
       }
       catch (Exception)
       {
           succes.Text = "failed to login";
       }
       finally {
           conn.Close(); 
       }
    }

    void PostAllMembers()
    {
        GridView1.DataSource = ClassDataManager.Name_LOAD();
        GridView1.DataBind();
    }

    void ALLmembers()
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT        COUNT(UserCID) AS UserNumber  FROM            dbo.tbl_usersWEB", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    lblViewMembers.Text = "[" + dr[0].ToString() + "] Member/s";
                    

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
    protected void LogInAdmin_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString);
        try
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Administrator WHERE AdminUserName ='" + txtadminusername.Text  + "' AND AdminPassword ='" + txtadminpassword.Text + "'", conn);
            conn.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    LoginPerson.Text = dr[1].ToString();
                    uid = double.Parse(dr[0].ToString());
                    emails = dr[2].ToString();
                    LoginPerson.Attributes.Add("style", "color:Black;font-weight:bold;");
                    Response.Redirect("CategoryFormAdmin.aspx?Namez=" + LoginPerson.Text + "&IDS=" + uid.ToString() + "&EM=" + emails.ToString());
                    
                }
            }
            else
            {
                AdminStatus.Text = "failed to login: Incorrect UserName/Password";
            }

        }
        catch (Exception)
        {
            AdminStatus.Text = "failed to login";
        }
        finally
        {
            conn.Close();
        }
    }
}
