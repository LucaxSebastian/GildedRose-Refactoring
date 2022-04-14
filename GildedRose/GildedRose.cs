﻿using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality <= 50)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            if (Items[i].SellIn > 0)
                            {
                                Items[i].Quality -= 1;
                            }
                            else
                            {
                                Items[i].Quality -= 2;
                            }
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality <= 50)
                    {
                        if (Items[i].SellIn > 0 && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        { 
                            Items[i].Quality += 1;
                        }
                        else if (Items[i].SellIn <= 0 && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            Items[i].Quality -= 2;
                        }
                    }
                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (Items[i].SellIn <= 10 && Items[i].SellIn > 5)
                        {
                            Items[i].Quality += 2;
                        }
                        else
                        { 
                            if (Items[i].SellIn > 10)
                            {
                                Items[i].Quality += 1;
                            }
                            if (Items[i].SellIn <= 5 && Items[i].SellIn > 0)
                            {
                                Items[i].Quality += 3;
                            }
                            if (Items[i].SellIn <= 0)
                            {
                                Items[i].Quality = 0;
                            }
                        }
                    }
                }
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn -= 1;
                }
                if (Items[i].Quality > 50 && Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].Quality = 80;
                }
                else
                {
                    if (Items[i].Quality > 50)
                    {
                        Items[i].Quality = 50;
                    }
                }
                if (Items[i].Name.Contains("Conjured Mana Cake"))
                {
                    Items[i].Quality -= 1;
                }
                if (Items[i].Quality < 0)
                {
                    Items[i].Quality = 0;
                }
            }
        }
    }
}
