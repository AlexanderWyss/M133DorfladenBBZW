using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M133DorfladenBBZW
{
    public class Product
    {
        public int id { get; }
        public String productName { get; }
        public double specialOffer { get; }
        public double normalPrice { get; }
        public String imageName { get; }
        public String description { get; }

        public Product(int id, string productName, double specialOffer, double normalPrice, string imageName, string description)
        {
            this.id = id;
            this.productName = productName;
            this.specialOffer = specialOffer;
            this.normalPrice = normalPrice;
            this.imageName = imageName;
            this.description = description;
        }

        public override string ToString()
        {
            return productName;
        }
    }
}