using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntrustDemon
{
    class Program
    {//委托也是引用方法的一种类型，创建了委托，就可以声明委托变量，也就是委托实例化
        //实例化的委托就是委托的对象，可以为委托对象分配方法,,,，也就是把方法名赋予委托对象。
        //一旦为委托对象分配了方法，委托对象将与该方法具有完全相同的行为。
        //委托对象的使用可以像其他任何方法一样,，具有参数和返回值
        public delegate int Jisuan(int one, int two);//定义了一个名为Jisuan的委托,该委托封装了包含俩个整型参数,
        //且返回值为整型的方法
        Jisuan js;//声明js为委托的对象,就可以把方法名赋给该对象
        //方法的分配比较自由,任何与委托的签名(由返回类型和参数组成)匹配的方法都可以分配给该委托的对象..
        //这样就可以通过编程方式来更改方法调用,还可以向现有类中插入新代码.。只要知道委托的签名，便可以分配自己的
        //委托方法
        public int multiplication(int one, int two)
        {
           // Console.WriteLine(one * two);
            return one * two;
        }

        static void Main(string[] args)
        {
            Program sl = new Program();
            Jisuan js = sl. multiplication;
            js(8, 8);
        }
    }
}
