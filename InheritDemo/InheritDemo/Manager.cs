using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritDemo
{
    class Manager:Staff
    {
  
     
        public override void introduce(Staff s1)
        {
            Console.WriteLine("我是部门经理:" +s1.Name + "\0年龄:" + s1.Age);

            //base.introduce();
        }
    }
}
