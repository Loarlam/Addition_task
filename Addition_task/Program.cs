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
            //Строка ниже для возможности отображения украинских символов в консольке
            Console.OutputEncoding = System.Text.Encoding.Default;

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["солнце"]);
            Console.WriteLine(dictionary["хата"]);
            Console.WriteLine(dictionary["стiл"]);
            Console.WriteLine(dictionary["олівець"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["сонце"]);
            Console.WriteLine("book");
            Console.WriteLine("pen");
            Console.WriteLine("sun");
            Console.WriteLine("apple");
            Console.WriteLine("table");

            Console.WriteLine(new string('-', 30));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
