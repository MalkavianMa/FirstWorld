using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritDemo
{
    class Dog:Animal
    {
        public override void train()//Animal类的[派生类Dog类，使用关键字override重写父类的train方法
        {
            Console.WriteLine("巡礼敬礼,翻跟头,骑自行车");
            //base.train();
        }
    }
}
