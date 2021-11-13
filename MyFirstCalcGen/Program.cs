using System;
using System.IO;
using System.Threading.Tasks;

namespace MyFirstCalcGen
{
    class Program
    {
        static void Main(string[] args)
        {
            char b = '"';
            
            string path = @"C:\Users\USER\Downloads\MyFirstCalc.txt";
            using (StreamWriter sw = File.CreateText(path))
            Console.WriteLine("Till How Much?");
            int amount = int.Parse(Console.ReadLine()) + 1;
            Console.Clear();
            var some = new StringWriter();
            Console.SetOut(some);
            Console.SetError(some);
            Console.WriteLine($"Console.WriteLine({b}Welcome to this calculator!{b});");
            Console.WriteLine($"Console.WriteLine({b}It can add, subtract, multiply and divide whole numbers from 0 to {amount - 1}{b});");
            Console.WriteLine($"Console.WriteLine({b}Please choose your first number: {b});");
            Console.WriteLine("int num1 = int.Parse(Console.ReadLine());");
            Console.WriteLine($"Console.WriteLine({b}Please choose your second number: {b});");
            Console.WriteLine("int num2 = int.Parse(Console.ReadLine());");
            for (int i = 0; i < amount; i++)
            {
                for(int j = 0; j < amount; j++)
                {
                    Console.WriteLine($"if(num1 == {i} and sign == '+' and num2 == {j})");
                    Console.WriteLine($"    Console.WriteLine({b}{i} + {j} == {i + j}{b});");
;               }
            }
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    Console.WriteLine($"if(num1 == {i} and sign == '-' and num2 == {j})");
                    Console.WriteLine($"    Console.WriteLine({b}{i} - {j} == {i - j}{b});");
                    ;
                }
            }
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    Console.WriteLine($"if(num1 == {i} and sign == '*' and num2 == {j})");
                    Console.WriteLine($"    Console.WriteLine({b}{i} * {j} == {i * j}{b});");
                    ;
                }
            }
            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    int test = 0;
                    try
                    {
                        test = i / j;
                        Console.WriteLine($"if(num1 == {i} and sign == '/' and num2 == {j})");
                        Console.WriteLine($"    Console.WriteLine({b}{i} / {j} == {(decimal)(i / j)}{b});");

                    }
                    catch
                    {
                        Console.WriteLine($"if(num1 == {i} and sign == '/' and num2 == {j})");
                        Console.WriteLine($"    Console.WriteLine({b}{i} / {j} == inf{b});");
                    }
                    
                }
            }
            string megastring = some.ToString();
            File.WriteAllText(path, megastring);
            Console.Clear();

        }
    }
}
