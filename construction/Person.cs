using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Person
    {
       public  string _name;
        public int _age;
        public Person(string name, int age)
        {
            this._name = name;//实际参数
            this._age = age;
            //string _name = name;
            //int _age = age;
        }
        public Person() {

            this._name = "colby";//形式参数
            this._age = 20;
         //   string _name = "colby";
          //  int _age = 20;
        }
    }
}
