using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 信息收集
{
    internal class Program
    {
        static void Main()
        {
             GetUserInfo();//方法循环1次

             GetUserInfo();//第二次



            Console.ReadKey(); 
        
        }

        static void GetUserInfo()//调用方法，将方法储存到这里
        {
            //bool bo1 = false;//布尔类型


            //if (bo1)
            //{
            //    Console.WriteLine("这是if的内部");
            //    Console.WriteLine("bool只有为true你才能看到我");
            //}








            //名称收集
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();//string 类型收集

            




            //年龄收集
            Console.WriteLine("Please enter your age");
            string age = Console.ReadLine();//创建库来保存输入的信息

            //家乡收集
            Console.WriteLine("Please enter your hometown");
            string address = Console.ReadLine();

            //收集爱好
            Console.WriteLine("Please enter your hobbies");
            string hobbies = Console.ReadLine();

            name = ChangeData(name);//把name传过来


            //组织格式
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Your name is:" + name);
            Console.WriteLine("Your age is:" + age);
            Console.WriteLine("Your hometown is:" + address);
            Console.WriteLine("Your hobbies is:" + hobbies);
        }

        static string ChangeData(string name)//接收的地方
        {
            //表达式用来计算出一个结果然后赋值一个变量
            bool isCheck = name == "Zihao Wan";//==是等于=是赋值，不等于是!=(一切都要基于英文输入法)
            if (isCheck)
            {
                Console.WriteLine("Your entering is Zihao Wan");
                name = "The uniqual Zihao Wan";
            }//bool类型只能存储true和false
            else if (name == "Niko")//必须要加条件
            {
                Console.WriteLine("Your entering is Niko");
                name = "The world 1st rifleman Niko";
            }
            else//以上条件都不满足所以不用加条件
            {
                Console.WriteLine("error");
            }


            //bool isCheckNiko = name == "Niko";
            //if (isCheckNiko) {
            //    Console.WriteLine("Your entering is Niko");
            //    name = "The world 1st rifleman Niko";
            //}

            //&&且


            return name;//返回值 要同类型
        }

    }

}
