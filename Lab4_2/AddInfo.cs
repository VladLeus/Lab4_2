using System;
using System.IO;
using System.Xml.Serialization;

namespace Lab4_2
{
    class AddInfo
    {
        static void AddToXml(PriceStruct.Price[] info)
        {
            XmlSerializer xmls = new XmlSerializer(typeof(PriceStruct.Price[]));
            using (FileStream stream = new FileStream("info.xml", FileMode.Create))
            {
                    xmls.Serialize(stream, info);
            }
        }
        static void AddToTxt(PriceStruct.Price[] info)
        {
            using (FileStream stream = new FileStream("info.txt", FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(stream))
                {
                    foreach (PriceStruct.Price obj in info)
                    {
                        sw.WriteLine(obj.goodsName + " " + obj.marketName + " " + obj.priceInCoins);
                    }
                }
            }
        }
        static PriceStruct.Price GetFromKeyboard()
        {
            Console.WriteLine();
            Console.WriteLine("Введіть назву товару:");
            string goodsName = Console.ReadLine();
            Console.WriteLine("Введіть назву магазину:");
            string marketName = Console.ReadLine();
            Console.WriteLine("Введіть ціну товару(в копійках):");
            int price = int.Parse(Console.ReadLine());
            return new PriceStruct.Price(goodsName, marketName, price);
        }
        public static void DoPart()
        {
            Console.Clear();
            Console.WriteLine("Введіть кількість товарів, які записуватимуться:");
            int n = int.Parse(Console.ReadLine());
            PriceStruct.Price[] info = new PriceStruct.Price[n];
            for (int i = 0; i < info.Length; i++)
            {
                info[i] = GetFromKeyboard();
            }
            Array.Sort(info);
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Введіть 1 щоб записати данні у txt.");
            Console.WriteLine("Введіть 2 щоб записати данні у xml.");
            Console.WriteLine("Введіть 0 щоб повернутись до головного меню.");
            Console.WriteLine("---------------------------------------------");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    AddToTxt(info);
                    break;
                case 2:
                    AddToXml(info);
                    break;
                case 0:
                    Console.WriteLine("Добре, повертаємось!");
                    break;
                default:
                    Console.WriteLine("такого значення не існує, спробуйте ще раз.");
                    break;
            }
        }
    }
}
