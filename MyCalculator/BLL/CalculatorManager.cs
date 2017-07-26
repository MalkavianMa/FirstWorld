using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using System.Data;

namespace BLL
{
    public class CalculatorManager
    {
        CalculatorService dll = new CalculatorService();
        public int ADDResult(string numOne, string numTwo, string sym, string CalculateReslut)
        {
            return dll.ADDResultSQL(numOne, numTwo, sym, CalculateReslut);
        }
        //public DataSet GetAllHistory()
        //{
        //    return dll.SelectHistory();
        //}
        public DataTable GetAllHistory()
        {
            return dll.SelectHistory();
        }
    }
}
