using ApiPROJECTS.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPROJECTS.Data
{

   
    public class StoreContent : DbContext
    {
        public StoreContent(DbContextOptions<StoreContent> options) : base(options) 
        {
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
    

