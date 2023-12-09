//Вариант 6 Выскокий уровень
try
{
    Console.Write("Введите A:");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите B:");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Введите C:");
    int c = int.Parse(Console.ReadLine());
    Console.Write("Введите D:");
    int d = int.Parse(Console.ReadLine());
    static int NOD(int a, int b)
    {
        if (a == 0)
            return b;
        else
            return NOD(b % a, a);
    }
    Console.WriteLine(NOD(a,b));
    Console.WriteLine(NOD(a,c));
    Console.WriteLine(NOD(a,d));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}