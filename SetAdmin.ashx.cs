using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{

    /// <summary>
    /// SetAdmin 的摘要说明
    /// </summary>
    public class SetAdmin : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string operation, firstname, password, workerID, adminRightID,adminID;
            if (!string.IsNullOrEmpty(context.Request.QueryString["test"]))
            {
                operation = context.Request.QueryString["test"].ToString();
                switch (operation)
                {
                    case "add":
                        adminID = context.Request.QueryString["adminID"].ToString();
                        firstname = context.Request.QueryString["firstname"].ToString();
                        password = context.Request.QueryString["password"].ToString();
                        workerID = context.Request.QueryString["workerID"].ToString();
                        adminRightID = context.Request.QueryString["adminRightID"].ToString();
                        if (!string.IsNullOrEmpty(firstname)&&!string.IsNullOrEmpty(password)&&!string.IsNullOrEmpty(workerID)&&!string.IsNullOrEmpty(adminRightID))//AdminName
                        {

                            StringBuilder sql = new StringBuilder();
                            sql.Append("insert into V_admin_MgPersonFiles (");
                            sql.Append("[AdminName],[AdminPassword],[AdminRightName],[WorkerRealName])");
                            sql.Append("values (");
                            sql.Append("@AdminName,@AdminPassword,@AdminRightName,@WorkerRealName)");

                            SqlParameter[] para = new SqlParameter[]
                        {
                            new SqlParameter("@AdminName",firstname),
                            new SqlParameter("@AdminPassword",password),
                            new SqlParameter("@AdminRightName",adminRightID),
                              new SqlParameter("@WorkerRealName",workerID),

                        };

                            int count = SqlHelper.ExecuteNonQuery(Connstr, CommandType.Text, sql.ToString(), para);
                            if (count > 0)
                            {
                                context.Response.Write("T");//返回给前台页面  
                            }
                        }


                        //        url: "SetAdmin.ashx?test=" + test + "&firstname=" + firstname + "&password=" + password + "&workerID=" + workerID + "&adminRightID=" + adminRightID + "&message" + message, // "&adminRightID=" + adminRightID + "&message=" + message,  
                        //  if (null != context.Request.QueryString["test"])
                        //if (!string.IsNullOrEmpty(context.Request.QueryString["firstname"]))//AdminName
                        //{
                        //    firstname = context.Request.QueryString["firstname"].ToString();
                        //}
                        //if (!string.IsNullOrEmpty(context.Request.QueryString["password"]))//password
                        //{
                        //    password = context.Request.QueryString["password"].ToString();
                        //}
                        //if (!string.IsNullOrEmpty(context.Request.QueryString["workerID"]))//WorkerRealName
                        //{
                        //    workerID = context.Request.QueryString["workerID"].ToString();
                        //}
                        //if (!string.IsNullOrEmpty(context.Request.QueryString["adminRightID"]))//AdminRightName
                        //{
                        //    adminRightID = context.Request.QueryString["adminRightID"].ToString();
                        //}
                        //     AddUser();
                     
                        //  context.Response.End();
                        // Query(context);
                        break;
                    case    "modify":
                        adminID = context.Request.QueryString["adminID"].ToString();
                         firstname = context.Request.QueryString["firstname"].ToString();
                        password = context.Request.QueryString["password"].ToString();
                        workerID = context.Request.QueryString["workerID"].ToString();
                        adminRightID = context.Request.QueryString["adminRightID"].ToString();
                        if (!string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(workerID) && !string.IsNullOrEmpty(adminRightID))//AdminName
                        {
                            StringBuilder sql = new StringBuilder();
                                sql.Append("UPDATE  V_admin_MgPersonFiles  (");
                                sql.Append("SET ");
                                sql.Append(" AdminName=@AdminName");
                                sql.Append(" AdminPassword=@AdminPassword");
                                sql.Append(" AdminRightName=@AdminRightName");
                                sql.Append(" WorkerRealName=@WorkerRealName");

                        //    sql.Append("[AdminName],[AdminPassword],[AdminRightName],[WorkerRealName])");
                        //    sql.Append("values (");
                        //    sql.Append("@AdminName,@AdminPassword,@AdminRightName,@WorkerRealName)");

                                SqlParameter[] para = new SqlParameter[]
                        {
                            new SqlParameter("@AdminName",firstname),
                            new SqlParameter("@AdminPassword",password),
                            new SqlParameter("@AdminRightName",adminRightID),
                              new SqlParameter("@WorkerRealName",workerID),

                        };

                          int count = SqlHelper.ExecuteNonQuery(Connstr, CommandType.Text, sql.ToString(), para);
                          if (count > 0)
                          {
                              context.Response.Write("T");//返回给前台页面  
                          }

                        }
                        break;
                    case "edit":
                        break;
                    default:
                        Query(context);
                        break;
                }
            }
            else
            {
                Query(context);
            }


        }

        #region 查询方法
        /// <summary>
        /// 查询方法
        /// </summary>
        /// <param name="context"></param>
        public void Query(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            // context.Response.ContentType = "text/html";
            //string a = @"<script  type=" + "\"text/javascript\"" + @">alert(2)</script>";
            //===============================================================  
            //获取查询条件:【用户id,开始时间，结束时间，关键字】  
            string UserName, startTime, endTime, QuanXian, test;
            UserName = startTime = endTime = QuanXian = test = "";

            //  if (!string.IsNullOrEmpty(context.Request.QueryString["test"]))
            if (null != context.Request.QueryString["test"])
            {
                test = context.Request.QueryString["test"].ToString();
            }
            //获取前台传来的值  
            if (null != context.Request.QueryString["UserName"])
            {//获取前台传来的值  
                UserName = context.Request.QueryString["UserName"].ToString().Trim();// 取前台JS中 queryParams.UserName
            }
            if (null != context.Request.QueryString["StartTime"])
            {
                startTime = context.Request.QueryString["StartTime"].ToString().Trim();
            }
            if (null != context.Request.QueryString["EndTime"])
            {
                endTime = context.Request.QueryString["EndTime"].ToString().Trim();
            }
            if (null != context.Request.QueryString["QuanXian"])
            {
                QuanXian = context.Request.QueryString["QuanXian"].ToString().Trim();
            }

            //================================================================  
            //获取分页和排序信息：页大小，页码，排序方式，排序字段  
            int pageRows, page;
            pageRows = 10;
            page = 1;
            string order, sort, oderby; order = sort = oderby = "";
            if (null != context.Request.QueryString["rows"])
            {
                pageRows = int.Parse(context.Request.QueryString["rows"].ToString().Trim());

            }
            if (null != context.Request.QueryString["page"])
            {

                page = int.Parse(context.Request.QueryString["page"].ToString().Trim());

            }
            if (null != context.Request.QueryString["sort"])
            {

                order = context.Request.QueryString["sort"].ToString().Trim();

            }
            if (null != context.Request.QueryString["order"])
            {

                sort = context.Request.QueryString["order"].ToString().Trim();

            }


            //===================================================================  
            //组合查询语句：条件+排序  
            StringBuilder strWhere = new StringBuilder();
            if (UserName != "")
            {
                strWhere.AppendFormat(" WorkerRealName  like '%{0}%' and ", UserName);
            }
            if (QuanXian != "")
            {
                strWhere.AppendFormat(" AdminRightName like '%{0}%' and ", QuanXian);
            }
            if (startTime != "")
            {
                strWhere.AppendFormat(" ActiveDate >= '{0}' and ", startTime);
            }
            if (endTime != "")
            {
                strWhere.AppendFormat(" ActiveDate <= '{0}' and ", endTime);
            }

            //删除多余的and  
            int startindex = strWhere.ToString().LastIndexOf("and");//获取最后一个and的位置  
            if (startindex >= 0)
            {
                strWhere.Remove(startindex, 3);//删除多余的and关键字  
            }
            if (sort != "" && order != "")
            {
                //strWhere.AppendFormat(" order by {0} {1}", sort, order);//添加排序  
                oderby = order + " " + sort;
            }


            // SqlHelper.ExecuteDataSet(sql, strWhere, parms);
            //DataSet ds = Bnotice.GetList(strWhere.ToString());  //调用不分页的getlist   
            DataSet ds = GetListByPage(strWhere.ToString(), oderby, (page - 1) * pageRows + 1, page * pageRows);
            int count = GetRecordCount(strWhere.ToString());//获取条数  
            string strJson = ToJson.Dataset2Json(ds, count);//DataSet数据转化为Json数据  
            context.Response.Write(strJson);//返回给前台页面  
            context.Response.End();
            //
        }
        #endregion
        string _Connstr;
        /// <summary>
        /// 数据库连接字段,SqlHelper类里也有,多写了一个连接字段需要优化
        /// </summary>
        public string Connstr
        {
            get
            {
                return "Data Source=.;Initial Catalog=GreenGrocer;Integrated Security=true;";
                // return ConfigurationManager.ConnectionStrings["BookShopconnStr"].ToString();
            }
            set { _Connstr = value; }
        }

        #region 分页获取数据列表
        /// <summary>
        /// 获取一个分页的dataset
        /// </summary>
        /// <param name="strWhere">条件语句</param>
        /// <param name="orderby">排序语句</param>
        /// <param name="startIndex">起始索引数</param>
        /// <param name="endIndex">结束索引数</param>
        /// <returns></returns>
        private DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            //String sql = ConfigurationManager.ConnectionStrings["BookShopconnStr"].ToString();

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.AdminID desc");
            }
            strSql.Append(")AS Row, T.*  from V_admin_MgPersonFiles T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);

            return SqlHelper.ExecuteDataSet(Connstr, strSql.ToString(), null);
            // throw new NotImplementedException();
        }

        /// <summary>
        /// 获取记录总数 
        /// </summary>
        /// <param name="strWhere">查询过滤条件字段</param>
        /// <returns></returns>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM V_admin_MgPersonFiles");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = SqlHelper.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        #endregion

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
///<summary>
///2017年6月19日17:16:06 sql分页
///</summary>
//select *from (  select ROW_NUMBER() over (order by r.[AddDate]   desc) as how ,r.* from [tbButton] r) t where t.how between 1 and 5
//  SELECT ROW_NUMBER() OVER (order by T.AdminID desc)AS Row, T.*  from V_admin_MgPersonFiles T 
//   alter table V_admin_MgPersonFiles add WorkerRealName  varchar(18) 
/// <summary>  
/// 分页获取数据列表  
/// </summary>  
//public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
//{
//    StringBuilder strSql = new StringBuilder();
//    strSql.Append("SELECT * FROM ( ");
//    strSql.Append(" SELECT ROW_NUMBER() OVER (");
//    if (!string.IsNullOrEmpty(orderby.Trim()))
//    {
//        strSql.Append("order by T." + orderby);
//    }
//    else
//    {
//        strSql.Append("order by T.AdminID desc");
//    }
//    strSql.Append(")AS Row, T.*  from V_admin_MgPersonFiles T ");
//    if (!string.IsNullOrEmpty(strWhere.Trim()))
//    {
//        strSql.Append(" WHERE " + strWhere);
//    }
//    strSql.Append(" ) TT");
//    strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
//    return DbHelperSQL.Query(strSql.ToString());
//}  