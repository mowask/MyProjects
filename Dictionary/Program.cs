using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Dictionary dictionary;
           // Dictionary englishRussian = new Dictionary("Edictionary.txt");
           // Dictionary russianEnglish = new Dictionary("Rdictionary.txt");

            Console.WriteLine("Выбери словарь: \n1. Англо-Русский \n2. Русско-английский \nДля выхода - нахмите любую клавишу" );

            ConsoleKey key = Console.ReadKey().Key;

            if ( key == ConsoleKey.D1 )
            {
                dictionary = new Dictionary("Edictionary.txt");
                dictionary.LoadDictionary();
            }
            else if ( key == ConsoleKey.D2 )
            {
                dictionary = new Dictionary("Rdictionary.txt");
                dictionary.LoadDictionary();
            } 
            else 
            {
                Console.WriteLine("\nБудь внимательней в следующий раз");
                Console.ReadKey();
                return;
                
            }

            //int choice = Console.ReadKey().KeyChar;
            //while (true)
            //{
            //    Console.WriteLine("\nНеверный выбор. Будь внимательней в следующий раз.");
            //if (choice == 1)
            //    englishRussian.LoadDictionary();
            //else if (choice == 2)
            //    russianEnglish.LoadDictionary();
            //else return;
            //}


            //foreach (string i in russianEnglish._dictionary.Keys)
            //{
            //    Console.WriteLine(i);
            //}                        
            //Console.ReadKey();



            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Найти перевод слова");
                Console.WriteLine("2. Добавить слово и перевод");
                Console.WriteLine("3. Заменить слово или перевод");
                Console.WriteLine("4. Удалить слово");
                Console.WriteLine("5. Экспортировать слово в файл");
                Console.WriteLine("6. Выйти");
                Console.Write("Выберите пункт меню: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        dictionary.FindTranslation();
                       
                        break;
                    case "2":
                        dictionary.AddWord();                       
                        break;
                    case "3":
                        dictionary.ReplaceWordOrTranslation();                        
                        break;
                    case "4":
                        dictionary.DeleteWord();                        
                        break;
                    case "5":
                        dictionary.ExportSelectedWord();                       
                        break;
                    case "6":
                        dictionary.SaveDictionary();                        
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }
}