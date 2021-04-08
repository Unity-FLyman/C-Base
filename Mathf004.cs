using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Mathf004 : MonoBehaviour
{
    private void _31()
    {
        // Fibonacci序列的前二项是0和1,且每一个后续项是前二项的和，编一个程序，输出项值不大于100的Fibonacci序列
        static void Main(string[] args)
        {
            // 0 1 1 2 3 5 8 13 ···· 
          
            int a = -1;
            int b = 0;
            int n = 1;
            while (n<=100)
            {
                b = n; //1 0  1  1 2 3 5 
                
                n = a + b;// 0  1 1 2 3 5 8  
              
                a = b;//1 0 1 1 2 3 5
                
                Console.WriteLine("{0}  ",n);
            }
        }
    }
    private void _32()
    {
        //编一个程序，输入a，b,c的值 求出一元二次方程a*x*x+b*x+c=0 的两个实数根。计算两个实数根。计算两个实数根必须使用Math类中的Sqrt()方法；
        //计算指定数的开方，计算二个实数根
        //可以用公式 b^-4ac;  -b+√(b2-4ac)/2a -b-√(b2-4ac)/2a
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            float x1;
            float x2;
            
            Console.WriteLine("请输入a，b，c的值");
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (b*b-4*a*c>=0)
            {
                x1 = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2 = (-b - Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("这个方程的两个根是{0},{1}",x1,x2);
            }
            else
            {
                Console.WriteLine("无解");
            }
        }
    }
    private void _33()
    {
        //编一个程序，利用while循环语句，找出2到100之间的素(质)数
        static void Main(string[] args)
        {
            // 2也是质数 
            int i=2;
            int j=2;
            bool isZ;
            while (i<=100)
            {
                isZ = true;
                j = 2;
                while (j<=i-1) // 先把2 输出 2<=1  ????
                {
                    if (i%j==0)
                    {
                        isZ= false;
                        break;
                    }

                    j++; //3 
                }

                if ( isZ==true)
                {
                    Console.Write("{0}",i);
                }

                i++;
            }
        }
    }
    private void _34()
    {
        //编一个程序，用while循环语句实现下列功能：有一篮鸡蛋，不止一个，有人两个两个数，多余一个，三个三个数，多余一个
        // 再四个四个地数，也多余一个，请问这篮鸡蛋
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                n++;
                if (n%2==1 &&n%3==1 &&n%4==1)
                {
                    Console.WriteLine("{0}",n);
                    break;
                }
            }
        }
    }
    private void _35()
    {
        //编一个程序，用for循环语句求出1到100之间的奇数之和
        static void Main(string[] args)
        {
            int s = 0;
            for (int j = 0; j < 100; j++)
            {
                if (j%2!=0)
                {
                    s = s + j;
                }
                j++;
            }
        }
    }
    private void _36()
    {
        //编一个程序，利用二重for循环语句，打印出九九乘法口诀表
        static void Main(string[] args)
        {
            int s = 0;
            for (int i = 0; i < 10; i++)
            {
                // 0~9
                for (int j = 9; j >=0; j--)
                {
                    // 9~0;
                    s = i * j;
                }
            }
           
        }
    } 
    private void _37()
    {
        //编一个程序，定义一个有10个元素的数组，使用for循环语句
        //从键盘上输入10名同学的数学成绩
        //分别求出最高分和最低分，并且求出10名同学的数学平均成绩
        static void Main(string[] args)
        {
            float[] num = new float [10];
            for (int i = 0; i <= 10; i++)
            {
                // 输入10次
                num[i] = float.Parse(Console.ReadLine());
            }

            float max = 0;
            float min = 0;
            float ave = 0;
            float sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]>max)
                {
                    max = num[i];// 覆盖最高分
                }

                if (num[i]<min)
                {
                    min = num[i];// 覆盖最低分
                }

                sum += num[i];
            }
            ave = sum / 10;
        }
    } 
    private void _38()
    {
        //编一个程序，利用for循环语句，求出1!+2!+3!+....+10!的和
        // 2的阶乘= 1X2
        // 3的阶乘= 1X2X3
        // 4的阶乘= 1X2X3X4
        static void Main(string[] args)
        {
            int s = 0;
            int jc = 1;
            for (int i = 0; i <=10; i++)
            {
                jc = jc * i;
                s += jc;
            }
        }
    }
     private void _39()
    {
        //编一个程序，用for循环语句求出1到100之间的奇数之和以及偶数之和
        static void Main(string[] args)
        {
            int sum = 0;
            //奇数和
            for (int i = 0; i < 100; i++)
            {
                if (i%2 !=0)
                {
                    sum += i;
                }
            }
            //偶数和
            for (int i = 0; i <=100; i++)
            {
                if (i%2 ==0)
                {
                    sum += i;
                }
            }
        }
    }
     private void _40()
    {
        //编一个程序，用for循环语句，从键盘输入10个实数，分别求出它们中的正数之和以及负数之和
        static void Main(string[] args)
        {
            int i;
            float sum1 = 0;
            float sum2 = 0;
            float x;
            for (int j = 0; j <11; j++)
            {
                x = float.Parse(Console.ReadLine());
                if (x>0)
                {
                    sum1 += x;
                }

                if (x<0)
                {
                    sum2 += x;
                }
            }
            Console.WriteLine("正数之和{0},负数之和{1}",sum1,sum2);
        }
    } 
    
    
    
    
    
    
    
    
}
