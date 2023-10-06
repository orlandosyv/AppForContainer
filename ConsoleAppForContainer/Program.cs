// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World! Start our Counter ....");
int Numero = 0;
Console.WriteLine("Would you want to start on a specific number?");
String Answer = Console.ReadLine();
if (Answer != null) 
{
    if (Answer.ToLower() == "yes") {
        Console.WriteLine("Write starting number lower than 50");
        String StartingNumberStr = Console.ReadLine();
        Numero = Convert.ToInt32(StartingNumberStr);        
    }
    else { Console.WriteLine("The Counter Start now!"); }
    ;
}

while (Numero < 50) {
    Numero++;
    Console.WriteLine(Numero);
}
Console.WriteLine("The Counter has finished");
