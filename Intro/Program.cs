using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Swap(ref int _first, ref int _second, out string
            _text)
        {
            _text = "Привет!!!";
            int tmp = _first;
            _first = _second;
            _second = tmp;
        }
        static void PrintByOrder(string _name, string _order)
        {
            if (_order == "-")
            {
                for (int i = _name.Length - 1; i >= 0; i--)
                {
                    Console.Write(" {0}", _name[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < _name.Length; i++)
                {
                    Console.Write(" {0}", _name[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            int a = 6, b = 78;
            string text;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Swap(ref a, ref b, out text);
            Console.WriteLine();
            Console.WriteLine("a = {0}, b = {1}", a, b);

            string myName = "КОМПЬЮТЕР";

            try
            {
                Console.WriteLine("Привет, {0}! Я - {1}", args[0], myName);
                for (int i = args[0].Length - 1; i >= 0; i--)
                {
                    Console.Write(" {0}", args[0][i]);
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Как вас зовут?");
                string _input = Console.ReadLine();
                Console.WriteLine("Привет, {0}! Я - {1}", _input, myName);
            }
            finally
            {
                Console.WriteLine("Это будет выведено в любом случае...");

            }
        }
    }
}
