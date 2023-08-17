using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadzaj znaki, aż wciśniesz 'q'.");

        char stopChar = 'q';
        char inputChar;
        string napis="";

        do
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            inputChar = keyInfo.KeyChar;
            if (inputChar != stopChar)
            {
                napis += inputChar;
            }
        } while (inputChar != stopChar);

        Console.WriteLine('\n'+napis);
    }
}
