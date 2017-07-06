using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritDemo
{
    class Animal
    {
        public virtual void train()//虚方法为子类重写基类提供了可能
        {
            Console.WriteLine("站立,排队,做算术");
        }
    }
}
