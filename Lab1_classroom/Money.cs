using System;
using System.Collections.Generic;

namespace Lab1_class
{
    class Money
    {
        public double Ruble1 { get; set; }
        public double Ruble2 { get; set; }

        private readonly Dictionary<string, Func<double, double, double>> _operations;

        public Money()
        {
            Ruble1 = 0;
            Ruble2 = 0;

            _operations = new Dictionary<string, Func<double, double, double>>()
            {
                { "+", (x, y) => x + y },
                { "-", (x, y) => x - y },
                { "/", (x, y) => x / y },
                { "*", (x, y) => x * y }
            };
        }

        public double PerformOperation(string op, double money1, double money2)
        {
            if (!_operations.ContainsKey(op))
                throw new ArgumentException($"Operation {op} is invalid", nameof(op));
            return _operations[op](money1, money2);
        }

        public string DisplayMenu()
        {
            Console.WriteLine("1. Ввести числа.");
            Console.WriteLine("2. Ввести операцию.");
            Console.WriteLine("3. Выход.");

            var cki = Console.ReadKey(false);
            return cki.KeyChar.ToString();
        }
    }

    class TestMoney
    {
        private static void Main()
        {
            var money = new Money();
            string userInput;

            do
            {
                userInput = money.DisplayMenu();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        money.Ruble1 = Convert.ToDouble(Console.ReadLine());
                        money.Ruble2 = Convert.ToDouble(Console.ReadLine());
                        break;
                    case "2":
                        Console.Clear();
                        try
                        {
                            var op = Console.ReadLine();
                            Console.WriteLine(money.PerformOperation(op, money.Ruble1, money.Ruble2));
                        }
                        catch (ArgumentException exception)
                        {
                            Console.WriteLine("{0} Exception caught.", exception.Message);
                            Console.WriteLine("Try to input operation again.");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("ERROR: unknown operation!");
                        break;
                }
            } while (userInput != "3");
        }
    }
}