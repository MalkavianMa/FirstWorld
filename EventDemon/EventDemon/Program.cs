using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemon
{//用委托和事件实现的排序算法
    class Program
    {
        //事件是类在发生其关注的事情时用来提供通知的一种方式..例如,,封装用户界面控件类
        //可以定义一个在用户单击该控件时发生的事件.. 控件类不关心单击按钮
        //时发生了什么,,但它需要告知派生类单击事件已发生,,然后,,派生类可选择如何响应

        //事件使用委托来为触发时将调用的方法提供类型安全的封装..委托可以封装命名方法
        //和匿名方法..
        //事件具有以下特点
        //事件是类用来通知对象需要执行某种操作的方式
        //尽管事件在其他时候(如信号状态更改)也很有用,事件通常还是用在图形用户界面中
        //事件通常使用委托事件处理程序进行声明
        //事件可以调用匿名方法来替代委托

        //eg:设计一个员工类,,成员包括员工的姓名和工资,,使用委托的方法对员工发放的工资进行排序输出
       
        
        delegate bool CompareOp(object ths, object rhs);//一个委托CompareOP,,包含两个object 类型的参数

        class BubbleSorter//类
        {
            /// <summary>
            /// 排序方法Sort经典的冒泡排序算法
            /// </summary>
            /// <param name="sortArray">object类型的数组参数</param>
            /// <param name="getCompareMethod">委托类型的参数</param>
            public static void Sort(object[] sortArray, CompareOp getCompareMethod)
            {
                for (int i = 0; i < sortArray.Length; i++)//两个for的嵌套循环实现给传递进来的数组元素进行从小到大的排序
                {
                    for (int j = i + 1; j < sortArray.Length; j++)
                    {
                        if (getCompareMethod(sortArray[i], sortArray[j]))
                        {
                            object temp = sortArray[i];
                            sortArray[i] = sortArray[j];
                            sortArray[j] = temp;

                        }

                    }

                }

            }

        }
        class Employee//员工类
        {
            //定义属性成员
            private string _Name;
            private decimal _Salary;

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public decimal Salary
            {
                get { return _Salary; }
                set { _Salary = value; }
            }

            public Employee(string name, decimal salary)//定义带参的 构造参数
            {
                this._Salary = salary;
                this._Name = name;
            }

            public override string ToString()//重写了ToString方法,,返回员工姓名和工资信息..
            {
                return string.Format(_Name + ",{0}元\a", _Salary);//return base.ToString();//反转义蜂鸣在这里有了体现 耳机出现"低音叮铃撞击撞击声"
            }
            /// <summary>
            /// 比较员工的工资
            /// </summary>
            /// <param name="ths"></param>
            /// <param name="rhs"></param>
            /// <returns></returns>
            public static bool Compare(object ths, object rhs)//定义了一个比较方法对两个员工的工资进行比较
            {
                Employee empLhs = (Employee)ths;
                Employee empRhs = (Employee)rhs;
                return (empLhs._Salary > empRhs._Salary) ? true : false;
            }
        }
        

        static void Main(string[] args)
        {
        //实例化5个员工对象并赋值..
            Employee[] employees ={
                                    new Employee("王海",2000),
                                    new Employee("张倩",2500),
                                    new Employee("卡勒",2300),
                                    new  Employee ("华英",2800),
                                    new Employee("容元",1900),
                                };
            CompareOp compareOp = new CompareOp(Employee.Compare);//实例化委托对象compareOp
            BubbleSorter.Sort(employees, compareOp);//调用 BubbleSorter类的Sort对员工实例的工作进行排序
            for (int i = 0; i < employees.Length; i++)
                Console.WriteLine(employees[i].ToString());//体现{} 大括弧的可选择性输入 在if段后也有体现
            Console.ReadLine();
        }
    }
}
