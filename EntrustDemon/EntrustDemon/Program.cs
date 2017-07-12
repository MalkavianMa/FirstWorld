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
        //委托类似于C++函数指针,,但它是类型安全的.
        //委托允许将方法作为参数进行传递
        //委托可用于定义回调方法
        //委托可以链接在一起;;例如,,可以对一个事件调用多个方法
        //方法不需要与委托签名精确匹配
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
        public int He(int one, int two)
        {
            return one + two;
        }
        public int Shang(int one, int two)
        {
            return one / two;
        }

    }
}
