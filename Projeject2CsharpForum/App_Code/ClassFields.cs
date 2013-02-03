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

/// <summary>
/// Summary description for ClassFields
/// </summary>
public class ClassFields
{
	public ClassFields()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Number_of_Threds { set; get; }
    public string topicstatus { set; get; }

    public long TopicID { set; get; }
    public string TopicDecription { set; get; }

    public long ThreadID { set; get; }
    public string ThreadTopic { set; get; }
    public string Posts { set; get; }

    public long CategoryID { set; get; }
    public long CategoryStatus { set; get; }
    public string CategoryName { set; get; }
    public string Number_of_Topic { set; get; }

    public long ThreadStatus { set; get; }
    public long ThreadViewCount { set; get; }
    public string userzx { set; get; }
    public string EmailAddressz { set; get; }
    public string Post { set; get; }
    public string PostDate { set; get; }

    public string UserBy{ set; get; }

    public string Names { set; get; }

    public string Withtopics { set; get; }
    
}
