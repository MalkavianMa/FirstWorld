using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Data;

namespace MyCalculator
{
    class Program
    {

        /// <summary>
        /// 判断字符是否为数字Malkavian
        /// </summary>
        /// <param name="_strNum"></param>
        /// <returns>boolean</returns>
        public static bool isNumeric(string _strNum)
        {
            bool flag = true;
            int count = 0;
            int sym = 0;
            if (_strNum == null || _strNum == string.Empty)
            {
                Console.WriteLine("你输入的并非数字,请重新输入! ");
                flag = false;
                return flag;
            }
            else
            {
                char[] x = _strNum.ToCharArray();

                for (int i = 0; i < _strNum.Length; i++)
                {
                    if (!char.IsNumber(x[i]) && x[i] != '.' && x[i] != '-')
                    {
                        flag = false; break;

                    }
                    if (x[i] == '.')
                    {
                        if (x[0] == '-' && i == 1) flag = false;

                        count++;
                        if (i == 0 || i == _strNum.Length - 1) flag = false;
                    }
                    if (x[i] == '-')
                    {
                        if (i == _strNum.Length - 1) flag = false;
                        sym++;
                        if (i != 0) flag = false;
                    }


                }
                if (count > 1) flag = false;
                if (sym > 1) flag = false;
                if (!flag)
                {
                    Console.WriteLine("你输入的并非数字,请重新输入! ");
                }

            }

            return flag;

        }

        /// <summary>
        /// 判断字符是否为加减乘除取余Malkavian
        /// </summary>
        /// <param name="_strNum"></param>
        /// 


        public static bool isSym(string _strNum)
        {
            bool flag = true;
            int count = 0;
            //    int sym = 0;
            if (_strNum == null || _strNum == string.Empty)
            {
                Console.WriteLine("你输入的并非加减乘除取余,请重新输入! ");
                flag = false;
                return flag;
            }
            else
            {
                char[] x = _strNum.ToCharArray();
                for (int i = 0; i < _strNum.Length; i++)
                {

                    if (x[i] == '+' || x[i] == '-' || x[i] == '*' || x[i] == '/' || x[i] == '%')
                    {
                        count++;

                    }
                    //        if (x[i] != '+' && x[i] != '-' && x[i] != '*' && x[i] != '/' && x[i] != '%')
                    else
                    {
                        flag = false; break;

                    }
                }
                if (count > 1) flag = false;
                // if (sym > 1) flag = false;
                if (!flag)
                {
                    Console.WriteLine("你输入的并非加减乘除取余,请重新输入!! ");
                }

            }

            return flag;

        }

