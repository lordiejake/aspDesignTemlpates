﻿using System;
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
/// Summary description for ClassConnection
/// </summary>
public class ClassConnection
{
	public ClassConnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static SqlConnection ConnectToServer()
    {
        string connect = ConfigurationManager.ConnectionStrings["dbaseconnection"].ConnectionString;
        SqlConnection conn = new SqlConnection(connect);
        conn.Open();
        return conn;
    }
}
