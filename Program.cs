// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//inicio de el punto de calculadora
bool valor=true; // valor booleano
int x,y;
int control;
int operaciones;
int total;
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