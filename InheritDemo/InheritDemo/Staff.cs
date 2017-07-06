using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritDemo
{
    class Staff
    {
        private string _name;
        private int _age;

        public Staff()
        {
        
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set {
                if (value>18&&value<50)
                {
                    _age = value;
                }
                else
                {
                    _age = 18;
                }
            }
        }
        public   Staff( string name,int age)
        {
            this._name = name;
            Age = age;
        }
        public virtual void introduce(Staff s1)
        {
            Console.WriteLine("欢迎来到召唤师峡谷"+Name+"\0年龄:"+Age);
        }
    }
}
