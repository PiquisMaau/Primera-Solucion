// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    Console.Write(i);
}
String t = "Hola Mundo";
Console.WriteLine( );
t.ToArray();
for (int i = 0; i < 10; i++)
{
   
    //Console.WriteLine(i +". "+ t);
    foreach (Char tesito in t){
    Console.Write(tesito + " - ");
}
    Console.WriteLine();
    
}
