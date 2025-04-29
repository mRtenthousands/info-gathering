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
            Console.WriteLine("月黑风高杀人夜");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Console.WriteLine("微风吹动着路边的小草");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Console.WriteLine("在路边的尽头隐约有个人影");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Console.WriteLine("走近一看，这人叫");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Console.WriteLine("请输入大侠的名称");
            Character nc = new Character();//创建一个类型
            nc.name1 = Console.ReadLine();
            
            
            Console.ReadKey();
            Console.WriteLine("哇， 真的是你啊（蔡徐坤音）：" + nc.name1);
            Console.ReadKey();

            //实例 实例化
            nc.gender = "男";//前面加nc将这些属性归类给nc这个大侠
            nc.age = 17;
            nc.damage = 100;
            nc.hp = 120;
            nc.height = 178;
            nc.skills1 = "鸡你太美";
            nc.skilllsDamage = 20;
            nc.skills2 = "你干嘛 哎呀";
            nc.skillsDamage2 = 5;

            Console.WriteLine("性别:" + nc.gender);
            Console.WriteLine("年龄:" + nc.age);
            Console.WriteLine("基础伤害:" + nc.damage);
            Console.WriteLine("基础血量:" + nc.hp);
            Console.WriteLine("身高:" + nc.height);
            Console.WriteLine("初始技能一:" + nc.skills1);
            Console.WriteLine("初始技能二:" + nc.skills2);
            Console.ReadLine();


            Console.WriteLine("此时远处传来一声怪响");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Console.WriteLine("走近一看原来是：");
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();

            Character xb = new Character();
            xb.name1 = "雪豹";//归类这些没关系的变量，统一到一个角色下面去访问
            Console.WriteLine("原来你在这里啊！" +  xb.name1);
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();


            
            xb.damage = 30;
            xb.hp = 70;         
            xb.skills1 = "雪豹闭嘴！";
            xb.skilllsDamage = 7;

           
            
            Console.WriteLine("基础伤害:" + xb.damage);
            Console.WriteLine("基础血量:" + xb.hp);
            Console.WriteLine("初始技能一:" + xb.skills1);
            Console.WriteLine("初始技能一伤害:" + xb.skilllsDamage);








            Console.ReadKey();


            //循环 for


            // for(int i = 0; i<=2; i = i + 1)//分为三个部分（初始值;条件表达式;初始值改变)
            //{
            //GetUserInfo();


            //}




            //GetUserInfo();//方法循环1次

            // GetUserInfo();//第二次



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


            //调试从断点开始F10(下一步)F11进去详细看





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
            bool isCheck = name == "Zihao Wan";//==是等于 =是赋值，不等于是!=(一切都要基于英文输入法)
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


    class Character//创建一个类用来储存各个角色的属性
    {
       public string name1;
       public string gender;
       public int age;
       public int damage;
       public int hp;
       public int height;
       public string skills1;
       public int skilllsDamage;
       public string skills2;
       public int skillsDamage2;

    }
}
