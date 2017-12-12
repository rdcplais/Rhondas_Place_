using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rhondas_Place_.Models
{
    public class CandleCategory
    {
        public int CandleCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Candle> Candles { get; set; }
    }
}