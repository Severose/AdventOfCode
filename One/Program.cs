using System.Collections.Generic;
using System;
using System.IO;

namespace csharp
{
    public class One
    {
        static void Main()
        {
            string[] input = File.ReadAllLines("..\\..\\..\\Input.txt");
            int sum = 0;

            for(int i = 0; i < input.Length; i++)
            {
                sum += getRequiredFuel(int.Parse(input[i]));
            }

            Console.WriteLine("{0} fuel required.", sum);
        }

        public static int getRequiredFuel(int mass)
        {
            int result = 0;

            result = (mass/3) - 2;
            
            return result;
        }

        /*private const string AGED_BRIE = "Aged Brie";
        private const string BACKSTAGE_PASSES = "Backstage passes to a TAFKAL80ETC concert";
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        private const string CONJURED = "Conjured";
        public IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public bool isRegularItem(Item item)
        {
            return (item.Name != AGED_BRIE &&
                   item.Name != BACKSTAGE_PASSES &&
                   item.Quality > 0 &&
                   item.Name != SULFURAS &&
                   item.Name != CONJURED);
        }

        public void updateBackstagePassQuality(Item item)
        {
            if (item.SellIn < 11)
            {
                item.Quality += 1;
            }
            if (item.SellIn < 6)
            {
                item.Quality += 1;
            }
        }

            public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                Item item = Items[i];
                if (isRegularItem(item))
                {
                    item.Quality -= 1;
                }
                else if (isConjuredItem(item))
                {
                    updateConjuredQuality(item);
                }
                else if (item.Quality < 50)
                {
                    item.Quality += 1;

                    if (item.Name == BACKSTAGE_PASSES)
                    {
                        updateBackstagePassQuality(item);
                    }

                }

                DecreaseSellIn(item);

                if (item.SellIn < 0)
                {
                    if (item.Name == AGED_BRIE)
                    {
                        updateAgedBrieQuality(item);

                    }
                    else if (isRegularItem(item))
                    {
                        item.Quality -= 1;
                    }
                    else
                    {
                        item.Quality = 0;
                    }
                }
            }
        }

        private static void DecreaseSellIn(Item item)
        {
            if (item.Name != SULFURAS)
            {
                item.SellIn -= 1;
            }
        }

        private static void updateAgedBrieQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }

        private static void updateConjuredQuality(Item item)
        {
            if (item.Quality < 2)
            {
                item.Quality = 0;
            }
            else
            {
                item.Quality -= 2;
            }
        }

        private static bool isConjuredItem(Item item)
        {
            return item.Name == CONJURED;
        }*/
    }
}
