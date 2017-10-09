using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{/// <summary>
/// "Lambda表达式"是一个特殊的匿名函数，
/// 是一种高效的类似于函数式编程的表达式，
/// Lambda简化了开发中需要编写的代码量。
/// 它可以包含表达式和语句，
/// 并且可用于创建委托或表达式目录树类型，
/// 支持带有可绑定到委托或表达式树的输入参数的内联表达式。
/// 所有Lambda表达式都使用Lambda运算符=>，
/// 该运算符读作"goes to"。Lambda运算符的左边是输入参数(如果有)，右边是表达式或语句块。
/// Lambda表达式x => x * x读作"x goes to x times x"。举几个简单的Lambda表达式，如下：
/// </summary>
    class LambdaDemo
    {
        delegate bool MyBol(int x, int y);
        delegate bool MyBol_2(int x, string y);
        delegate int calculator(int x, int y);//委托类型

        delegate void VS();

        static void Main(string[] args)
        {
            MyBol Bol = (x, y) => x == y;
            MyBol_2 Bol_2 = (x, s) => s.Length > x;
            calculator C = (X, Y) => X * Y;
            VS S = () => Console.Write("我是无参数lambda表达式");
          //  Console.Write("无参数");
            //Console.ReadLine();

            //
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);//奇数
            //
            List<People> people = LoadData();//初始化
             IEnumerable<People> results = people.Where(delegate (People p) { return p.age > 20; });
             //Console.Write(); Console.ReadLine();
        }

        private static List<People> LoadData()
        { List<People> people = new List<People>();//创建泛型对象

            People p1 = new People(21, "郭襄");//创建一个对象
            People p2 = new People(21, "吴颖");//创建一个对象
            People p3 = new People(20, "慕青");//创建一个对象
            People p4 = new People(23, "陆判");//创建一个对象
            people.Add(p1);//添加一个对象
            people.Add(p2);//这种注释让我感觉很弱 取消注释
            people.Add(p3);
            people.Add(p4);


            return people;
        }
    }

    public class  People
    {
        public int age { get; set; }//设置属性

        public string name { get; set; }//设置属性
        public People( int age,string name)//设置属性(构造函数构造)
        {
            this.age = age;//初始化属性值age
            this.name = name;//初始化属性值name
        }
    }
}
