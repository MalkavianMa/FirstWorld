using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace BigIntegerDemon
{  //C#经历几个版本的变革,,虽然在大的编程方向和设计理念上没有引起太多的变化
    //但每次版本更新都带来一些新的特性,,这些特性使程序开发更加方便..本节将介绍几个比较常用的
    //新特性,,使读者对这些新特性能有一个大致的印象,,具体如何使用
    //还需要读者在实践中不断加深理解

    //2.5.1大整数类型BigInteger
    //在C#4.0中增加了一个数据类型BigInteger,,即大整数类型,,它位于System.Numerics命名空间下.
    //BigInteger类型是不可变类型,,代表一个任意大的整数,,他不同于.Net Framework 中的其他类型,,
    //其值理论上已没有上部或下部的界限..
    //BigInteger类型的成员与其他整数类型的近乎相同
    //可通过多种方法实例化BigInteger对象
    //(1)用new 关键字并提供任何整数或浮点值以作为BigInteger构造函数的一个参数.下面
    //的示例,阐释如何使用new关键字实例化BigInteger值
    //BigInteger big=new BigInteger(179032.6541);
    //BigInteger bigInt=new BigInteger(934157136952);

    //以上代码,第一行声明了BigInteger类型的对象big,,参数是浮点值,,但仅保留小数点之前的整数值
    //..第二行声明了BigInteger类型的对象 bigInt,,参数是一个大整数..
    
    //(2).声明BigInteger变量并向其分配一个值,,分配的值可以是任意数值,,只要该值为整形即可,,
    //下面的示例利用赋值从Int64创建BigInteger值.
    //longValue=6315489358112;
    //BigInteger big=longValue;
    //以上代码先声明了一个long类型的变量value 并赋值..第二行将该值再分配给BigInteger
    //类型的变量big

    //(3)通过强制类型转换实例化一个BigInteger对象,,使其值可以超出现有数值类型的范围..
    //BigInteger big=(BigInteger)179032.6541;
    //BigInteger bigInt=(BigInteger)64312.65m;
    //上面的代码中直接使用强制类型转换的方式声明BigInteger的对象,,仅保留整数部分的值
    //可以像使用其他任何整数类型一样使用BigInteger实例..BigInteger重载标准数值运算符,
    //能够执行基本数学运算,,如加法、减法、除法、乘法、求反和一元求反。。
    //还可以使用标准数值运算符对两个BigInteger值进行比较..与其他该整型类似,,BigInteger还支持
    //按位运算符..对于不支持自定义运算符的语言,,BigInteger结构还提供了用于执行
    //数学运算的等效方法.
    //其中包括Add、Divide、Multiply、Negate、Subtract和多种其他内容
        //BigInteger结构的许多成员直接对应于Math类(该类提供处理基元数值类型的功能)的成员.
    //此外,,BigInteger增加了自己特有的成员,,包括:
    //Sign:可以返回表示BigInteger值符号的值
    //Abs:可以返回BigInteger值的绝对值
    //DivRem:可以返回除法运算的商和余数
    //GreatestCommonDivisor:可以返回两个BigInteger值的最大公约数

    //eg:接受用户输入的数字,,计算斐波那契数..通过本例学习BigInteger类型的使用以及为何要增加这个
    //新的数据类型

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("请你输入数字");
                var number = int.Parse(Console.ReadLine());
                var value = Fibonacci(number);
                int i=0;
                Console.WriteLine(i++);//i=i+1;
                Console.WriteLine(++i);//i+1=i;
                Console.WriteLine(value);
                BigInteger value1 = Fibonaccil(number);
                Console.WriteLine(value1);
                Console.WriteLine("是否继续录入数字?Y/N");
            } while (Console.ReadLine().ToLower()=="y");
        }

        private static BigInteger Fibonaccil(int x)
        {
            var previewValue = new BigInteger(-1);
            var currentResult = new BigInteger(1);
            for (int i = 0; i < x; ++i)
            {
                var sum = currentResult + previewValue;
                previewValue = currentResult;
                currentResult = sum;

            }
            return currentResult;
        }
        public static int Fibonacci(int x)
        {
            var previousValue = -1;
            var currentResult = 1;
            for (int i = 0; i < x; ++i)
            {
                var sum = currentResult + previousValue;
                previousValue = currentResult;
                currentResult = sum;
            }
            return currentResult;
        }
    }
}
