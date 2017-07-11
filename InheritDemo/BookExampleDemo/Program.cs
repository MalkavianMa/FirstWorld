using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookExampleDemo
{
    class Program//为偷懒这里员工类命名为Program
    {
        protected String name;//定义员工的名字保护级别，访问受限制
        //public Program()//为测试test1做准备
        //{

        //}
        public Program(string name)//带名字参数的构造函数."程序入口?内存入口?"
        {
            this.name = name;
            Console.WriteLine("我是今天的主持人"+name);
        }
        public virtual void introduce()//定义方法向控制台输出自我介绍，关键字"virtual"声明可以被派生类所重写
        {
            Console.WriteLine("大家好!我是普通员工");
            Console.WriteLine("我的名字是" + name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
          Program emp = new DepartmentManager("王东");//先实例化一名员工，这名员工可以是普通员工对象或者是部门经理对象
            //Program emp = new Program("张琴");//程序实现了根据实例化对象的不同动态绑定了不同的方法
            Meeting meeting = new Meeting(emp);//实例化一个会议类对象
            meeting.begin();//调用会议开始的方法
        }
    }
    class DepartmentManager : Program//定义DepartmentManager类继承与员工类。
    {
        //public DepartmentManager(string name){// : base(name) {//构造函数使用"base"关键字显式的调用//如果不用base关键字显式调用,DepartmentManager类的introduce方法中name为null//测试test1
        //    Console.WriteLine("部门经理："+name+"上台，大家鼓掌");
        //}
        public DepartmentManager(string name) : base(name) {//构造函数使用"base"关键字显式的调用
            Console.WriteLine("部门经理：" + name + "，现在上台，大家鼓掌");
        }
        public override void introduce()//关键字override重写了基类的同名方法introduce,输出部门经理的自我介绍
        {
            Console.WriteLine("大家好.我是部门经理");
            Console.WriteLine("我的名字是:" + name);//base.introduce();
            Console.ReadLine();
        }
    }
    class Meeting//定义Meeting会议类，51行声明了一个属性emcee，代表会议的主持人，由于我们并不知道将来指定的主持人是员工
    {//--还是部门经理,所以我们把它声明为一个基类的引用，而基类的引用可以指向派生类的对象，这就是实现多态绑定的关键
        Program emcee;
        public Meeting(Program emcee) {
            this.emcee = emcee;
        }
        public void begin()//定义一个会议开始的方法begin，在方法中调用introduce方法由主持人做自我介绍
        {
            emcee.introduce();
        }
    }
}
