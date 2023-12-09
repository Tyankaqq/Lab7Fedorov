////Регулярные выражения
//using System.Text.RegularExpressions;

//string pattern = @"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)";
//string[] data = new string[]
//{
//    "tyanka@mail.ru",
//    "slagmer@gmail.com",
//    "focusbtw.kbk.ru",
//    "maryday@mail.ru"
//};
//for (int i = 0; i < data.Length; i++)
//{
//    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase)) 
//}
//try
//{

//    Console.Write("Введите сторону AB:");
//    double ab = double.Parse(Console.ReadLine());
//    Console.Write("Введите сторону CD:");
//    double cd = double.Parse(Console.ReadLine());
//    Console.Write("Введите сторону AC:");
//    double ac = double.Parse(Console.ReadLine());
//    double bc = Perimetr(ab, ac);
//    double bd = Perimetr(bc, cd);
//    Console.WriteLine($"P={ab + ac + cd + bd:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//double Perimetr(double a, double b)
//{
//    return Math.Sqrt(a * a + b * b);
//}
//Print();
//void Print()
//{
//	for (int i = 0; i < 80; i++)
//	{
//        Console.Write("*");
//    }
//}
//try
//{

//    Console.WriteLine("Введите количество символов:");
//    int n = int.Parse(Console.ReadLine());
//    Print(n);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//void Print(int n)
//{
//    for (int i = 0; i < n; i++) Console.WriteLine("*");
//}
//Передача параметров в метод
//int a = 6, b = 8;
////Console.WriteLine(a+" "+b);
////SwapRef(ref a,ref b);
////Console.WriteLine(a + " " + b);
//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    long fact;
//    Factorial(n, out fact);
//    Console.WriteLine("Factorial=" + fact);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.Write("Введите m:");
//int m;
//int.TryParse(Console.ReadLine(), out m);
//Console.WriteLine(2*m);
//Print(in m);
//void Print(in int n)//входной параметр in
//{
//    for (int i = 0; i < n; i++) Console.Write("*");
//}
//void Factorial(int n, out long fact) //выходной параметр out
//{
//    fact = 1;
//    for (int i = 1; i < n; i++) fact *= i;
//}
//void Swap(int x, int y)//параметры передаются по значению
//{
//    int temp = x; x = y; y = temp;
//}
//void SwapRef (ref int x, ref int y)//передача параметров по ссылке ref
//{
//    int temp=x; x = y; y = temp;
//}

using System;

class Program
{
    static void Main()
    {
        // Пример использования для пары A и B
        int A = 48;
        int B = 18;
        int resultAB = NOD(A, B);
        Console.WriteLine($"НОД({A}, {B}) = {resultAB}");

        // Пример использования для пары A и C
        int C = 36;
        int resultAC = NOD(A, C);
        Console.WriteLine($"НОД({A}, {C}) = {resultAC}");

        // Пример использования для пары A и D
        int D = 72;
        int resultAD = NOD(A, D);
        Console.WriteLine($"НОД({A}, {D}) = {resultAD}");
    }

    static int NOD(int A, int B)
    {
        if (A == 0)
            return B;
        else
            return NOD(B % A, A);
    }
}
