/*Расширьте пример 5 (русско-английский словарь) еще и украинским словарем. 
 Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках. 
 */
using System;

namespace Addition_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Строка ниже задает кодировку консоли
            Console.OutputEncoding = System.Text.Encoding.Default;

            Dictionary dictionary = new Dictionary("яблоко", "стол", "солнце", "apple", "table", "sun", "яблуко", "стiл", "сонце");

            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["sun"]);
            Console.WriteLine(dictionary["стiл"]);
            Console.WriteLine(dictionary["олівець"]);
            Console.WriteLine(dictionary["яблуко"]);

            Console.WriteLine("\n" + new string('-', 30)+"\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}
