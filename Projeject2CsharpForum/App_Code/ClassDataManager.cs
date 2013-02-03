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
using System.Collections.Generic;

/// <summary>
/// Summary description for ClassDataManager
/// </summary>
public class ClassDataManager
{
	public ClassDataManager()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private double iiddd;

    public double IIddd
    {
        get { return iiddd; }
        set { iiddd = value; }
    }

    
    public static List<ClassFields> Subject_Load(double idconfirmation)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT        tbl_TopicWEB.TopicID, tbl_TopicWEB.TopicDecription, COUNT(tbl_TopicWEB.TopicID) AS Number_of_Threds  FROM            tbl_TopicWEB INNER JOIN    tbl_ThreadWEB ON tbl_TopicWEB.TopicID = tbl_ThreadWEB.TopicID WHERE tbl_TopicWEB.CategoryID = '" + idconfirmation + "'GROUP BY tbl_TopicWEB.TopicID, tbl_TopicWEB.TopicDecription, tbl_TopicWEB.CategoryID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.TopicID = long.Parse(dr["TopicID"].ToString());
                            f.TopicDecription = dr["TopicDecription"].ToString();
                            f.Number_of_Threds = dr["Number_of_Threds"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> Subject_LoadZERO(double idconfirmation)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT        TopicID, TopicDecription, topicstatus  FROM tbl_TopicWEB   WHERE (topicstatus = 0)  AND CategoryID ='" + idconfirmation + "'GROUP BY TopicID, TopicDecription, topicstatus, CategoryID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.TopicID = long.Parse(dr["TopicID"].ToString());
                            f.TopicDecription = dr["TopicDecription"].ToString();
                            f.topicstatus = dr["topicstatus"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> Category_LoadZERO()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT        tbl_categoryWEB.CategoryID, tbl_categoryWEB.CategoryName, COUNT(tbl_TopicWEB.CategoryID) AS Number_of_Topic  FROM            tbl_TopicWEB INNER JOIN     tbl_categoryWEB ON tbl_TopicWEB.CategoryID = tbl_categoryWEB.CategoryID  GROUP BY tbl_categoryWEB.CategoryID, tbl_categoryWEB.CategoryName";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.CategoryID = long.Parse(dr["CategoryID"].ToString());
                            f.CategoryName = dr["CategoryName"].ToString();
                            f.Number_of_Topic = dr["Number_of_Topic"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> Category_LoadZEROzzzzzz()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT        CategoryID, CategoryName, CategoryStatus  FROM            dbo.tbl_categoryWEB    WHERE        (CategoryStatus = 0)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.CategoryID = long.Parse(dr["CategoryID"].ToString());
                            f.CategoryName = dr["CategoryName"].ToString();
                            f.CategoryStatus = long.Parse(dr["CategoryStatus"].ToString());
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> Name_LOAD()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {
            string sql = "SELECT        LastNamez + '' + FirstNamez AS Names, EmailAddressz   FROM  dbo.tbl_usersWEB";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.Names = dr["Names"].ToString();
                            f.EmailAddressz = dr["EmailAddressz"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> Topics_LoadwIDENTIFICATION(double idconfig)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {

            
            string sql = "SELECT *  FROM tbl_TopicWEB WHERE TopicID = '" + idconfig  + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.TopicDecription = " Topic: ----- " + dr["TopicDecription"].ToString() + "-----";
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> Topics_LoadwIDENTIFICATIONwthreads(double idconfigz)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {


            string sql = "SELECT        tbl_ThreadWEB.ThreadID, tbl_ThreadWEB.ThreadTopic, COUNT(tbl_ThreadWEB.ThreadID) AS Posts,  dbo.tbl_ThreadWEB.ThreadViewCount  FROM            tbl_TopicWEB INNER JOIN   tbl_ThreadWEB ON tbl_TopicWEB.TopicID = tbl_ThreadWEB.TopicID INNER JOIN      tbl_PostWEB ON tbl_ThreadWEB.ThreadID = tbl_PostWEB.ThreadID WHERE tbl_TopicWEB.TopicID = '" + idconfigz + "'GROUP BY tbl_ThreadWEB.ThreadID, tbl_ThreadWEB.ThreadTopic,  dbo.tbl_ThreadWEB.ThreadViewCount";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.ThreadID = long.Parse(dr["ThreadID"].ToString());
                            f.ThreadTopic = "----" + dr["ThreadTopic"].ToString();
                            f.Posts = dr["Posts"].ToString();
                            f.ThreadViewCount = long.Parse(dr["ThreadViewCount"].ToString());
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> ThreadsWoPostsz(double idconfigz)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {


            string sql = "SELECT        ThreadID, ThreadTopic, ThreadStatus, ThreadViewCount  FROM dbo.tbl_ThreadWEB   WHERE   (ThreadStatus = 0) AND TopicID = '" + idconfigz + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.ThreadID = long.Parse(dr["ThreadID"].ToString());
                            f.ThreadTopic = "----" + dr["ThreadTopic"].ToString();
                            f.ThreadStatus = long.Parse(dr["ThreadStatus"].ToString());
                            f.ThreadViewCount = long.Parse(dr["ThreadViewCount"].ToString());
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> POSTSz(double threadi)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {


            string sql = "SELECT        tbl_usersWEB.LastNamez + ' ' + tbl_usersWEB.FirstNamez AS userzx, tbl_usersWEB.EmailAddressz, tbl_PostWEB.Post, tbl_PostWEB.PostDate   FROM            tbl_usersWEB INNER JOIN   tbl_PostWEB ON tbl_usersWEB.UserCID = tbl_PostWEB.UserCID WHERE tbl_PostWEB.ThreadID = '" + threadi + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.userzx = dr["userzx"].ToString() + "\n" + "[" + dr["EmailAddressz"].ToString() + "]";
                            f.Post = dr["Post"].ToString();
                            f.PostDate = dr["PostDate"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }


    public static List<ClassFields> THREADINGZ(double threadi)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {


            string sql = "SELECT * FROM tbl_ThreadWEB WHERE ThreadID = '" + threadi + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.ThreadTopic = "----------*" + dr["ThreadTopic"].ToString() + "*----------";
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> THREADINGZbySpecificUser(double threadi)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {


            string sql = "SELECT        tbl_usersWEB.LastNamez + ',' + tbl_usersWEB.FirstNamez AS UserBy, tbl_usersWEB.EmailAddressz    FROM            tbl_ThreadWEB INNER JOIN        tbl_usersWEB ON tbl_ThreadWEB.UserCID = tbl_usersWEB.UserCID WHERE tbl_ThreadWEB.ThreadID = '" + threadi + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.UserBy = dr["UserBy"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> CountAllCategorywithTopics()
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {


            string sql = "SELECT        COUNT(CategoryID) AS Withtopics  FROM            dbo.tbl_categoryWEB     WHERE        (CategoryStatus = 1)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.Withtopics = dr["Withtopics"].ToString();
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }

    public static List<ClassFields> DisplaySpecificCategory(double specificid)
    {
        List<ClassFields> list = new List<ClassFields>();
        using (SqlConnection conn = ClassConnection.ConnectToServer())
        {


            string sql = "SELECT        dbo.tbl_categoryWEB.*  FROM            dbo.tbl_categoryWEB WHERE CategoryID = '" + specificid + "'";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            ClassFields f = new ClassFields();
                            f.CategoryName = "-----" + dr["CategoryName"].ToString() + " " + "[Category]";
                            list.Add(f);
                        }
                    }
                }
            }
        }
        return list;
    }
}
