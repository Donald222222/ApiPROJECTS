using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPROJECTS.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string PictureUrl { get; set; }
        public ProdcutType ProdcutType { get; set; }
        public int ProdcutTypeId { get; set; }
        public Prodcutbrand Prodcutbrand { get; set; }
        public int ProdcutBrandId { get; set; }


    }
}
