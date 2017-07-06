using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal an = new Animal();//实例化一个动物类的对象
            an.train();//调用动物对象下的行为方法
            Dog dg = new Dog();//犬类对象
            Cat cg = new Cat();//肥猫类对象
            dg.train();//调用犬类重写基类(动物类)的行为方法
            Program polymorphic = new Program();//实例化程序类的对象，为展示对象的多态性
            polymorphic.trian(dg);//同一操作操作不同类的实例,,这些类进行了不同的解释//如训练小狗奔跑
            polymorphic.train(cg);//训练肥猫上天飞翔

            Console.WriteLine("");

            Staff s1 = new Staff("老牛",11);
            s1.introduce(s1);
            Workers w1 = new Workers();
            w1.introduce(s1);
            Staff s2 = new Staff("刘佳妮", 23);
            Manager m1 = new Manager();
            m1.introduce(s2);
            Console.WriteLine("");

            Console.ReadLine();
        }
        public void trian(Dog dog)
        {
            Console.WriteLine("小狗奔跑");
        }
        public void train(Cat cat)
        {
            Console.WriteLine("肥猫飞翔");
        }
    }
}
