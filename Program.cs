//using Math;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//inicio de el punto de calculadora
bool valor=true; // valor booleano
int x,y;
int control;
int operaciones;
while (valor)
{
    Console.WriteLine("Cual operacion queres realizar?, 1 para suma, 2 para resta, 3 multipliacion 4 para division");
    operaciones=int.Parse(Console.ReadLine());
    switch (operaciones)
    {
        case 1:
            Console.WriteLine("Dame el primer valor");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo valor");
            y=int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de la suma"+suma(x,y));
            break;
        case 2:
            Console.WriteLine("Dame el primer valor");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo valor");
            y=int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de la resta"+resta(x,y));
            break;
        case 3:
            Console.WriteLine("Dame el primer valor");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo valor");
            y=int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de la multipliacion"+multiplicacion(x,y));
            break;
        case 4:
            Console.WriteLine("Dame el primer valor");
            x=int.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo valor");
            y=int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de la resta"+division(x,y));
            break;
    }
    Console.WriteLine("Queres hacer otra operacion??");
    control=int.Parse(Console.ReadLine());
    if (control!=0)
    {
        valor=false;
    }
}
int multiplicacion(int x, int y){
    return (x*y);
}
float division(int x, int y){
    return (x/y);
}
int suma(int x, int y){
    return(x+y);
}
int resta(int x, int y){
    return(x-y);
}
//
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//using Math;
Console.WriteLine("Dame un numero");
float k=Int32.Parse(Console.ReadLine());
Console.WriteLine("Valor absoluto de el numero : "+ Math.Abs(k));
Console.WriteLine("El cuadrado de el numero : "+ Math.Pow(k,2));
Console.WriteLine("El seno el numero : "+ Math.Sin(k));
Console.WriteLine("El coseno de el numero : "+ Math.Cos(k));
Console.WriteLine("Parte entera : "+ Math.Truncate(k));
Console.WriteLine("El cuadrado de el numero : "+ Math.Pow(k,2));
Console.WriteLine("dame otro numero : ");
int j=Int32.Parse(Console.ReadLine());
Console.WriteLine("El maximo entre los dos numeros : "+ Math.Max(k,j));
Console.WriteLine("El minimo entre los dos numeros : "+ Math.Min(k,j));
