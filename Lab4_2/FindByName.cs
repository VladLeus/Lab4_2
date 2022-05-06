using System;

namespace Lab4_2
{
    class FindByName
    {
        public static void DoPart()
        {
            Console.Clear();
            PriceStruct.Price[] information;
            Console.WriteLine("Введіть назву товару, що шукаєте:");
            string str = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Введіть 1, щоб перевірити наявність в txt.");
            Console.WriteLine("Введіть 2,щоб перевірити наявність в xml.");
            Console.WriteLine("Введіть 0 щоб повернутись до головного меню.");
            Console.WriteLine("----------------------------------------------");
            int ch = int.Parse(Console.ReadLine());
            bool exsist = false;
            switch (ch)
            {
                case 1:
                    information = GetInfo.ReadDataTxt("info.txt");
                    foreach (PriceStruct.Price obj in information)
                    {
                        if (obj.goodsName == str)
                        {
                            exsist = true;
                            Console.WriteLine(obj.ToString());
                        }
                    }
                    if (exsist == false)
                    {
                        Console.WriteLine("Такого товару не існує.");
                    }
                    Console.WriteLine("Натисніть Enter щоб повернутися до головного меню.");
                    Console.ReadKey();
                    break;
                case 2:
                    information = GetInfo.ReadDataXml();
                    foreach (PriceStruct.Price obj in information)
                    {
                        if (obj.goodsName == str)
                        {
                            exsist = true;
                            Console.WriteLine(obj.ToString());
                        }
                    }
                    if (exsist == false)
                    {
                        Console.WriteLine("Такого товару не існує.");
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
