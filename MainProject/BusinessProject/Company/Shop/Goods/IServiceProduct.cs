using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Shop.Goods
{
    interface IServiceProduct
    {
        decimal Percent { get; set; }
        void AddProduct(Product product);

        Product GetTheSameProduct(Product product);

        decimal AllProductsCosts();

        List<Product> GetAllProducts();
    }
}
