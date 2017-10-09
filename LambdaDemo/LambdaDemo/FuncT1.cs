using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class FuncT1
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> gwl = (p, j) =>
            {
                if (p + j == 10)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(gwl(5, 5) + "");   //打印‘True’，z对应参数b，p对应参数a
            Console.ReadKey();
        }
    }
}
