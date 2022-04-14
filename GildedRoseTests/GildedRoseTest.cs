using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        public void foo()
        {
            IList<Item> Items = new List<Item> 
            { 
                new Item { Name = "foo", SellIn = 0, Quality = 0 } 
            };
            
            GildedRose app = new GildedRose(Items);
            app.UpdadeDecreaseQuality();
            app.UpdateAgedBrieQuality();
            app.UpdateSulfurasQuality();
            app.UpdateBackstageQuality();
            app.UpdateConjuredQuality();
            app.UpdateQualityNegative();  
        }
    }
}
