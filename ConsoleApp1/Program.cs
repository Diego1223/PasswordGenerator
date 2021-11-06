//Password generator
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        //It has 76 characters
        static char[] characters = new char[76] {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z',

            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',

            '!', '@', '#', '$', '%', '^', '&', '*', '(',
            ')', '-', '_', '=', '+',

            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
        };

        static void Main(String[] args)
        {
            byte length;

            CentrarTexto("Password Generator", 2);

            System.Console.SetCursorPosition(0, 5);
            Console.Write("How many characters will have your new password => ");
            length = Convert.ToByte(Console.ReadLine());

            GeneratePassword(length);

            Console.ReadKey();
        }

        static void GeneratePassword(byte length)
        {
            char[] password = new char[length];

            int random;
            Random num = new Random();

            for (int i = 0; i < length; i++)
            {
                random = num.Next(0, 76);
                password[i] = characters[random];
            }

            LoadScreen();

            Console.WriteLine("We already have your new password! \n");

            for(int i = 0; i < password.Length; i++)
            {
                Console.Write(password[i]);
            }
        }
        static void CentrarTexto(string texto, int y)
        {
            float size;
            size = texto.Length;

            System.Console.SetCursorPosition((int)(59.5 - (size / 2)), y);
            Console.Write(texto);
        }

        static void LoadScreen()
        {
            byte counter = 0;

            while (counter < 2)
            {
                Console.WriteLine("Please wait .  /");
                Thread.Sleep(500);
                System.Console.Clear();

                Console.WriteLine("Please wait .. |");
                Thread.Sleep(500);
                System.Console.Clear();

                Console.WriteLine("Please wait ...\\");
                Thread.Sleep(500);
                System.Console.Clear();

                counter++;
            }

        }
    }
}