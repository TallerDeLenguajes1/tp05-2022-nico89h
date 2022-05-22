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
//buscar una letra en la palabra ingresada
Console.WriteLine("Aparece la letra a en su cadena ingresada?");
string A="a";
if (A.Contains(usuario))
{
    Console.WriteLine("La letra a si aparece en la primera cadena ingresada");
}else
{
    
    Console.WriteLine("La letra a no aparece en la primera cadena ingresada");
}
Console.WriteLine("La primera cadena convertida en masyusculas"+usuario.ToUpper());
Console.WriteLine("La primera cadena convertida en minusculas"+usuario.ToLower());
Console.WriteLine("Comparando la primera cadena y la segunda ingresada");
if (usuario.Equals(Cadena))
{
    Console.WriteLine("Las dos cadenas son iguales");
}else
{
    Console.WriteLine("Las dos cadenas no son iguales");
}
Console.WriteLine("Ingresa dos numeros");
Console.WriteLine("Ingresa el primer numero");
string x=Console.ReadLine();
Console.WriteLine("Ingresa el segundo numero");
string y=Console.ReadLine();
int total=Int32.Parse(x)+Int32.Parse(y);
Console.WriteLine("La suma es: "+total);