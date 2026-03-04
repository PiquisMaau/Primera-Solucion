// See https://aka.ms/new-console-template for more information
Console.WriteLine("Imprimir numeros del 1 al 20");
int limiteSuperior = 20;
for (int i = 1; i <= limiteSuperior; i++)
{
    Console.WriteLine("Valor: {0}", i);
}    
Console.WriteLine("----------------------------------------------");
for (int i = limiteSuperior; i > 0 ; i-=3)
{
    Console.WriteLine("Valor: {0}", i);
}

//Pares - Impares - Divisibles pa 3

Console.WriteLine("---------------------Impares-------------------------");
for (int i = limiteSuperior; i > 0; i --)
{
    if (i%2 != 0)
    {
        Console.WriteLine("Valor: {0}", i);
    }
}
Console.WriteLine("----------------------Pares------------------------");
for (int i = limiteSuperior; i > 0; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Valor: {0}", i);
    }
}
Console.WriteLine("----------------------Multiplos de 3------------------------");
for (int i = limiteSuperior; i > 0; i--)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Valor: {0}", i);
    }
}

Console.Read();
