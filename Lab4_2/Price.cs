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
    public class PriceStruct
    {
        public struct Price : IComparable<Price>
        {
            public string goodsName;
            public string marketName;
            public int priceInCoins;
 
            public Price(string goods, string market, int pr1ce)
            {
                goodsName = goods;
                marketName = market;
                priceInCoins = pr1ce;
            }

            public override string ToString()
            {
                string info = $"Вся інформація: {this.goodsName} {this.marketName} {this.priceInCoins}";
                return info;
            }

            public int CompareTo(Price other)
            {
                return String.Compare(this.goodsName, other.goodsName);
            }
        }
    }
}
