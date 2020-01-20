using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Shop.Goods
{
    interface IServiceProduct
    {
        void AddProduct(Product product);

        Product GetSameProduct(Product product);

        void ChangeProductCount(Product product);

        decimal costAllProducts(List<Product> list);

        List<Product> getProducts();
    }
}
