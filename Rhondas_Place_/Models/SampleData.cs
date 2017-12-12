using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rhondas_Place_.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<RhondasPlaceStoreEntities>
    {
        protected override void Seed(RhondasPlaceStoreEntities context)
        {
            var candlecategories = new List<CandleCategory>

            {
                new CandleCategory { Name = "Jar Candles", Description = "Jar Candles"},
                new CandleCategory { Name = "Cubed Candles", Description = "Cubed Candles"},
                new CandleCategory { Name = "Halloween Candles", Description = "Halloween Candles"},
                new CandleCategory { Name = "Fall Candles", Description = "Fall Candles"},
                new CandleCategory { Name = "Christmas Candles", Description = "Christmas Candles"},
                new CandleCategory { Name = "Shop By Color", Description = "Shop By Color"},
                new CandleCategory { Name = "Festive Candles", Description = "Festive Candles"},
                new CandleCategory { Name = "Large Candles", Description = "Large Candles"},
                new CandleCategory { Name = "Vase Candles", Description = "Vase Candles"},
                new CandleCategory { Name = "Best Selling Candles", Description = "Best Selling Candles"}
            };

            var scents = new List<CandleScent>
            {
                new CandleScent { Name = "Cucumber Melon" },
                new CandleScent { Name = "Vanilla" },
                new CandleScent { Name = "Butter Cream" },
                new CandleScent { Name = "Stawberries & Cream" },
                new CandleScent { Name = "Blueberry" },
                new CandleScent { Name = "Blackberry" }
            };

            new List<Candle>
            {
                new Candle { Title = "8 oz Jelly", CandleCategory = candlecategories.Single(c => c.Name == "Jar Candle"), Price = 8.00M, CandleScent = scents.Single(s => s.Name == "Vanilla"), CandleImgUrl = "/Content/Images/Jar Candle2.png"},
                new Candle {Title = "12 oz Classic", CandleCategory = candlecategories.Single(c => c.Name == "Jar Candle"), Price = 13.00M, CandleScent = scents.Single(s => s.Name == "Cucumber Melon"), CandleImgUrl = "/Content/Images/Jar Candle.jpg"},
                new Candle { Title = "16 oz Classic", CandleCategory = candlecategories.Single(c => c.Name == "Jar Candle"), Price = 16.00M, CandleScent = scents.Single(s => s.Name == "Stawberries & Cream"), CandleImgUrl = "/Content/Images/untitled.png"},
                new Candle { Title = "16 oz Classic With Emblem", CandleCategory = candlecategories.Single(c => c.Name == "Jar Candle"), Price = 18.00M, CandleScent = scents.Single(s => s.Name == "Blueberry"), CandleImgUrl = "/Content/Images/untitled.png "}
 }.ForEach(a => context.Candle.Add(a));
        }
    }
}