using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        public static string Input;
        private static int length = 0;
        private static int width = 0;
        private static int integerInput = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("Length");
            readUserInput();
            ValidateIfInputIsInteger();
            ValidateIfInputIsPositive();
            length = integerInput;

            Console.WriteLine("Width");
            readUserInput();
            ValidateIfInputIsInteger();
            ValidateIfInputIsPositive();
            width = integerInput;

            Rectangle rectangle = new Rectangle(length, width);

            while (true)
            {
                ShowMenu();
                readUserInput();
                ValidateIfInputIsInteger();
                ValidateIfInputIsPositive();
                ValidateIfOperationNumberIsValid();
                ExecuteCommand(rectangle);
                Console.WriteLine("******************");
            }
        }

        private static void ExecuteCommand(Rectangle rectangle)
        {
            switch (integerInput)
            {
                case 1:
                    Console.WriteLine(rectangle.GetLength());
                    break;

                case 2:
                    Console.WriteLine("New length");
                    readUserInput();
                    ValidateIfInputIsInteger();
                    ValidateIfInputIsPositive();
                    Console.WriteLine(rectangle.SetLength(integerInput));
                    break;

                case 3:
                    Console.WriteLine(rectangle.GetWidth());
                    break;

                case 4:
                    Console.WriteLine("New width");
                    readUserInput();
                    ValidateIfInputIsInteger();
                    ValidateIfInputIsPositive();
                    Console.WriteLine(rectangle.SetWidth(integerInput));
                    break;

                case 5:
                    Console.WriteLine(rectangle.GetPerimeter());
                    break;

                case 6:
                    Console.WriteLine(rectangle.GetArea());
                    break;

                case 7:
                    Environment.Exit(0);
                    break;

                default:
                    ShowMenu();
                    break;
            }
        }

        //Method  call inside a method. Fix if there is time.
        private static void ValidateIfOperationNumberIsValid()
        {
            while (integerInput > 7 && integerInput > 0)
            {
                ShowMenu();
                readUserInput();
                ValidateIfInputIsPositive();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("1. Get Rectangle Length");
            Console.WriteLine("2. Change Rectangle Length");
            Console.WriteLine("3. Get Rectangle Width");
            Console.WriteLine("4. Change Rectangle Width");
            Console.WriteLine("5. Get Rectangle Perimeter");
            Console.WriteLine("6. Get Rectangle Area");
            Console.WriteLine("7. Exit");
        }

        private static void ValidateIfInputIsPositive()
        {
            while (integerInput <= 0)
            {
                Console.WriteLine("Positive bruh!");
                readUserInput();
                ValidateIfInputIsInteger();
            }
        }

        private static void ValidateIfInputIsInteger()
        {
            while (!int.TryParse(Input, out integerInput))
            {
                Console.WriteLine("The hell are you entering bruh?");
                readUserInput();
            }
        }

        private static void readUserInput()
        {
            Input = Console.ReadLine();
        }
    }
}