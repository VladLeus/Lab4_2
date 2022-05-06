using System;
using System.IO;
using System.Xml.Serialization;

namespace Lab4_2
{
    class GetInfo
    {
        public static PriceStruct.Price[] ReadDataXml()
        {
            XmlSerializer xmls = new XmlSerializer(typeof(PriceStruct.Price[]));
            using (StreamReader stream = new StreamReader("info.xml"))
            {
                return (PriceStruct.Price[]) xmls.Deserialize(stream);
            }
        }
        static PriceStruct.Price Separate(string lineWithData)
        {
            string[] array = lineWithData.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string goodsname = array[0];
            string marketname = array[1];
            int price = int.Parse(array[2]);
            return new PriceStruct.Price(array[0], array[1], price);
        }
        public static PriceStruct.Price[] ReadDataTxt(string inf)
        {
            int count = System.IO.File.ReadAllLines(inf).Length;
            PriceStruct.Price[] info = new PriceStruct.Price[count];
            using (StreamReader read = new StreamReader(inf))
            {
                for (int i = 0; i < count; i++)
                {
                    info[i] = Separate(read.ReadLine());
                }
            }
            return info;
        }
        public static void DoPart()
        {
            Console.Clear();
            PriceStruct.Price[] info;
            string inf = "info.txt";
            PriceStruct.Price[] infoXml;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Введіть 1 щоб зчитати інформацію з txt файлу.");
            Console.WriteLine("Введіть 2 щоб зчитати інформацію з xml файлу.");
            Console.WriteLine("Введіть 0 щоб повернутись до головного меню.");
            Console.WriteLine("----------------------------------------------");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    info = ReadDataTxt("info.txt");
                    foreach (PriceStruct.Price obj in info)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                    Console.WriteLine("Натисніть Enter щоб повернутися до головного меню.");
                    Console.ReadKey();
                    break;
                case 2:
                    infoXml = ReadDataXml();
                    foreach (PriceStruct.Price obj in infoXml)
                    {
                        Console.WriteLine(obj.ToString());
                    }
                    Console.WriteLine("Натисніть Enter щоб повернутися до головного меню.");
                    Console.ReadKey();
                    break;
                case 0:
                    Console.WriteLine("Добре, повертаємось!");
                    break;
                default:
                    Console.WriteLine("Такого значення не існує, спробуйте ще раз.");
                    break;
            }
        }
    }
}
