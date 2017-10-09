using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{

    /// <summary>
    /// lambda表达式
    /// </summary>
    class Program2
    {
        delegate int calculator(int x, int y);//委托类型
        static void Main()
        {
            calculator cal = (x, y) => x + y;//lambda表达式,代码一个比一个简洁
            int he = cal(1, 1);
            Console.Write("lambda表达式"+he);
            Console.ReadLine();
            //若要创建 Lambda 表达式，需要在 Lambda 运算符 => 左侧指定输入参数（如果有），
            //然后在另一侧输入表达式或语句块。
            //例如，lambda 表达式 x => x * x 指定名为 x 的参数并返回 x 的平方值。 如上面的示例所示，你可以将此表达式分配给委托类型：
        }
    }
}
