// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//inicio de la prueba de los strings
Console.WriteLine("Dame una cadena a ingresar");
string usuario=Console.ReadLine();
int i=0;
foreach (var item in usuario)
{
    Console.WriteLine("Letra: "+item);
    i++;
}
Console.WriteLine("La longitud de la cadena es: "+i);
Console.WriteLine("Dame otra cadena a buscar");
string Cadena=Console.ReadLine();
string Aux=usuario+Cadena;
Console.WriteLine("La concatenacion de las dos cadenas es: "+Aux);
Console.WriteLine("Sub cadena de la primera cadena ingresada, comienza de desde el 2do caracter: "+ usuario.Substring(2));
