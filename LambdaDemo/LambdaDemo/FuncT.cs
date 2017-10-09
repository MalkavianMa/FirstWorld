using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{/// <summary>
 /// Func<T>委托
 ///   T 是参数类型，这是一个泛型类型的委托，用起来很方便的。
/// </summary>
    class FuncT
    {
        static void Main(string[] args)
        {
            Func<int, string> gwl = p => p + 10 + "返回类型为String";
            Console.WriteLine(gwl(10) + "1");
        }




    }
}
