using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf003 : MonoBehaviour
{
    private void _21()
    {
        //编一个程序，用do-while循环语句来计算PI=4*(1-1/3+1/5+...+1/n),要求当1/n<0.000001时停止运算
        static void Main(string[] args)
        {
            double PI;
            double sum = 0;
            float n = 1;
            double x;
            do
            {
                x = Mathf.Pow(-1, n + 1);// (-1)^n+1
                x = x * 1 / n*2 - 1;
                n++;
                sum += x;
            } while (1/n>=0.000001);

            PI = 4 * sum;
            Console.WriteLine("{0}",PI);
        }
    }
    private void _22()
    {
        //编一个程序，从键盘上输入两个实数，使用Math类中Max()和Min()方法，求出他们中的最大数和最小数
        static void Main(string[] args)
        {
             float a;
            float b;
            float max;
            float min;
            a = float.Parse(Console.ReadLine());
            b =float.Parse(Console.ReadLine());
            max = Mathf.Max(a, b);
            min = Mathf.Min(a, b);

        }
    }
    private void _23()
    {
        //编一个程序，利用while循环语句和Math类中的Pow()方法，求出1到10的各个数的平方和
        static void Main(string[] args)
        {
            float n = 0;
            float sum = 0;
            while (n<=10)
            {
                n++;
                sum+=Mathf.Pow(n, 2);
            }
            Console.WriteLine("sum=>{0}",sum);

        }
    }
    private void _24()
    {
        //编一个程序，打印出所有的"水仙花数"，所谓“水鲜花数” 是指一个三位数，其各位数字立方和等于该数本身
        //例如 153=1*1*1+5*5*5+3*3*3,所以153是“水仙花数”
        static void Main(string[] args)
        {
            int a = 0;// 百位
            int b = 0;// 十位
            int c = 0;// 个位
            List<int> num=new List<int>();
            
            for (int q = 100; q < 1000; q++)
            {
                a = q / 100;
                b = q % 100 / 10;
                c = q % 10;
                if (q==a*a*a+b*b*b+c*c*c)
                {
                    num.Add(q);
                }
            }
            foreach (var i in num)
            {
                Console.WriteLine("水仙花数是"+i);
            }
        }
    }
    private void _25()
    {
        //编一个程序，用while语句 求出1+(1+2)+(1+2+3)+...+(1+2+3+..+10)之和
        static void Main(string[] args)
        {
            int n = 1;
            int s = 0;
            int j = 1;
            int s1 = 0;
            while (n<=10)// 每个大项之和
            {
                while (j<=n) // 每个小项之和
                {
                    s1 += j;
                    j++;
                }
                
                s += s1;
                n++;
            }
           
        }
    }
    private void _26()
    {
        //编一个程序，输入两个正整数，求出它们的最大公约数
        //（例如，2，-2，7，-7，14， -14都是28，42，70的公约数；14是它们的最大公约数）
        // 公约数代表可以被整除 取余为0
        static void Main(string[] args)
        {
            float a;
            float b;
            float c;
            Console.WriteLine("请输入两个字符");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            c = a < b ? a : b;
            while (!(a%c==0&&b%c==0))
            {
                c--; // 取最小
            }
            Console.WriteLine("最大公约数是",c);

        }
    }private void _27()
    {
        //编一个程序，用while循环语句，从键盘输入10个数，要求找出最大数和次大数
        static void Main(string[] args)
        {
            int i = 1;
            int max = 1;
            int max2 = 1;
            int s = 0;
            while (i<=10)
            {
                s= int.Parse(Console.ReadLine());
                if (s>max)
                {
                    max2 = max;
                    max = s;
                    
                }
                else if (s>max2)
                {
                    max2 = s;
                }
                i++;
            }
        }
    }private void _28()
    {
        //编一个程序，要求使用while语句，输入用户名和密码，实现用户登录程序的功能，至多输入3次，超过三次不能登录
        static void Main(string[] args)
        {
            const string UserName = "admin";
            const string PassWard = "";
            string userName;
            string passward;
            int n=1;
            while (n>=3)
            {
                userName = Console.ReadLine();
                passward = Console.ReadLine();
                if (userName==UserName&& passward==PassWard)
                {
                    break;
                    
                }
                else
                {
                    Console.WriteLine("请重新输入");
                }

                n++;

            }

        }
    }private void _29()
    {
        //编一个程序，有关系式 1*1+2*2+3*3+...+k*k <2000 编一个程序，求出满足此关系式的k的最大值
        static void Main(string[] args)
        {
            int sum = 0;
            int n = 1;
            while (sum<2000)
            {
                sum += sum + n * n;
                n++;
            }
            Console.WriteLine("{0}",n);

        }
    }
    private void _30()
    {
        //编一个程序，要求用while循环语句，打印1到100的正整数，每行打印5个数，每列右对齐
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=100)
            {
                Console.Write("{0,5:d1}",i);// Console.Write("{0,-5:d1}",i); 负5为向左对齐
                if (1%5==0)
                {
                    Console.WriteLine();
                }
                i++;
            }
        }
    }
}
