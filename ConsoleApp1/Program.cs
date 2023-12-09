//передача массива в качестве параметра функции 
//Random random = new Random();
//int[] mas = new int[random.Next(10,21)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
///*mas = */SortMas(mas);
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write(mas[i]+" ");
//}
//void /*int[]*/ SortMas(int[] mas)
//{
//    for (int i = 0; i < mas.Length-1; i++)
//    {
//        for (int j = i+1; j < mas.Length; j++)
//        {
//            if (mas[i] > mas[j])
//            {
//                int temp = mas[i];
//                mas[i] = mas[j];
//                mas[j] = mas[i];
//            }
//        }
//    }
//    //return mas;
//}
//Массив параметров
//void Sum(params int[] numbers)
//{
//    int result = 0;
//    foreach (int number in numbers) result += number;
//    Console.WriteLine("Sum=" + result);
//}
//void Mult(int n, params int[] numbers)
//{
//    int mult = n;
//    foreach (int number in numbers) mult *= number;
//    Console.WriteLine(mult);
//}
//int[] mas = { 1, 5, 7, 4, 7, 9, 8 };
//Sum(mas);
//Sum(1, 4, 83, 6, 3, 7, 4, 8);
//Mult(10, 8, 57, 9, 7, 94, 3);
////Рекурсия
//long Fact(int n)
//{
//    long F = 1;
//    for (int i = 1; i <= n; i++) F *= i;
//    return F;
//}
//long FactRecursive(int n)
//{
//    if (n == 0||n==1) return 1;
//    return n * FactRecursive(n - 1);
//}
//try
//{
//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(Fact(n));
//Console.WriteLine(FactRecursive(n));
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
////}
//int Primer1(int n)
//{
//    if (n==0) return 0;
//    else if (n%2==0) return Primer1(n/2);
//    else return 1+Primer1(n-1);
//}
//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    Console.WriteLine(Primer1(n));
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//int DoOperation(int a, int b, int op)
//{
//    switch (op)
//    {
//        case 1: return a + b;
//        case 2: return a - b;
//        case 3: return a * b;
//        case 4: if (b != 0) return a / b; return 0;
//        default: return 0;
//    }
//}
//int DoOperationSwitch(int a, int b, int op)
//{
//    return op switch
//    {
//        1 => a + b,
//        2 => a - b,
//        3 => a * b,
//        4 => (b != 0) ? a / b : 0,
//        _ => 0
//    };
//}
//try
//{
//    Console.Write("Введите x:");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    int y = int.Parse(Console.ReadLine());
//    Console.WriteLine(DoOperation(x, y, new Random().Next(1, 6)));
//    Console.WriteLine(DoOperationSwitch(x, y, new Random().Next(1, 6)));
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Локальные функции 
//void Compare(int[] mas1, int[] mas2)
//{
//    int s1 = Sum(mas1); int s2 = Sum(mas2);
//    if (s1 > s2) Console.WriteLine($"{s1}>{s2}");
//    else if (s1 < s2) Console.WriteLine($"{s1} < {s2}");
//    else Console.WriteLine($"{s1} = {s2}");
//    int Sum(int[] mas)
//    {
//        int sum = 0;
//        foreach (int i in mas) 
//            sum += i;
//        return sum;
//    }
//}
//int[] mas1 = new int[new Random().Next(5, 11)];
//int[] mas2 = new int[new Random().Next(5, 11)];
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = new Random().Next(10, 100);
//}
//Compare(mas1, mas2);
//lab 6.2 Пример 
using Lesson;
try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите m:");
    int m = int.Parse(Console.ReadLine());
    int[,] mas = new int[n,m];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = new Random().Next(10,100);
            Console.Write(mas[i,j]+" ");
        }
        Console.WriteLine();
    }
    int[] result = Lesson.Class1.Negative(mas);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}