using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int choice;
            do
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("Введіть 1 для вводу інформації та її збереження в текстовий та xml файли.");
                Console.WriteLine("Введіть 2 для ввиводу інформації з текстового або xml файлу.");
                Console.WriteLine("Введіть 3 для виводу інформації за іменем товару.");
                Console.WriteLine("Введіть 0 щоб завершити роботу програми.");
                Console.WriteLine("---------------------------------------------------------------------------");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddInfo.DoPart();
                        break;
                    case 2:
                        GetInfo.DoPart();
                        break;
                    case 3:
                        FindByName.DoPart();
                        break;
                    case 0:
                        Console.WriteLine("Добре, завершую!");
                        break;
                    default:
                        Console.WriteLine("такого значення не існує, спробуйте ще раз.");
                        break;
                }
                
            } while (choice != 0);
        }
    }
}
