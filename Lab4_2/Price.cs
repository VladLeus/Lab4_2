using System;

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
                string info = $"{this.goodsName} {this.marketName} {this.priceInCoins/100} грн. {this.priceInCoins % 100} коп.";
                return info;
            }

            public int CompareTo(Price other)
            {
                return String.Compare(this.goodsName, other.goodsName);
            }
        }
    }
}
