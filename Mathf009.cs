using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Random = System.Random;

public class Mathf009 : MonoBehaviour
{


    public class Complex
    {
        private float real;
        private float iamge;

        public Complex(float a, float b)
        {
            // 定义一个Complex类型
            this.real = a;
            this.iamge = b;

        }

        public static Complex operator +(Complex a, Complex B)
        {
            return new Complex(a.real + B.real, a.iamge + B.iamge);
        }

        public static Complex operator -(Complex a, Complex B)
        {
            return new Complex(a.real - B.real, a.iamge - B.iamge);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex((a.real * b.real) - (a.iamge * b.iamge), (a.real * b.iamge) + (a.iamge * b.real));
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex((a.real * b.real + a.iamge * b.iamge) / (b.real * b.real + b.iamge * b.iamge),
                (a.iamge * b.real - a.real * b.real - a.real * b.iamge) / (b.real * b.real + b.iamge * b.iamge));
        }

        public void Print()
        {
            Console.Write(real + "+(" + iamge + ")i\n");
        }


    };

    private void _80()
    {
        //控制台应用程序，定义描述复数的类Complex 具体要求如下
        //通过重载运算符 + - * / 直接实现两个和复数之间的各种运算
        //其中，两个复数相乘的计算方式(a+bi)*(c+di)=(ac-bd)+(ad+bc)i;
        //两个复数相除的计算公式(a+bi)/(c+di) =(ac+bd)/(c*c+d*d)+(bc-ad)/(c*c+d*d);
        //定义主函数测试类，在主函数中定义两个复数2+3i和1+2i，实现两个复数的加减，并将结果输出

        Complex a1 = new Complex(2, 3);
        Complex a2 = new Complex(1, 2);
        Complex c = a1 + a2;

        c.Print();
        Complex d = a1 - a2;
        d.Print();
        Complex e = a1 * a2;
        e.Print();
        Complex f = a1 / a2;
        f.Print();

    }

    public class Maxer
    {

        public string Max()
        {
            return "";
        }

