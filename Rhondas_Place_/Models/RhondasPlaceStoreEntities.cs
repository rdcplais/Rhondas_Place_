using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rhondas_Place_.Models
{
    public class RhondasPlaceStoreEntities : DbContext
    {
        public DbSet<Candle> Candle { get; set; }
        public DbSet<CandleCategory> CandleCategory { get; set; }
        public DbSet<CandleScent> CandleScent { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<Rhondas_Place_.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}