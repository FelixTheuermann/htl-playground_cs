namespace FirstProgram;
using System;
class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int number2 = 0;

        number = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());
        
        if(number == number2) {
            Console.WriteLine($"You are right");
        } else if(number < number2) {
            Console.WriteLine($"Your number is to high");
        } else {
            Console.WriteLine($"Your number is to low");
        }
    }
}