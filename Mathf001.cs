using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf001 : MonoBehaviour
{
   private void _1()
   {
      //编一个程序，定义常量Pi=3.1415926,从键盘上输入半径r，求出圆的面积
      static void Main(string[] args)
      {
         const double PI = 3.1415926;//圆周率
         double r; //圆的半径
         double s; //圆的面积
         
         Console.WriteLine("请输入圆的半径");
         r = double.Parse(Console.ReadLine());// <-输入的值
         s = PI * r * r;
         Console.WriteLine("圆的面积是:{0}",s);
      }
   }
   private void _2()
   {
      //编一个程序，定义三个double类型的变量，分别从键盘上输入值给他们
      //然后用Console.WriteLine方法把它们输出一列,小数点对齐，保留3位小数
      static void Main(string[] args)
      {
         double x;
         double y;
         double z;
         
         Console.WriteLine("请输入一个数");
         x = double.Parse(Console.ReadLine());
         Console.WriteLine("请输入一个数");
         y = double.Parse(Console.ReadLine());
         Console.WriteLine("请输入一个数");
         z = double.Parse(Console.ReadLine());
         
         Console.WriteLine("{0:f3}",x);
         Console.WriteLine("{0:f3}",y);
         Console.WriteLine("{0:f3}",z);
         
      }
   }
   private void _3()
   {
      //编一个程序，从键盘输入三个数，用三元运算符（?:）把最大数找出来
      static void Main(string[] args)
      {
         // 实数指的是浮点数
         float x;
         float y;
         float z;
         float temp;
         
         Console.WriteLine("请输入一个实数");
         x =  float.Parse(Console.ReadLine());
         Console.WriteLine("请输入一个实数");
         y =  float.Parse(Console.ReadLine());
         Console.WriteLine("请输入一个实数");
         z =  float.Parse(Console.ReadLine());
         
         // 比较
         temp= x>y ?x :y; // X是否小于等于y如果是返回x否则返回y
         temp = temp > z ? temp : z;// temp 和z比较

         Console.WriteLine("最大的数为{0}",temp);

      }
   }
   private void _4()
   {
      //编一个程序，从键盘输入三个数，用三元运算符（?:）把最小数找出来
      static void Main(string[] args)
      {
         // 实数指的是浮点数
         float x;
         float y;
         float z;
         float temp;
         
         Console.WriteLine("请输入一个实数");
         x =  float.Parse(Console.ReadLine());
         Console.WriteLine("请输入一个实数");
         y =  float.Parse(Console.ReadLine());
         Console.WriteLine("请输入一个实数");
         z =  float.Parse(Console.ReadLine());
         
         // 比较
         temp= x<=y ?x :y; // X是否小于等于y如果是返回x否则返回y
         temp = temp <= z ? temp : z;// temp 和z比较

         Console.WriteLine("最小的数为{0}",temp);

      }
   }
   private void _5()
   {
      //编一个程序，输入一个字符，如果是大写字母，就转换成小写字母，否则不转换
      static void Main(string[] args)
      {
         char ch;
         Console.WriteLine("请输入一个字符");
         ch = char.Parse(Console.ReadLine());
         
         if (ch>='A' && ch<='Z')//如果输入的是大写字符的话
         {
            ch = (char) (ch + 32);// 大小写转换
         }
         Console.WriteLine(ch);
      }
   }
   
   private void _6()
   {
      //输入一个字符，判定它是什么类型的字符（大写字符，小写字母，数字或者其他字符）
      static void Main(string[] args)
      {
         char ch;

         ch = char.Parse(Console.ReadLine());
         if (ch >='a' && ch <='z')
         {
            Console.WriteLine("小写字母");
         }
         else if (ch >= 'A' && ch <= 'Z')
         {
            Console.WriteLine("大写字母");
         }
         else if (ch>='0'&&ch<='9')
         {
            Console.WriteLine("数字");
         }
         else
         {
            Console.WriteLine("其他字符");
         }
      }
   }
   private void _7()
   {
      //编一个程序，设圆的半径r=1.2，高h=1.5，定义圆周率常量Pi=3.1415,求出圆柱的体积
      static void Main(string[] args)
      {
         const double Pi = 3.1415926;
         double R = 1.2;
         double h = 1.5;
         double v;
         v = Pi * R * R * h;
         Console.WriteLine("圆柱的体积为:{0}",v);

      }
   }
   private void _8()
   {
      //编一个程序，设圆半径r=1.5，圆柱高h=3.6，圆周率3.1415定义为常量，求出圆周长，圆面积，圆柱体积
      //然后用Console.WriteLine方法输出计算结果，输出时要求有文字说明，取小数点后2位数字。例如圆周长=XXX.XX.
      static void Main(string[] args)
      {
         const double PI = 3.1415926;
         double r = 3;
         double h = 5;

         double c = 2 * PI * r;
         double S = PI * r * r;
         double v = S * h;
         Console.WriteLine("圆周长为:{0:f2},圆面积为:{1:f2},圆柱体积为{3,f2}",c,S,v);
      }
   }
   private void _9()
   {
      //编一个程序，输入一个字符，如果输入的字符是大写字母，则转换为小写字母
      //如果输入的字符是小写字母，则转换为大写字母，否则不转换
      static void Main(string[] args)
      {
         char ch;
         char c;
         Console.WriteLine("请输入一个字母");
         ch = char.Parse(Console.ReadLine());
         if (ch >= 'A' && ch <='Z')
         {
            c = (char) (ch + 32);
            Console.WriteLine("字串符{0}为大写字母，则转为小写字母为{1}",ch,c);
         }
         if (ch >= 'a' && ch <='z')
         {
            c = (char) (ch - 32);
            Console.WriteLine("字串符{0}为小写字母，则转为大写字母为{1}",ch,c);
         }
         else
         {
            Console.WriteLine("字串符{0}既不是大写字母也不是小写字母",ch);
         }
      }
   }

   struct Studunt
   {
      public int num;
      public string name;
      public string sex;
      public double score;

   }
   private void _10()
   {
      //编一个程序定义结构类型（有学号，姓名，性别和程序设计成绩四个字段），
      //声明该结构类型变量，用赋值语句对该变量赋值以后再输出
      static void Main(string[] args)
      {
         Studunt stu;
         stu.num = 10;
         stu.name = "Flyman";
         stu.sex = "boy";
         stu.score = 100;
         Console.WriteLine("XXXXXXXXXXXXXXXXX{0}{1}{2}{3}",stu.num,stu.name,stu.sex,stu.score);


      }
   }
   
}
