using System.Collections.Generic;

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
            UpdadeDecreaseQuality();
            UpdateAgedBrieQuality();
            UpdateSulfurasQuality();
            UpdateBackstageQuality();
            UpdateConjuredQuality();
            UpdateQualityNegative();
        }

        public void UpdadeDecreaseQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" 
                    && Items[i].Name != "Sulfuras, Hand of Ragnaros")
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

        public void UpdateAgedBrieQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == "Aged Brie" && Items[i].SellIn > 0)
                {
                    Items[i].Quality += 1;
                }
                else if (Items[i].Name == "Aged Brie" && Items[i].SellIn <= 0)
                {
                    Items[i].Quality -= 2;
                }
            }
        }

        public void UpdateSulfurasQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
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
            }
        }
        public void UpdateBackstageQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].SellIn > 10)
                    {
                        Items[i].Quality += 1;
                    }
                    else
                    { 
                        if (Items[i].SellIn <= 10 && Items[i].SellIn > 5)
                        {
                            Items[i].Quality += 2;
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
        }

        public void UpdateConjuredQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name.Contains("Conjured Mana Cake"))
                {
                    Items[i].Quality -= 1;
                }
            }
        }
        public void UpdateQualityNegative()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Quality < 0)
                {
                    Items[i].Quality = 0;
                }
            }    
        }  
    }
}
