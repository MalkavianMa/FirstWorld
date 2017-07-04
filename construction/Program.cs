using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();//使用默认构造函数
            Person p2 = new Person("M", 22);//使用带两个参数的构造函数
            Console.WriteLine(p1._name+"/0"+p1._age+"/n"+p2._name+"/0"+p2._age);
            Console.ReadLine();
        }
    }
}
