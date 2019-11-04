using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManager {
    class Product {
        public string Code { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Product() {

        }
        public Product(string c, string d, double p) {
            Code = c;
            Description = d;
            Price = p;
        }

        public override string ToString() {
            /*return "code = " + code + ", description = " + description +
                    ", price = " + price.ToString("C2");*/
            return $"{Code}|{Description}|{Price.ToString("C2")}";
        }
    }
}