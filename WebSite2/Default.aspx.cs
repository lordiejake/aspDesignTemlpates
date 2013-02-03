using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            txtSearch.Text = "ok";
            txtSearch2.Text = "nice!";
        }
    }
    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {

    }
    protected void txtSearch2_TextChanged(object sender, EventArgs e)
    {

    }
}