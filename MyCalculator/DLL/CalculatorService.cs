using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DLL
{
    public class CalculatorService
    {
        public int ADDResultSQL(string numOne,string numTwo,string sym,string CalculateReslut)
        {
            string sql = " insert into Result (OneNum,TwoNum,Sym,Result)values(@numOne,@numTwo,@sym,@CalculateReslut) ";
            SqlParameter[] para = new SqlParameter[4];
            para[0] = new SqlParameter("@numOne", numOne);
            para[1] = new SqlParameter("@numTwo", numTwo);
            para[2] = new SqlParameter("@sym", sym);
            para[3] = new SqlParameter("@CalculateReslut", CalculateReslut);

            return DBHelper.ExecuteNonQuery(sql, CommandType.Text, para);

        }

        public DataTable SelectHistory()
        {
            string sql = "  select top 10 OneNum,TwoNum,Sym,Result from Result order by addtime desc";
            return DBHelper.ExecuteDataTable(sql, CommandType.Text, null);
        }
    }
}