        /// <summary>
        /// 判断字符是否为0Malkavian
        /// </summary>
        /// <param name="_strNum"></param>
        /// 
        public static bool isZero(string _strNum)
        {
            bool flag = true;
            int count = 0;
            char[] x = _strNum.ToCharArray();
            for (int i = 0; i < _strNum.Length; i++)
            {

                if (x[i] != '0')
                {
                    count++;
                    flag = true;
                }
                else
                {
                    if(count<1) flag = false;

                }
                if (x[0] == '-' && count == 1) flag = false;
                if ( x[i] == '.' && count == 1) flag = false;

                if (x[i]=='.'&&x[0]=='-'&&count==2) flag = false;

            }

            if (!flag)
            {
                Console.WriteLine("你输入的为0！！,请重新输入!! ");
            }
            return flag;

        }
        /// <summary>
        /// Decimal长度限制
        /// </summary>
        /// <param name="_strNum"></param>
        /// <returns></returns>
        public static bool islenth(string _strNum)
        {
            bool flag=true;

            if (_strNum.Length>29)
            {
                flag = false;
            }
            if (!flag)
            {
                Console.WriteLine("你输入的长度超过限制29,请重新输入!! ");
            }
            return flag;
        }
        public static bool isCalculteContinu(string _strNum)
        {
            CalculatorManager bllCalculateHistory = new CalculatorManager();


            if (_strNum == "q")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool isS(string str)
        {
            CalculatorManager bllCalculateHistory = new CalculatorManager();

            if (str == "s")
            {
//                DataTable ds = bllCalculateHistory.GetAllHistory();
                Console.WriteLine("开始喽");
                return true ;

            }
            return false;

        }

        static void Main(string[] args)
        {
            CalculatorManager bllCalculate = new CalculatorManager();

            string oneAdd;
            string oneSub;
            string oneMul;
            string oneDivid;
            string oneRemainder;
            Console.WriteLine("Welcome to Malkavian's calculator!\nIf problem occurs during use, please call QQ:635109543");
            string one1;
            string calculateContinue;
            do
            {
                Console.WriteLine("进行历史查询输入s最新10条,如不需要请回车");
                string history= Console.ReadLine();
                if (isS(history))
                {
                    DataTable ds = bllCalculate.GetAllHistory();
                    
                    for (var j = 0; j < ds.Rows.Count; j++)
                    {
                        Console.Write("\0\0\0{0}{1}\0{2}\n运算结果:{3}\n", ds.Rows[j][0].ToString().Trim(), ds.Rows[j][2].ToString().Trim(), ds.Rows[j][1].ToString().Trim(), ds.Rows[j][3].ToString().Trim());

                        //for (int i = 0; i < ds.Columns.Count; i++)
                        //{

                        //}
                      
                    }
                   
                }
                Console.WriteLine("请输入一个数进行计算：");

                do
                {
                    one1 = Console.ReadLine();
                    Console.WriteLine("字符数{0}", one1.Length);/*.Length获取字符个数从1开始数.*/

                }
                while (!isNumeric(one1) || !islenth(one1));

              

                decimal one2 = Convert.ToDecimal(one1);
                Console.WriteLine("你输入的数字为:{0}", one2);

                Console.WriteLine("请输入进行的运算：+ - * / %");
                string choice;
                do
                {
                    choice = Console.ReadLine();
                }
                while (!isSym(choice));
                switch (choice)
                {
                    case "+":
                        Console.WriteLine("请再输入一个数：");
                        do
                        {
                            oneAdd = Console.ReadLine();
                        }
                        while (!isNumeric(oneAdd) || !islenth(oneAdd));
                        decimal twoAdd = Convert.ToDecimal(oneAdd);
                        decimal sum = one2 + twoAdd;
                        Console.WriteLine("{0}{1}{2}=\n{3}", one1, choice, oneAdd, sum);
                        if (bllCalculate.ADDResult(one1, oneAdd, choice, sum.ToString()) > 0)
                        {
                            Console.WriteLine("数据进入SQL添加成功");
                        }
                        break;
                    case "-":
                        Console.WriteLine("请再输入一个数：");
                        do
                        {
                            oneSub = Console.ReadLine();
                        }
                        while (!isNumeric(oneSub) || !islenth(oneSub));
                        decimal twoSub = Convert.ToDecimal(oneSub);
                        decimal sub = one2 - twoSub;
                        Console.WriteLine("{0}{1}{2}=\n{3}", one1, choice, oneSub, sub);
                        if (bllCalculate.ADDResult(one1, oneSub, choice, sub.ToString()) > 0)
                        {
                            Console.WriteLine("数据进入SQL添加成功");
                        }
                        break;
                    case "*":
                        Console.WriteLine("请再输入一个数：");
                        do
                        {
                            oneMul = Console.ReadLine();
                        }
                        while (!isNumeric(oneMul) || !islenth(oneMul));
                        decimal twoMul = Convert.ToDecimal(oneMul);
                        decimal Mul = one2 * twoMul;
                        Console.WriteLine("{0}{1}{2}=\n{3}", one1, choice, oneMul, Mul);
                        if (bllCalculate.ADDResult(one1, oneMul, choice, Mul.ToString()) > 0)
                        {
                            Console.WriteLine("数据进入SQL添加成功");
                        }
                        break;
                    case "/":
                        Console.WriteLine("请再输入一个数：");
                        do
                        {
                            oneDivid = Console.ReadLine();
                        }
                        while (!isNumeric(oneDivid) || !isZero(oneDivid) || !islenth(oneDivid));
                        decimal twoDivid = Convert.ToDecimal(oneDivid);
                        if (twoDivid == 0)
                        {
                            Console.WriteLine("警告:除数不能为0！！");

                        }
                        else
                        {

                            decimal Divid = one2 / twoDivid;
                            Console.WriteLine("{0}{1}{2}=\n{3}", one1, choice, oneDivid, Divid);
                            if (bllCalculate.ADDResult(one1, oneDivid, choice, Divid.ToString()) > 0)
                            {
                                Console.WriteLine("数据进入SQL添加成功");
                            }
                        }


                        break;

                    case "%":
                        Console.WriteLine("请再输入一个数：");
                        do
                        {
                            oneRemainder = Console.ReadLine();
                        }
                        while (!isNumeric(oneRemainder) || !isZero(oneRemainder) || !islenth(oneRemainder));
                        decimal twoRemainder = Convert.ToDecimal(oneRemainder);
                        if (twoRemainder == 0)
                        {
                            Console.WriteLine("警告:对0取余！！");

                        }
                        else
                        {

                            decimal Remainder = one2 % twoRemainder;
                            Console.WriteLine("{0}{1}{2} 的余数为\n{3}", one1, choice, oneRemainder, Remainder);
                            if (bllCalculate.ADDResult(one1, oneRemainder, choice, Remainder.ToString()) > 0)
                            {
                                Console.WriteLine("数据进入SQL添加成功");
                            }
                        }


                        break;

                    default:
                        Console.WriteLine("输入格式错误!请检查");
                        break;



                }
                Console.WriteLine("输入q退出");
                

                calculateContinue = Console.ReadLine();

            }
            while (isCalculteContinu(calculateContinue));


            Console.WriteLine("谢谢使用!");
        }
    }
}
