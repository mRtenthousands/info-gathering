using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 信息收集
{
    internal class Program
    {
        static void Main()
        {   
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

            //组织格式
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Your name is:" + name);
            Console.WriteLine("Your age is:" + age);
            Console.WriteLine("Your hometown is:" + address);
            Console.WriteLine("Your hobbies is:" + hobbies);

            Console.ReadKey(); 
        }
    }
}
