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
        //委托方法。
        //将方法作为参数进行应用的能力,使委托成为定义回调方法的理想选择..
        //

        int NumJs;
        int Cb;
        public int multiplication(int one, int two)
        {
 //    Console.WriteLine(one * two);//通过委托可以调用方法
            return one * two;
        }
        //1委托类似于C++函数指针,,但它是类型安全的.
        //2委托允许将方法作为参数进行传递
        //3委托可用于定义回调方法
        //4委托可以链接在一起;;例如,,可以对一个事件调用多个方法
        //5方法不需要与委托签名精确匹配
        static void Main(string[] args)
        {    //构造委托对象时,通常提供委托将包装的方法的名称或使用匿名方法..实例化委托后,委托将把对它进行的方法调用传递给方法
            //来自方法的返回值(如果有)由委托返回给调用方,,这称为调用委托..
            //可以将一个实例化的委托视为被包装的方法本身来调用该委托 eg:
            Program sl = new Program();
            Jisuan js = sl. multiplication;//实例化委托Jisuan                
            js(8, 8);//调用委托
            sl.NumJs = js(8, 100);//委托的很好理解
         //   Console.WriteLine(sl.NumJs);
      //   string key=   Console.ReadKey(true).Key.ToString ();//readkey 使用不是很理解 
       //  Console.WriteLine(key);
          //  Console.ReadLine();

            //调用JiSuanCallBack方法,并把前面定义的Jisuan委托的实例js传递给该方法
         sl.Cb=   sl.JiSuanCallBack(9, 9, js);

         JiSuanClass jsc = new JiSuanClass();
         Jisuan js1 = jsc.He;
         Jisuan js2 = jsc.Shang;
         Jisuan js3 = sl.multiplication;
//调用委托时,,它可以调用多个方法,,,这称为多路广播..若要向委托的方法列表(调用列表)中添加额外的方法
//只需要使用加法运算符或加法赋值运算符("+"或"+=")添加委托..eg:
         Jisuan jsa = js1 + js2;
         jsa += js3;
            //此时,jsa在调用列表中包含三个方法:multiplication,He,Shang,,原来的三个委托js1,js2,js3保持不变..调用jsa时
            //,,将按顺序调用所有这三个方法..如果委托使用引用参数,,则引用将依次传递给三个方法中的每个方法..
            //由一个方法引起的更改对下一个方法是可见的..如果任一方法引发了异常,,而在该方法内未捕获异常,,
            //则该异常将传递给委托的调用方,,并且不再对调用列表中后面的方法进行调用..如果委托具有返回值/或输出参数,它将
            //返回最后调用的方法的返回值和参数..若要从调用列表中移除方法,,请使用减法运算符或减法赋值运算符("-","-=")./eg:

         jsa -= js1;
         int numJ = jsa(12, 6);//为了证明以上结论,.及调用顺序,,返回是否覆盖
         Jisuan js4;
         js4 = jsa - js2;
            //由于委托类派生自System.Delegate,,所以可在委托上调用该类定义的方法和属性..eg:
            //为了找出委托的调用列表中的方法数,,可以编写下面的代码:
         int Number = jsa.GetInvocationList().GetLength(0);
            //多路广播委托广泛用于事件处理中..事件源对象向已注册接收该事件的接收方对象发送事件通知..
            //为了为事件注册,,接收方创建了旨在处理事件的方法
            //然后为该方法创建委托并将该委托传递给事件源
            //事件发生时,,源将调用委托,,然后,,委托调用接收方的事件处理方法并传送事件数据
            //给定事件的委托类型由事件源定义
  
        }
        //委托类型派生字.NET Framework中的Delegate类..委托类型是密封的,,不能从Delegate中派生委托类型,,也不可能从中派生自定义类.
        //由于实例化委托是一个对象,,所以可以将其作为参数进行传递,也可以将其赋值给属性.
        //这样,,方法便可以将一个委托作为参数来接受,,并且以后可以调用该委托,,这称为异步回调,,
        //是在较长的进程完成后用来通知调用方的常用方法..
        //以这种方式使用委托时,,使用委托的代码无需了解所用方法的实现方面的任何信息..此功能类似于接口所提供的封装..
        //回调的另一个常见用法是定义自定义的比较方法,,并将该委托传递给排序方法..他允许调用方的代码
        //成为排序算法的一部分.,,.例如定义一个方法,该方法包含一个参数为前面定义的委托,,代码如下:
        public int JiSuanCallBack(int one, int two, Jisuan js)
        {
            return js(one, two);
        }
        //将委托构造为包装实例方法时,,该委托将同时引用实例和方法..除了它所包含的方法外,,委托并不了解实例类型,,所以只要
        //任意类型的对象中具有与委托签名相匹配的方法,,委托就可以引用该对象..将委托构造为包装静态方法时,,它
        //只引用方法..
        //例如声明一个类JiSuanClass    该类包含两个方法,,代码如下
    }
    public class JiSuanClass
    {
        public int He(int one, int two)//求两个整数的和
        {
            return one + two;
        }
        public int Shang(int one, int two)//求两个整数的商
        {
            return one / two;
        }//类JiSuanClass 定义了两个方法,,加上前面定义方法multiplication,,可以把这三个方法都按前面委托的实例进
        //行封装,,代码如下:50行

    }
}
