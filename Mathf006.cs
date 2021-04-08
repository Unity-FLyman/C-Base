using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mathf006 : MonoBehaviour
{
    private void _51()
    {
       //编一个程序，输入一个字符串，用TocharArray()方法把字符串中的内容拷贝到字符数组中
       //然后用foreach输出该字符数组
       static void Main(string[] args)
        {
            // string -> char 
            string s = "";
           s= Console.ReadLine();
           char[] ch;
           ch = s.ToCharArray();
           foreach (var c in ch)
           {
               Console.WriteLine(c);
           }
        }
    }

    private void _52()
    {
        // 编一个程序，定义一个字符串变量，输入字符串，然后再输入一个字符，在字符串中查找该字符出现的次数
        string a;
        char b;
        int d=0;

        a = Console.ReadLine();
        char[] alls = a.ToCharArray();
        b = char.Parse(Console.ReadLine());
        for (int i = 0; i < alls.Length; i++)  
        {
            if (alls[i]==b)
            {
                d++;
            }
        }
        Console.WriteLine("字符串{0}出现的次数为{1}",b,d);
    }

    private void _53()
    {
        // 编一个程序，定义一个字符串变量，输入字符串，判断有没有连续重复字符出现
        // 统计重复字符出现次数，
        // 例如 aaabccdfff，其中a重复出现了二次，c重复出现了一次，f重复出现了二次，共计字符重复五次

        
        int n = 0;
        string a = Console.ReadLine();
        
        for (int i = 1; i <a.Length-1 ; i++)// 便利所有字符
        {
            if (a[i]==a[i-1]) // 如果等于前一个字符就 n++
            {
                n++;
            }
        }
        Console.WriteLine("{0}",a);

    }

    private void _54()
    {
        
        // 编一个程序，利用for语句，打印一个如下形式的一个直角三角形，顶点在屏幕中线上，行数从键盘输入
       //*
       //**
       //***
       //****

       //int i;
       //int j;
       int n = 0;
       int m = 40; // 宽度的一半

       while (n<=0)
       {
           Console.WriteLine("请输入一个正整数：");
           n = int.Parse(Console.ReadLine());
       }
       
       Console.WriteLine('\n');
       for (int i = 1; i <=n; i++)
       {
           Console.Write('\n');
           //Console.WriteLine
           for (int j = 0; j <=m; j++)
           {
               Console.Write(' '); //打印空格
           }

           for (int j = 0; j <= i; j++)
           {
               Console.Write('*');
           }
       }
       Console.WriteLine();
    }

    private void _55()
    {
        // 编一个程序 ，利用for语句，打印一个如下形式的一个等腰三角形
        // 顶点在屏幕中线上，行数从键盘输入
        //       *
        //      * *
        //     * * *
        //    * * * *


        int n = 0;
        int m = 45;// 宽度的一半
        int b = 0;
        
        while (n<=0)
        {
            Console.WriteLine("请输入一个正整数：");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine('\n');
        for (int i = 0; i <= n; i++)
        {
            //先处理行数
           
            for (int j = 0; j < m; j++)
            {
                Console.Write(' '); //打印空格
            }
            m--;
            // 处理星号
            for (int j = 0; j < i; j++)
            {
                Console.Write('*');
                Console.Write(' ');
            }
        }
    }
    
    private void _56()
    {
        //定义一个一维数组，输入任意6个整数，假定为7,4,8,9,1,5
        //编一个程序，利用for语句 输出如下方阵图
        
        //7 4 8 9 1 5
        //5 7 4 8 9 1
        //1 5 7 4 8 9
        //9 1 5 7 4 8
        //8 9 1 5 7 4
        //4 8 9 1 5 7
        
        static void Main(string[] args)
        {
            int[] num =new int[6]; 
            for (int i = 0; i < 6; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < 6; i++)
            {
               // 先输出第一行的数组
               Console.Write(num[i]);
            }

            for (int i = 0; i < 5; i++) //输出最后5行
            {
                Console.WriteLine();//先分开一行
                
                int temp = num[5];     
                for (int j = 5; j>=0; j++)
                {
                    num[j] = num[j - 1];
                }
                num[0] = temp;
                
                for (int j = 0; j < 6; j++) //输出数组
                {
                    Console.Write("{0}",num[j]);
                }
            }
        }
    }

    private void _57()
    {
        //编一个程序，定义一个n行n列的二维整数数组，赋初值，然后求出对角线的元素和

        int n = 5;
        int m = 6;
        // 二维数组
        int[,] arr =
        {
            {1,  2 , 3 ,  4,  5},
            {6,  7 , 8 ,  9, 10},
            {11, 12, 13, 14, 15},
            {16, 17, 18, 19, 20},
            {21, 22, 23, 24, 25}
        };
        
        // 对角线元素 
        // {0,0}  {0,4}   0  
        // {1,1}  {1,3}   1  
        // {2,2}          2
        // {3,3}  {3,1}   3 
        // {4,4}  {4,0}   4  
 
        int sum = 0;
        
        for (int i = 0; i < arr.GetLength(0); i++) // 5行
        {
            for (int j = 0; j < arr.GetLength(1); j++) // 5列
            {
                if (i==j||i+j==5-1)
                {
                    // 写入
                    sum += arr[i, j];
                }
            }
        }
        Console.WriteLine(sum);
    }

    private void _58()
    {
        //编一个程序,输入一个正整数，判断是否为素数，如不是，则输出其所有正约数
        //15能被3整除，我们就说15是3的倍数，3是15的约数。 正约数表示正的约数。

        
        int a =int.Parse( Console.ReadLine());
        int n = 0;
        bool f = true;

        for (int i = 2; i < a; i++)
        {
            if (a%i==0) // 不是素数
            {
                f = false;
                break;
            }
        }
        if (f) // 是 素数
        {
            Console.WriteLine("{0}是素数",n);
        }
        else
        {
            Console.WriteLine("{0}不是素数",n);
            
            int b = 2;
            int flag = 0;
            while(b<=a) //因素分解
            {
                while (a%b==0)
                {
                    a = a / b;
                    if (flag !=0)
                    {
                        Console.Write('*');//乘法符号
                    }

                    flag = 1;
                    Console.Write("{0}",1);
                }

                b++;

            }
        }
        // Console.writeLne;

    }

    private void _59()
    {
        // 编一个程序，输入一个代表身份证号码的字符串，判断字符串长度(18)是否正确，还要判断输入的每个字符是否为数字，否则要求重新输入
        string a;
        bool q = true;
        Console.WriteLine("请输入你的身份证号码");
        a = Console.ReadLine();
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i]>='0'&&a[i]<'9') // 如果输入为数字的话
            {
                continue;
            }
            else
            {
                q = false;
            }
        }
        
        if (a.Length==18) // 如果长度为18
        {
            if (q==true)
            {
                Console.WriteLine("输入正确！");
            }
            else
            {
                Console.WriteLine("输入错误");
            }

        }
            
        else if (q == false)
        {
            Console.WriteLine("输入不合适");
        }

    }

    private void _60()
    {
        // 编一个程序，输入一个正整数n，把它转换为二进制数，并输出，提示：应该利用数组
        int[] a = new int[80];
        int i;
       // int k;
        int n = 0;
        
        while (n <= 0)
        {
            Console.WriteLine("请输入一个正整数");
            n = int.Parse(Console.ReadLine());
        }

        i = 0;
        while (n>0)
        {
            //即先对 i 加 1，再返回a[i]的值
            a[++i] = n % 2; //0,1 // 十进制的话就 0~9  // 十六进制 0~15 
            n = n / 2;
        }

        for (int k = 0; k>0; k--)
        {
            Console.Write(a[k]);
        }
        Console.WriteLine();
    }
}
