using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;


/// <summary>
/// Summary description for MailSender
/// </summary>
public class MailSender
{
    public MailSender()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static bool SendMail(string gMailAccount, string password, string to, string subject, string message)
    {
        try
        {
            NetworkCredential loginInfo = new NetworkCredential(gMailAccount, password);
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(gMailAccount);
            msg.To.Add(new MailAddress(to));
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = loginInfo;
            client.Send(msg);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static bool SendMailAdministrator(string to)
    {
        try
        {
            NetworkCredential loginInfo = new NetworkCredential("duldulaojakes@gmail.com", "123jakes123");
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("duldulaojakes@gmail.com");
            msg.To.Add(new MailAddress(to));
            msg.Subject = "C# tutorials: Forum Membership.";
            msg.Body = "Hello , \n\n\n\n Welcome to duldulao tutorials about c#.\n\n\n You are already a member. Thank you.\n\n" + DateTime.Now.ToString();
            msg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = loginInfo;
            client.Send(msg);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    private string Usern;
    private string Pass;
    public string USERN
    {
        get { return Usern; }
        set { Usern = value; }
    }
    public string PASS
    {
        get { return Pass; }
        set { Pass = value; }
    }

    public SqlDataReader LOGIN(SqlConnection connz)
    {
        string sqlSelect = "SELECT * FROM User WHERE UserName='" + Usern + "'AND Password='" + Pass +"'";
        SqlCommand cmd = new SqlCommand(sqlSelect, connz);
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }

    public static bool SendYahooMail(string yMailAccount, string password, string to, string subject, string message)
    {
        try
        {
            NetworkCredential loginInfo = new NetworkCredential(yMailAccount, password);
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(yMailAccount);
            msg.To.Add(new MailAddress(to));
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("plus.pop.mail.yahoo.com");
            client.Port = 995;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = loginInfo;
            client.Send(msg);

            return true;
        }
        catch (Exception)
        {
            return false;
        }


    }
}
