using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookExampleDemo
{
    class Program
    {
        protected String name;
        public Program(string name)
        {
            this.name = name;
        }
        public virtual void introduce()
        {
            Console.WriteLine("大家好!我是普通员工");
            Console.WriteLine("我的名字是" + name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //Program emp = new DepartmentManager("王东");
            Program emp = new Program("张琴");
            Meeting meeting = new Meeting(emp);
            meeting.begin();
        }
    }
    class DepartmentManager : Program
    {
        public DepartmentManager(string name) : base(name) {
            Console.WriteLine(name);
        }
        public override void introduce()
        {
            Console.WriteLine("大家好.我是部门经理");
            Console.WriteLine("我的名字是:" + name);//base.introduce();
            Console.ReadLine();
        }
    }
    class Meeting
    {
        Program emcee;
        public Meeting(Program emcee) {
            this.emcee = emcee;
        }
        public void begin()
        {
            emcee.introduce();
        }
    }
}
