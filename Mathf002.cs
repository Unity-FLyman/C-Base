using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf002 : MonoBehaviour
{
    private void _11()
    {
        //编一个程序，定义一个实数变量，从键盘上输入一个值，如果这个值再闭区间[0,100]里
        //则加上1000 否则不加 最后输出结果
        static void Main(string[] args)
        {
            float f;
            float g;
            Console.WriteLine("请输入一个实数变量");
            f = float.Parse(Console.ReadLine());
            if (f>=0 && f<=100)
            {
                g = f + 1000;
                Console.WriteLine("{0}在0~100之间的区间，结果为{1}",f,g);
            }
            else
            {
                Console.WriteLine("不在区间内");
            }
        }
    }
    private void _12()
    {
        //编一个程序，输入一个整数，使用if else 语句 如果该数大于0则加上100 否则加上500 输出结果
        static void Main(string[] args)
        {
            int ch;
            Console.WriteLine("请输入一个整数");
            ch = int.Parse(Console.ReadLine());
            if (ch>0)
            {
                ch += 100;
            }
            else
            {
                ch += 500;
            }

        }
    }
    private void _13()
    {
        // 编一个程序 用if else 语句 输入一个整数，如果该数大于0 则输出“这个数大于零”如果该数等于0
        //则输出“这个数等于零”，否则输出“这个数小于零”
        static void Main(string[] args)
        {
            

        }
    }
    private void _14()
    {
        //编一个程序输入一个整数，对该数进行四舍五入到个数的运算
        //例如，实数12.56经过四舍五入的运算，得到结果13.而12.46经过四舍五入运算得到结果12
        static void Main(string[] args)
        {
            double d;
            int i;
            int e;
            Console.WriteLine("请输入一个数");
            d = double.Parse(Console.ReadLine());
            i = (int) d;// 取整

            
            if ((d-i)>0.5)// 四舍五入
            {
                e = i + 1;
            }
            else
            {
                e = i;
            }
            Console.WriteLine("输出结果为{0}",e);
        }
    }
    private void _15()
    {
        //编写一个程序，定义三个flaot 类型的变量。分别从键盘输入值给它们，然后用if else 选择语句找出它们中最小数
        static void Main(string[] args)
        {
            float x;
            float y;
            float z;

            float min = 0;
            
            Console.WriteLine("请输入三个float类型的数");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            z = float.Parse(Console.ReadLine());

            if (x<y&&x<z)
            {
                min = x;
            }
            else if(y<x&&y<z)
            {
                min = y;
            }
            else if (z<x&&z<y)
            {
                min = z;
            } 
            Console.WriteLine("最小值为{0}",min);
        }
    }
    
    private void _16()
    {
        // 编一个程序，输入三个实数，要求使用if else 语句把它们中间的数找出来，可以使用逻辑运算符
        static void Main(string[] args)
        {
            float x;
            float y;
            float z;
            float second = 0;
            
            Console.WriteLine("请输入3个实数");
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            z = float.Parse(Console.ReadLine());
            
            // 取中间数
            if (x>y&&x<z || x>z&&x<y)
            {
                second = x;
            }
            else if (y>x&&y<z||y>z&&y<x)
            {
                second = y;
            }
            else
            {
                second = z;
            }
            Console.WriteLine("{0}是中间数",second);

        }
    }
    private void _17()
    {
        // 编一个程序，首先输入一个成绩(0~100)的整数，用if else 语句然后判断该成绩是优，良，中，及格还是不及格
        static void Main(string[] args)
        {

        }
    }
    private void _18()
    {
        // 编一个程序，输入0~100之间的学生成绩分数，用switch语句输出成绩等（90~100成绩优秀）（80~89成绩良好）（89~0成绩一般）
        static void Main(string[] args)
        {
            int score;
            Console.WriteLine("请输入学生的成绩");
            score = int.Parse(Console.ReadLine()); 
            score = score / 10;// 整数取整
            switch (score)
            {
                case 10:
                break;
            }
        }
    }
    private void _19()
    {
        //编一个程序，利用do~while 循环语句。。从键盘上输入10个整数，求出他们的和
        static void Main(string[] args)
        {
            int i = 1;
            int sum = 0;
            int n;

            do
            {
                Console.WriteLine("请输入一个整数");
                n=int.Parse(Console.ReadLine());
                sum += n;
                i++;
            } while (i<=10); // 范围
            Console.WriteLine(n);
        }
    }
    private void _20()
    {
        //编一个程序，用while循环语句来计算1+1/2+2/3+3/4+4~~~~~~99+99/100 之和
        static void Main(string[] args)
        {
            int n = 1;//记录次数
            int sum = 1;// 记录总数
            while (n<=99)
            {
                sum += n / (n + 1);
                n++;
          
            }

            Console.WriteLine(sum);

        }
    }
    
}
