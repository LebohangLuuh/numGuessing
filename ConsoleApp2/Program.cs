using System;
using static System.Console;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            WriteLine("Gueess a number between 1 and 9");

            num =Convert.ToInt32(ReadLine());


            Random randNum = new Random();
            
            int rNum = randNum.Next(1, 10);

            if(num == rNum)
            {
                WriteLine("well done. Your guess is correct!");
            }
            if (num < rNum)
            {
                WriteLine("Your guess is low!");
            }

            if (num > rNum)
            {
                WriteLine("Your guess is to high!");
            }
            ReadKey();
        }
    }
}
