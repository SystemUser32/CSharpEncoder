using System;
using static System.Console;
using static System.Convert;

namespace Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
             
            WriteLine("Select an option:\n");
            Menu();
            int option = ToInt32(ReadLine());


            Write("Message: ");
            string message = ReadLine();


            MessageEncoder msg = new MessageEncoder(option, message);
            WriteLine(msg.Perform());


        }

        static void Menu() {

            WriteLine("[1] ASCII");
            WriteLine("[2] UTF-7");
            WriteLine("[3] UTF-8");
            WriteLine("[4] Unicode");
            WriteLine("[5] UTF-32");
            WriteLine("[Blank input will be default]");

        }
    }
}
