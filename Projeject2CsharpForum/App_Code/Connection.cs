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
using System.Data.SqlClient;

/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
	public Connection()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static SqlConnection ConnectToServer()
    {
        string command = @"Server=duldulaokzes-pc\sqlexpress;Database=images;Trusted_Connection=Yes";
        SqlConnection connz = new SqlConnection(command);
        connz.Open();
        return connz;
    }
}
