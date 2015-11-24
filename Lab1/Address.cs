using System;

namespace Lab1
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }
        public int PostCode { get; set; }

        public Address()
        {
            Country = "N/A";
            City = "N/A";
            Street = "N/A";
            House = 0;
            Apartment = 0;
            PostCode = 0;
        }

        public void Print()
        {
            Console.WriteLine(Country + "\n" +
                              City + "\n" +
                              Street + "\n" +
                              House + "\n" +
                              Apartment + "\n" +
                              PostCode);
        }

        public int DisplayMenu()
        {
            Console.WriteLine("==========================\n" +
                              "1. Ввести адрес полностью.\n" +
                              "2. Вывести адрес.\n" +
                              "3. Ввести страну.\n" +
                              "4. Ввести город.\n" +
                              "5. Ввести улицу.\n" +
                              "6. Ввести номер дома.\n" +
                              "7. Ввести номер квартиры.\n" +
                              "8. Ввести почтовый индекс.\n" +
                              "9. Выход.\n" +
                              "==========================\n");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }

    }

    internal class TestAddress
    {
        private static void Main()
        {
            Console.Title = "Лабораторная работа №1";
            var address = new Address();
            int userInput;

            do
            {
                userInput = address.DisplayMenu();

                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        address.Country = Console.ReadLine();
                        address.City = Console.ReadLine();
                        address.Street = Console.ReadLine();
                        address.House = Convert.ToInt32(Console.ReadLine());
                        address.Apartment = Convert.ToInt32(Console.ReadLine());
                        address.PostCode = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.Clear();
                        address.Print();
                        break;
                    case 3:
                        Console.Clear();
                        address.Country = Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        address.City = Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        address.Street = Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        address.House = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.Clear();
                        address.Apartment = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.Clear();
                        address.PostCode = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR: unexpected number!");
                        break;
                }
            } while (userInput != 9);
        }
    }
}
