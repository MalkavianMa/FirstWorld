using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Configuration;
using System.Data;

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
          // context.Response.ContentType = "text/html";
          //string a = @"<script  type=" + "\"text/javascript\"" + @">alert(2)</script>";
            //===============================================================  
            //获取查询条件:【用户id,开始时间，结束时间，关键字】  
            string AdminName, startTime, endTime, QuanXian;
            AdminName = startTime = endTime = QuanXian = "";
            //获取前台传来的值  
            if (null != context.Request.QueryString["AdminName"])
            {//获取前台传来的值  
                AdminName = context.Request.QueryString["AdminName"].ToString().Trim();
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
            if (AdminName != "")
            {
                strWhere.AppendFormat(" WorkerRealName like '%{0}%' and ", AdminName);
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

            String sql = ConfigurationManager.ConnectionStrings["BookShopconnStr"].ToString();

           // SqlHelper.ExecuteDataSet(sql, strWhere, parms);
            //DataSet ds = Bnotice.GetList(strWhere.ToString());  //调用不分页的getlist   
        //    DataSet ds = GetListByPage(strWhere.ToString(), oderby, (page - 1) * pageRows + 1, page * pageRows);
        //    int count = Class1.GetRecordCount(strWhere.ToString());//获取条数  
        //    string strJson = ToJson.Dataset2Json(ds, count);//DataSet数据转化为Json数据  
        //    context.Response.Write(strJson);//返回给前台页面  
        //    context.Response.End();  
        //
        }
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
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}