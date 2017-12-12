using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Rhondas_Place_.Models
{
    [Bind(Exclude = "CandleId")]
    public class Candle
    {
        [ScaffoldColumn(false)]
        public int CandleId { get; set; }
        [DisplayName("Genre")]
        public int CandleCategoryId { get; set; }
        [DisplayName("Candle")]
        public int CandleScentId { get; set; }
        [Required(ErrorMessage = "An Album Title is required")]
        [StringLength(160)]
        public string Title { get; set; }
        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }
        [DisplayName("Candle Img URL")]
        [StringLength(1024)]
        public string CandleImgUrl { get; set; }
        public virtual CandleCategory CandleCategory { get; set; }
        public virtual CandleScent CandleScent { get; set; }
    }
}