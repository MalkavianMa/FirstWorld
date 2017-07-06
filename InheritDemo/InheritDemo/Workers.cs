using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritDemo
{
    class Workers:Staff
    {
        public Workers()
        {
        }
        public override void introduce(Staff s1)
        {
            Console.WriteLine("我是员工代表:" + s1.Name + "\0年龄:" + s1.Age);
            //base.introduce();
        }
    }
}
