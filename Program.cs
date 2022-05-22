// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//using Math;
Console.WriteLine("Dame un numero");
float x=Int32.Parse(Console.ReadLine());
Console.WriteLine("Valor absoluto de el numero : "+ Math.Abs(x));
Console.WriteLine("El cuadrado de el numero : "+ Math.Pow(x,2));
Console.WriteLine("El seno el numero : "+ Math.Sin(x));
Console.WriteLine("El coseno de el numero : "+ Math.Cos(x));
Console.WriteLine("Parte entera : "+ Math.Truncate(x));
Console.WriteLine("El cuadrado de el numero : "+ Math.Pow(x,2));
Console.WriteLine("dame otro numero : ");
int y=Int32.Parse(Console.ReadLine());
Console.WriteLine("El maximo entre los dos numeros : "+ Math.Max(x,y));
Console.WriteLine("El minimo entre los dos numeros : "+ Math.Min(x,y));