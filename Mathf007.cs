using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mathf007 : MonoBehaviour
{
    private void _61()
    {
        // 所谓"降序数"是指一个自然数的低位数字不大于高位数字的数
        //例如：64 55 321 都认为是降序数，但是623不是降序数
        //一位数字被认为是降序数。编一个程序，输入一个数，判定它是否为降序数
        //该程序是循环执行的，当输入的数为0时，则退出程序运行
        
        int i;
        int j;
        int m;
        int n;

        bool pos;
        
        while (true)
        {
            n = -1;
            while (n<=0)
            {
                if (n==0) // 如果输入为0就跳出循环
                {
                    return;
                }
                Console.WriteLine("请输入一个正整数");
                n = int.Parse(Console.ReadLine());
            }

            if (n<10)  // 一位数也是降序数
            {
                pos = true;
            }
            else
            {
                m = n;  // temp接受n的值
                i = 0;

                pos = true;
                while (m>0)
                {
                    j = m % 10;
                    m = m / 10;

                    if (i>j)
                    {
                        pos = false;
                        break;
                    }
                    i = j;
                }
            }

            if (pos)
            {
                Console.WriteLine("{0}是降序数",n);
            }
            else
            {
                Console.WriteLine("{0}",n);// 不是降序数
            }
        }
    }

    private void _62()
    {
        //所谓的"回文数"是指读一个自然数，从正方向读和反方向读，结果是一样的
        //例如：646.1551，891232198都认为是回文数，编一个程序：输入一个正整数
        //判定它是否为回文数，当输入的数为0时，则退出程序，否则继续循环执行程序

        int s;
        int k;
        int i;
        int[] a=new int[20];

        bool pos;
        while (true)
        {
            s = -1;
            while (s<0)
            {
                Console.WriteLine("请输入一个正整数或者只按一个数字0:");
                s = int.Parse(Console.ReadLine());
                if (s==0)
                {
                    return;
                }
            }
            k = s;
            pos = true;
            i = -1;
            while (k > 0)
            {
                i++;
                a[i] = k % 10; // 保存
                k = k / 10;
            }

            for (int j = 0; j <  (i+1)/2; j++) // 进行判断 位数对称相等
            {
                if (a[j]!=a[i-j])
                {
                    pos = false;
                    break;
                }
            }

            if (pos)
            {
                Console.WriteLine("{0}是回文数",s);
            }
            else
            {
                Console.WriteLine("{0}不是回文数。",s);
            }
        }
    }

    private void _63()
    {
        //编一个程序，定义一个n行n列的二维数组，例如，n=4输入该数组的全部数据，可以定义数组时赋予常量值。
        //求二维数组中这样元素的位置：它在行上是最小，在列上也是最小
        //（注意：它未必是整个数组的最小元素）

        int n = 4;
        int[,] a =
        {
            {25, 12, 22, 14},
            {15, 16, 17, 18},
            {19, 20, 21, 13},
            {23, 24, 11, 26}
        };
        // int i;
        //  int j =0;
        int temp=0;
        int min=0;
        
        Console.Write("\n二维数组");
        for (int i = 0; i < n; i++)//每行
        {
            Console.Write("\n\t");
            for (int j = 0; j < n; j++)//每列
            {
                Console.Write("{0}",a[i,j]);
            }
        }
        Console.WriteLine("\n\n 行列的最小值 ：");
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                temp = a[i, j];
                min = temp;
                for (int k = 0; k < n; k++) // 行的最小值
                {
                    if (a[i,k]<min)
                    {
                        min = a[i, k];
                    }
                }
                for (int l = 0; l < n; l++) // 列的最小值
                {
                    if (a[l,j]<min)
                    {
                        min = a[l,j];
                    }
                }

                if (temp==min)
                {
                    Console.WriteLine("i={0},j={1},{2}",i,j,temp);
                    // 行列的最小值：
                    // i=0,j=1,12
                    // i=1,j=0,15
                    // i=2,j=3,13
                    // i=3,j=2,11
                }
            }
        }
    }

    private void _64()
    {
        //给定一个mxn的数值矩阵A，如果矩阵A中存在这样的一个元素A[i][j]满足条件：A[i][j]是第i行中值最小的元素
        //且又是第j列中值最大的元素，则称之为该阵的一个马鞍点。编写一个方法计算出m*n的矩阵A的所有马鞍点
        int i;
        int j;
        int k;
        int m = 4;
        int n = 5;
        int max;
        int min;
        int[,] array = new int[,]
        {
            {30,20,25,40,45},
            {80,19,70,90,11},
            {24,14,42,91,96},
            {32,17,82,72,38}
        };
        Console.Write("\n{0}行,{1}列的数值矩阵为：");
        for (int l = 0; l <m; l++)
        {
            Console.WriteLine();
            for (int o = 0; o < n; o++)
            {
                Console.Write("{0}",array[l,o]);
            }
        }

        for (int l = 0; l < m; l++)
        {
            for (int o = 0; o < n; o++)
            {
                max = array[l, o];
                min = array[l, o];
                for (int p = 0; p < n; p++)// 列中最小
                {
                    if (array[l,p]<min)
                    {
                        min = array[l, p];
                    }
                }

                for (int p = 0; p < m; p++)// 列中最大
                {
                    if (array[p,o]>max)
                    {
                        max = array[p, o];
                    }  
                }
                
                if (array[l,o]==max&&array[l,o]==min)
                {
                   Console.WriteLine("\n马鞍点是第{0}行，第{1}列的{2}",l,o,array[l,o]);
                }
            }

        }
    }
    
    private void _65()
    {
        //编一个程序，输入一个整数，判定它为几位数。例如，99是2位数，-100是3位数
        int m;
        int n;
        int k = 0;
        
        Console.WriteLine("请输入一个整数：“");
        m = int.Parse(Console.ReadLine());
        n = Math.Abs(m);

        while (n!=0)
        {
            n = n / 10;
            k++;
        }

        if (n==0)
        {
            Console.WriteLine("0是一位数。");
        }

        while (n!=0)
        {
            n = n / 10;
            k++;
        }
        Console.WriteLine("{0}是{1}位数。",m,k);
    }

    private void _66()
    {
        //编一个程序，定义一个字串符数组，输入若干国家名称（所有名称全用大写或者全用小写），设计一个算法按
        //字典顺序将这些国家名称进行排序。
        
        int n = 10;
        string temp;
        
        string[] SortArray = new string[n];
        Console.WriteLine("\n 请输入{0}个字串符：",n);
        for (int i = 0; i < n; i++)
        {
            SortArray[i] = Console.ReadLine();
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j <n-i ; j++)
            {
                if (string.Compare(SortArray[j],SortArray[j+1])>0)
                {
                    temp = SortArray[j];
                    SortArray[j + 1] = SortArray[j + 1];
                    SortArray[j + 1] = temp;
                } 
            }
        }
        Console.WriteLine("已经排序后地国家名称为");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(SortArray[i]);
        }
    }

    public class Student
    {
        public string 学号;
        public string 姓名;
        public int 年龄;
        public int CSharp程序设计的成绩;
    };
    
    private void _67()
    {
        //编一个程序，定义类student 和 它的成员（学号，姓名，年龄 和 C_sharp 程序设计成绩
        //用类 student 生成对象s，分别对对象s的成员赋值，然后输出对象s。

        Student s;
        s = new Student();
        s.学号 = "123456";
        s.姓名 = "张三";
        s.年龄 = 21;
        s.CSharp程序设计的成绩 = 90;
        Console.WriteLine("学生学号：{0}",s.学号);
        Console.WriteLine("学生的姓名:{0}",s.姓名);
        Console.WriteLine("学生的年龄：{0}",s.年龄);
        Console.WriteLine("程序设计的成绩：{0}",s.CSharp程序设计的成绩);
    }

    struct  Contact
    {
        public string name;
        public int age;
        public string telephone;
        
    }

     private void _68()
    {
        // 编一个程序，定义结构（又姓名，年龄，手机号码三个字段）再定义一个一维数组
        // 把结构作为数组元素类型，存入数据，然后依次输出
        Contact[] c = new Contact[3];
        c[0].name = "张三";
        c[0].age = 10;
        c[0].telephone = "132312312";

        c[1].name = "李四";
        c[1].age = 20;
        c[1].telephone = "8231728412";

        c[2].name = "王五";
        c[2].age = 30;
        c[2].telephone = "12312312321";

        Console.Write("姓名：{0}", c[0].name);
        Console.Write("年龄:{0}",c[0]);
        Console.Write("手机号码：{0}",c[0].telephone);
        
        Console.Write("姓名：{0}", c[1].name);
        Console.Write("年龄:{0}",c[1]);
        Console.Write("手机号码：{0}",c[1].telephone);
        
        Console.Write("姓名：{0}", c[2].name);
        Console.Write("年龄:{0}",c[2]);
        Console.Write("手机号码：{0}",c[2].telephone);
        
    }

     public class ClassContact
     {
         public string name;
         public int age;
         public string tele;

     };
     

     private void _69()
    {
        //编一个程序，定义类（有姓名，年龄，手机号码，三个字段）再定义一个一维数组，
        //使数组元素为类，存入数据，然后依次输出，使用for循环语句进行输入输出操作
        
        int n = 3;
        ClassContact[] c = new ClassContact[n];
        for (int j = 0; j < n; j++)
        {
            c[j]=new ClassContact();
        }
        for (int k = 0; k < n; k++)
        {
            Console.Write("请输入学生的名字：");
            c[k].name = Console.ReadLine();
                
            Console.Write("请输入学生年龄：");
            c[k].age = int.Parse(Console.ReadLine());
                
            Console.Write("请输入手机号码");
            c[k].tele = Console.ReadLine();

        }

        for (int i = 0; i <n ; i++)
        {
            Console.Write("姓名{0}",c[i].name);
            // Console.WriteLine(); 分行
            Console.Write("年龄{0}",c[i].age);
            // Console.WriteLine(); 分行
            Console.Write("手机号码{0}",c[i].tele);
        }
    }

     
     public class ClassName
     {
         public static double Compare(double x, double y, double z)
         {
             double temp;
             if (x>y)
             {
                 temp = x;
             }
             else
             {
                 temp = y;
             }

             if (z>temp)
             {
                 temp = z;
             }
             return temp;
         }
     };

     private void _70()
    {
        //编一个程序 输入三个double类型数据，自定义一个静态方法，把这三个数送给它
        // 返回找出的最大数
        Console.Write("请输入一个实数：");
        double x = double.Parse(Console.ReadLine());
        Console.Write("请输入一个实数：");
        double y = double.Parse(Console.ReadLine());
        Console.Write("请输入一个实数“");
        double z =double.Parse(Console.ReadLine());
        double temp = ClassName.Compare(x, y, z);
        Console.WriteLine("比较后最大值为{0}",temp);
    }

   
}

