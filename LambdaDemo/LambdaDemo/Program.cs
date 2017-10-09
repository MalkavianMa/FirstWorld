using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// 委托如下,将方法视为参数传递,Program1为匿名方法
    /// Program2为lambda表达式
    /// </summary>
    class Program
    {
        delegate int calcaulator(int x, int y);//委托类型 
        static void Main(string[] args)
        {
            calcaulator cal = new calcaulator(adding);
            int He = cal(1, 1);
            Console.Write("委托"+He);
            Console.ReadLine();
        }

       
        public static int adding(int x, int y)
        {
            return x + y;
            //throw new NotImplementedException();
        }
    }
}
