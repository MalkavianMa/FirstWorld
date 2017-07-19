using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic_Paradigm
{
    class Program
    {//C#中的泛型类似C++的模板,,它在一定程度上能够提高应用程序的效率..使用泛型可以定义类型安全的数据结构,
        //而无需使用具体的数据类型..通过使用泛型,,能够将数据类型参数化,,以此完成代码重用的目标
        //通常情况下,,泛型常见于集合应用中..在System.Collections.Generic 名称空间中,,包含了一些基于泛型的
        //容器类..例如System.Collection.Generic.Stack、、System.Collections.Generic.Dictionary、
        //System.Collections.Generic.List和System.Collections.Generic.Queue等,,这些类库可以在集合
        //中实现泛型
        //创建泛型的格式如下:
        //1.类名 <Type> 变量名=new 类名 <Type>();
        //2.Stack <String> list =new Stack <String>();
        //第1行是泛型创建的格式,,使用泛型类必须指定实际的类型,, 并在尖括号<>中指定实际的类型.
        //第2行根据格式创建了String类型的泛型类的集合类型list,,这意味着list只能存储String类型的
        //数据..泛型的使用如下代码所示

        static void Main(string[] args)
        {
            Stack<String> list = new Stack<String>();//使用泛型 Stack<String> list= new Stack<String>()创建对象list
            Program sl = new Program();//然后使用Stack类的方法Push传入String类型的参数,,这里只能传泛型中定义的类型
            list.Push("ASP");//否则报错..
            list.Push(".NET");
            int number = list.Count;//使用Stack类的方法Count取得元素个数
            Console.WriteLine("S^\0" + "\b" + number);//反转义 退格 去掉了^和空格
            //C#泛型类在编译时,,先生成中间代码IL,,通用类型T 只是一个占位符..在实例化类时
            //根据用户指定的数据类型代替T,,并由即时编译器(JIT)生成本地代码,,
            //这个本地代码中已经使用了实际的数据类型,,等同于实际类型写的类
            //我们把为所有类型参数提供参数的泛型类型称为封闭构造泛型类型,,简称封闭类
            //不同封闭类的本地代码是不一样的,,按照这个规则,,可以这样认为:
            //泛型类的不同封闭类是不同的数据类型

            //创建泛型
            //除了使用系统的泛型类之外,,读者可以编写自己的泛型类..下面介绍一下泛型类和普通类的区别
            //1.静态构造函数
            //静态构造函数的规则:只能有一个,,且不能有参数,,它只能被.NET运行时自动调用,,而不能人工调用..
            //泛型中的静态构造函数的原理和非泛型类是一样的,,只需把泛型中的不同的封闭类理解为不同的
            //类即可
            //以下俩种情况可激发静态的构造函数:
            //·特定的封闭类第一次被实例化
            //·特定封闭类中任一静态成员变量被调用

            //2.静态成员变量
            //在C#1.0 中,类的静态成员变量在不同的类实例间是共享的,,并且它是通过类名访问的
            //C#2.0中由于引进了泛型,,导致静态成员变量的机制出现了一些变化:
            //静态成员变量在相同封闭类间共享,,不同的封闭类间不共享
            //这也非常容易理解,,因为不同的封闭类虽然有相同的类名称,,但由于分部传入了不同的数据
            //类型,,他们是完全不同的类.,eg:
            //List<int> a = new ArrayList <int>();
            //list<int> b = new ArrayList<int>();
            //List<long > c=new List<long> ArrayLisdt<long>();

            //类实例a和b是同一类型,,它们之间共享静态成员变量,,但类实例c却是和a、b完全不同的类型,,
            //所以不能和a、b共享静态成员变量..

            //3.数据类型的约束
            //在编写泛型类时,,总是会对通用数据类型T进行有意或无意地遐想,,也就是说T一般来说是
            //不能适应所有类型,,但怎样限制调用者传入的数据类型呢?这就需要对传入的数据类型进行约束,,
            //约束的方式是指定T的祖先,,即继承的接口或类..因为C#的单根继承性,,所以约束可以有多个接口,
            //但最多只能有一个类,,并且类必须在接口之前

            //由于通用类型T是从Object继承来的,,所以他在类Node的编写中只能调用Object类的方法
            //这给程序的编写造成了困难..比如你的类设计只需要支持两种数据类型int和string,,并且在类中
            //需要对T类型的变量比较大小,,但这些却无法实现..因为Object是没有比较大小的方法的..
            //为了解决这个问题,,只需要对T进行IComparable约束,,这时在类Node里就可以对T的实例
            //执行CompareTo方法了..这个问题可以扩展到其他用户自定义的数据类型..

            //如果在类Node里需要对T重新进行实例化该怎么办呢?
            //因为类Node中不知道类T到底有哪些构造函数..为了解决这个问题
            //需要用到new约束,,,需要注意的是,new约束只能是无参数的,,
            //所以也要求相应的类Stack必须有一个无参构造函数,,否则编译失败

            //上面了解了泛型的基本概念和创建泛型的方法,,下面通过一个例子来演示如何使用泛型


            //本实例使用泛型类Stack实现员工管理系统中录入员工信息的功能
            //在控制台根据提示输入员工的工号、姓名年龄和地址，确认录入信息后..显示该员工的信息
            Stack<Employee> emp1 = new Stack<Employee>();//23
            do
            {
                Console.WriteLine("请输入员工的工号");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入员工的姓名");
                String name = Console.ReadLine();
                Console.WriteLine("请输入员工的年龄:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入员工的家庭住址");
                string address = Console.ReadLine();
                Employee e = new Employee(id, name, age, address);
                emp1.Push(e);
                Console.WriteLine("是否继续录入员工的信息?Y/N");

            } while (Console.ReadLine().ToLower()=="y");
            Employee a = new Employee();
            a.print(emp1);

            Console.Read();//40
        }
    }
    public class Employee//1
    {
        private int id;
        private String name;
        private int age;
        private string address;
        public Employee()
        {

        }
        public Employee(int id, String name, int age, string address)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void print(Stack<Employee> emp1)
        {
            foreach (Employee s in emp1)
            {
                Console.WriteLine("员工的工号是:" + s.id);
                Console.WriteLine("员工的姓名是:" + s.name);
                Console.WriteLine("员工的年龄是:" + s.age);
                Console.WriteLine("员工的住址是:" + s.address);


            }

        }//12
    }//代码说明:第1-12行自定义封装了员工类..其中,,第2-5行定义了4个私有字段表示员工的工号
    //、姓名、年龄和地址。第6行定义不带参数的构造函数，第7-12行在构造函数内对四个字段进行
    //初始化。第13-21行编写一个方法print通过foreach语句循环打印员工的信息
      //第23行使用泛型初始化泛型集合对象emp1,,对象类型规定为我们定义的Employee类型..
    //第25-32行获得输入的数据..第34行调用emp1对象的Push方法将员工信息添加到泛型集合
    //中..第38行调用Employee对象的print方法打印员工信息
    
  


}
