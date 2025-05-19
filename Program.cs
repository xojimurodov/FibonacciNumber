using System.Net.Sockets;
using System.Numerics;

Console.Write("Enter the number: ");
while(true)
{
    var input = Console.ReadLine()!.ToLower();

    if(BigInteger.TryParse(input, out BigInteger number) && number >= 0)
    {
        _ = FibonachiMethod(number);
    }
    else if(int.TryParse(input, out int number2) && number2 < 0)
        Console.WriteLine("Error");
    else
        return;
}

static async Task FibonachiMethod(BigInteger number)
{

    BigInteger a = 0;
    BigInteger b = 1;

    await Task.Yield();
    
    for(BigInteger i = 1; i < number; i++)
    {
        if(a == 0)
            a++;
        else
        {
            BigInteger temp = a;
            a = b;
            b = temp + b;
        }
    }

    Console.WriteLine("Result: " + a);
    Console.Write("Enter the number: ");
}