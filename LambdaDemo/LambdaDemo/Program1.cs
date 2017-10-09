using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// 匿名方法
    /// </summary>
    class Program1
    {
        delegate int calculator(int x, int y);
        static void Main()
        {
            calculator cal = delegate (int num1, int num2) { return num1 + num2; };
            int he = cal(1, 1);
            Console.Write("匿名方法"+he);
            Console.ReadLine();
        }
    }
}
