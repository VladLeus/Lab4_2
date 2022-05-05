using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Lab4_2
{
    class PriceStruct
    {
        public struct Price
        {
            public string goodsName;
            public string marketName;
            public int price;
            [XmlAttribute("goodsname")] public string GoodsName;
            [XmlAttribute("marketname")] public string MarketName;
            [XmlAttribute("price")] public string Prices;


            public Price(string lineWithAllData)
            {
                string[] array = lineWithAllData.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                goodsName = array[0];
                marketName = array[1];
                price = int.Parse(array[2]);
                GoodsName = array[3];
                MarketName = array[4];
                Prices = array[5];

            }
        }
    }
}
