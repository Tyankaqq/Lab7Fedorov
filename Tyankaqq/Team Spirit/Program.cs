//базовый 26
//double P1 = 1, P2 = 1;
//double[] mas = new double[15];
//Random rand = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rand.NextDouble()*100;
//    Console.Write(mas[i] + " ");
//    if (mas[i] >= 0) P1 *= mas[i];
//    else P2 *= Math.Abs(mas[i]);
//}
//Console.WriteLine($"R={P1-P2}");
//Вариант 26 средний 
//double[] mas = new double[12];
//double[] mas2 = new double[12];
//Random rand = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = Math.Round (rand.NextDouble()*10,1);
//    mas2[i] = Math.Round(rand.NextDouble()*10,1);
//}
//foreach (double i in mas) Console.Write($"{i:F2} ");
//Console.WriteLine();
//foreach (double i in mas2) Console.Write($"{i:F2} ");
//Console.WriteLine();
//for (int i = 0;i < mas.Length;i++)
//{
//    for (int j = 0; j < mas2.Length; j++)
//    {
//        if (mas[i] == mas2[j]) mas[i] = 0;
//    }
//}
//foreach (double i in mas) Console.Write($"{i:F2} ");
//высокий 26
//Console.Write("Введите размер массива:");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random rnd = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next(10,100);
//    Console.WriteLine(Convert.ToString(mas[i], 2) + " ");
//}
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] += 10;
//    Console.WriteLine(Convert.ToString(mas[i], 2) + " ");

//}
//using System.ComponentModel.DataAnnotations;

//Console.Write("Введите размер массива:");
//int n = int.Parse(Console.ReadLine());
//int[] mas = new int[n];
//Random rnd = new Random();
//for (int i = 0; i < mas.Length; i++)
//{

//    mas[i] = rnd.Next(10, 100);
//    Console.WriteLine(Convert.ToString(mas[i], 2) + " ");
//}
//int max = mas[0];
//int min = mas[0];
//int indexmax = 0;
//int indexmin = 0;
//for (int i = 1; i < mas.Length; i++)
//{

//    if (mas[i] < min) 
//    { 
//        min = mas[i]; 
//        indexmin = i; 
//    }
//    if (mas[i] > max) 
//    { 
//        max = mas[i];
//        indexmax = i;
//    }
//}
//Console.WriteLine("max:" + max);
//Console.WriteLine("min:" + min);
//Console.WriteLine("Введите количество строк:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов:");
//int j = int.Parse(Console.ReadLine());
//int[,] mas = {{1,3,5},
//              {7,9,3}};
//int[,] mas2 = new int[n, j];
//for  (int i = 0; i < n; i++)
//{

//}
//12.23a
//int[,] mas = new int[7, 7];
//for (int i = 0; i < 7; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        int n = 7;
//        if ((i < j && i + j < 6)||(j<i&&i+j>6)||(i==j)||(i+j==6)) 
//            mas[i, j] = 1;
//        Console.Write(mas[i, j] + " ");
//    }
//    Console.WriteLine();
//}
////12.24a
//int[,] mas2  = new int[6, 6];
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        if (i + j + 1 > 6) mas2[i, j] = i + j - 5;
//        else mas[i, j] = i + j + 1;
//        Console.Write(mas[i,j] + " ");
//    }
//    Console.WriteLine();
//}
////12.25a
//int[,] mas3 = new int[12, 10];
//int count = 1;
//for (int i = 0; i < 11; i++)
//{
//    for (int j = 0; j < 12; j++)
//    {
//        mas3[i,j] = 2

//int[,] mas = new int[11,4];
//int s5 = 0;
//Random r = new Random();
//for (int i = 0; i < 11; i++)
//{
//	for (int j = 0; j < 4 ; j++)
//	{
//		mas[i, j] = r.Next(25, 30);
//		Console.Write(mas[i,j]+ " ");
//		if (i == 4) s5 += mas[i, j];
//   }
//    Console.WriteLine();
//}


//Console.Write("Введите k:");
//int k = int.Parse(Console.ReadLine());
//Console.Write("Введите t:");
//int t = int.Parse(Console.ReadLine());
//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//double[,] mas1 = new double[k, t];
//Random rand = new Random();

//int sr = 0;
//int r3ewhj = 0;
//for (int i = 0;i < k; i++)
//{
//	for (int j = 0; j < t; j++)
//	{
		
//		mas1[i, j] = r.Next(0, 101);
//		Console.Write(mas[i,j]+ " ");
//		if (j == n-1) sr += mas[i, j];
//		if (i == 0) r3ewhj += mas[i, j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Sr=" + sr / k);
//Console.WriteLine("r3ewj=" + r3ewhj / t);
