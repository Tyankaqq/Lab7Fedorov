//try
//{
//    Console.WriteLine("Введите радиус");
//    double radius = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите высоту");
//    double height = double.Parse(Console.ReadLine());
//    Cylinder cylinder = new Cylinder(radius, height);
//    cylinder.Print();
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//class Cylinder
//{
//    private double radius;
//    private double height;

//    public double Radius
//    {
//        get { return radius; }
//        set { radius = value; }
//    }
//    public double Height
//    {
//        get { return height; }
//        set { height = value; }
//    }
//    public Cylinder(double radius, double height)
//    {
//        this.radius = radius;
//        this.height = height;
//    }

//    public double getArea()
//    {
//        return 2 * Math.PI * radius * height + 2 * Math.PI * radius * radius;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Радиус:{radius} Высота:{height} Площадь:{getArea():F2}");
//    }
//}
using System.Runtime.InteropServices;

try
{
    Console.WriteLine("Введите название:");
    string name = Console.ReadLine();
    Console.WriteLine("Введите цену:");
    decimal price = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Введите производителя");
    string factory = Console.ReadLine();
    Product product1 = new Product(name, price,factory);
    product1.Print();
    Console.WriteLine("Введите курс доллара:");
    decimal kurs = decimal.Parse(Console.ReadLine());
    Console.WriteLine($"Цена в долларах:{product1.toDollars(kurs)}");
    product1.ToyotaMoney();
    Console.WriteLine($"Цена в долларах:{product1.toDollars(kurs)}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Product
{
    private string name;
    private decimal price;
    private string factory;

    public Product(string name, decimal price, string factory)
    {
        this.name = name;
        this.price = price;
        this.factory = factory;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Price
    {
        get { return price; }
        set { if (value >= 0) price = value;
            else price = 0;
        }
    }
    public string Factory
    {
        get { return factory; }
        set { factory = value; }
    }
    public 
    public decimal toDollars(decimal kurs)
    {
        return kurs * price;
    }
    public void ToyotaMoney()
    {
        if (Name.Contains("Toyota"))
            price = price * (decimal)1.2;
    }
}
