using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace M133DorfladenBBZW
{
    public class CSVReader
    {

        public List<Product> ReadProducts()
        {
            var fileName = "products.csv";
            var appDir = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            var path = Path.Combine(appDir, fileName);
            return File.ReadAllLines(path).Skip(1).Select(line => line.Split(';')).Select(ParseProduct).ToList();
        }

        private Product ParseProduct(string[] values)
        {
            int id = Int32.Parse(values[0]);
            double specialOffer = double.Parse(values[2]);
            double normalPrice = double.Parse(values[3]);
            return new Product(id, values[1], specialOffer, normalPrice, values[4], values[5]);
        }
    }
}