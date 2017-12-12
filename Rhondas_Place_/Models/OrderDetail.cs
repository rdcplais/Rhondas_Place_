using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rhondas_Place_.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int CandleId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Candle Candle { get; set; }
        public virtual Order Order { get; set; }
    }
}