        public int Max(int a, int b, int c, int d)
        {
            int j = 0;
            // 集合用count，数组用length
            int[] x = new int[4] {a, b, c, d};
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i + 1] > x[i])
                {
                    j = x[i + 1];
                }
            }

            return j;
        }

        public double Max(double a, double b, double c, double d)
        {
            double j = 0;
            // 集合用count，数组用length
            double[] x = new double[4] {a, b, c, d};
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i + 1] > x[i])
                {
                    j = x[i + 1];
                }
            }

            return j;
        }

        public string Max(string a, string b, string c, string d)
        {

            string j = "";
            string[] x = new String[4] {a, b, c, d};
            for (int k = 0; k < 4; k++)
            {
                if (x[k].Length > j.Length)
                {
                    j = x[k];
                }
            }

            return j;
        }
    }



    private void _81()
    {
        //定义Maxer类具体要求如下
        //类中声明的方法Max() 要有三种重载方式
        //在Main方法中调用时，会根据实参的数据类型（int，double，string）来自动调用相应的方法
        //求各种类型中最大数
        //(比如：输入13、45、-78、70就输出最大数为45：输入3.4、78.2、12.6就能输出最大值为78.2;输入“love”、“beijing”就输出最长的字符串“beijing”)

        Maxer m1 = new Maxer();
        Console.WriteLine("int最大数：{0}", m1.Max(1, 2, 3, 4));

        Console.WriteLine("double最大数：{0}", m1.Max(1.0, 2.0, 3.0, 4.0));

        Console.WriteLine("double最大数：{0}", m1.Max("a", "b", "c", "d"));

    }



    // 基类
    public class CPoint
    {
        private int x;
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }

        }

        public int X
        {
            get => x;
            set => x = value;
        }

        public CPoint() //构造赋值
        {
            X = 20;
            Y = 30;
        }

        public void Display(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public String toString()
        {
            return "(" + x + "," + y + ")";

        }
    };

    public class Cline : CPoint
    {
        private float a;
        private float b;

        public Cline()
        {

        }

        public Cline(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public float Dista()
        {
            return (float) Math.Sqrt((a - 20) * (a - 20) + (b - 30) * (b - 30));
        }

    };

    public class CRect : Cline
    {
        private float width;
        private float Height;


        public CRect(float width, float height) : base()
        {


        }

        public CRect(float a, float b, float width, float height) : base(a, b)
        {
            this.width = width;
            this.Height = height;

        }

        public float Aera()
        {
            return width * Height;

        }

        //周长
        public float Perim()
        {
            return 2 * (width + Height);
        }
    }



    private void _82()
    {
        //把定义平面直角坐标系上的一个点的类CPoint作为基类，派生出描述一条直线的类CLine，在派生出一个矩形类CRect
        //要求成员函数能求出给定的两点（20，30）间的距离、矩形的周长和面积，编写完整的控制台程序，要求：
        //1、类CPoint中定义两个私有变量x、y、int类型及能够访问到它们的公有属性；
        //2、类CPoint中定义带有两个参数的构造函数及能够输出两个点的方法display();
        //3、类Cline派生自类CPoint，也有自己的构造函数及输出直线的方法Dista();
        //4、矩形类CRect派生子类Cline，有自己的构造函数，计算矩形的周长方法是Perim（），面积是Area（）；

        CPoint a = new CPoint();
        a.Display(100, 200);
        Cline b = new Cline(100, 200);
        CRect c = new CRect(20, 30, 12, 6);
        Console.WriteLine("新得到得点坐标是：" + a.toString());
        Console.WriteLine("这个距离为：" + b.Dista());
        Console.WriteLine("矩形的面积为：" + c.Aera());
        Console.WriteLine("矩形的周长为：" + c.Perim());
    }

    public class StuInfo
    {
        private string name;
        private string num;

        public string Num
        {
            get { return num; }
            set { num = value; }

        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        private int Chin;
        private int English;
        private int Math;

        // 把三门课程都定义成属性
        public int Chin1
        {
            get => Chin;
            set => Chin = value;
        }

        public int English1
        {
            get => English;
            set => English = value;
        }

        public int Math1
        {
            get => Math;
            set => Math = value;
        }

        public StuInfo(string name, string num, int chin, int english, int math)
        {
            this.Name = name;
            this.Num = num;
            this.Chin1 = chin;
            this.English1 = english;
            this.Math1 = math;
        }

        public int SumOfScore()
        {

            return this.Chin1 + this.English1 + this.Math1;
        }

        public int AvaerageOfScore()
        {
            return (this.Chin1 + this.English1 + this.Math1) / 3;
        }
    };

    private void _83()
    {
        //定义一个描述学生基本情况的类StuInfo。具体需求如下：
        //1、类中包括私有的数据成员字段：姓名name，学号num，类型为string，课程chi 课程english 课程 math 类型为int
        //2、定义对字段的共有访问属性
        //3、定义构造函数对类中的字段进行初始化。
        //4、定义共有方法求总成绩和平均成绩，方法原型如下
        //public int sumOfScore();
        //public int averageOfScore();
        //5、定义测试类，在测试类的主函数中，声明一个Stuinfo的对象（"张三"，”1001“，68，78，80）调用相应的方法，输出其总分和平均分


        StuInfo stu = new StuInfo("张三", "1001", 10, 20, 30);

        Console.WriteLine("总分是{0}", stu.SumOfScore());
        Console.WriteLine("平均分{0}", stu.AvaerageOfScore());

    }

    public class Person
    {
        private string name;
        private string number;
        private string sex;


        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Number
        {
            get => number;
            set => number = value;
        }

        public string Sex
        {
            get => sex;
            set => sex = value;
        }

        public Person(string name, string number, string sex)
        {
            this.Name = name;
            this.Number = number;
            this.Sex = sex;
        }
    };


    public class Student : Person
    {
        private int score;

        public int Score
        {
            get => score;
            set => score = value;
        }

        public Student(string name, string number, string sex, int score) : base(name, number, sex)
        {
            this.Score = score;
        }

        public void Print()
        {
            Console.WriteLine("姓名：" + this.Name + "\n编号：" + this.Number + "\n性别：" + this.Sex + "\n成绩" + this.Score);
        }
    }

    private void _84()
    {
        // Person类的具体要求如下：
        // 1、包括私有数据成员：姓名name，编号 number ， 性别 sex 均为string 类型
        // 2、定义私有数据成员的公有访问属性
        // 3、定义Person的构造函数，用于对三个数据成员赋值
        // Student 类的具体要求
        // 1、增加私有数据成员：成绩score，int类型
        // 2、定义私有数据成员 score的公有访问属性
        // 3、定义Student的构造函数，可以对本类中及父类的成员进行初始化。
        // 4、定义输出函数，可以输出学生的详细信息。原型如下
        // 5、在主函数中定义一个学生zs，姓名为：张三，编号为：1001 性别为：男 成绩为80，调用student类输出张三所有信息

        Student zs = new Student("张三：", "123", "男", 80);
        zs.Print();
        Console.Read();
    }


    public class Card
    {
        private string CardValue;
        private string CardType;

        public Card(string m, string l)
        {
            this.CardValue = m;
            this.CardType = l;
        }

        public override string ToString()
        {
            return CardType + "" + CardValue;
        }
    }


    private static Card[] allCards = new Card[52];
    private static string[] ms = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
    private static string[] ls = {"红桃", "方块", "梅花", "黑桃"};

    private static void Shuffle()
    {
        Random r =new Random();
        Card tempCard;
        
        //依次遍历所有的牌与随机位置交换位置
        for (int i = 0; i < allCards.Length; i++)
        {
            int ran = r.Next(52);
            tempCard = allCards[i];
            allCards[i] = allCards[ran];
            allCards[ran] = tempCard;

        }
    }

    private static void Init()
    {
        for (int i = 0; i < allCards.Length; i++)
        {
            allCards[i]=new Card(ms[i%13],ls[i%4]);
        }
    }


    private static void ShowCard()
    {
        foreach (var card in allCards)
        {
            Console.Write( card.ToString()+"");
        }
        
    }

    private void _85()
    { 
        //写一个洗牌程序
        
        Init();
        ShowCard();
        Console.WriteLine();
        
        Shuffle();
        ShowCard();
        Console.WriteLine();
        Console.ReadKey();
    }

}


