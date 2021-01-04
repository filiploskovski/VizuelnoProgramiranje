using System.Collections.Generic;
using System.Linq;

namespace PotrosuvackaKosnicka.Models
{
    public class ProductModel
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public static class Products
    {
        public static List<ProductModel> ProductsList { get; set; } = new List<ProductModel>()
        {
            new ProductModel {Category = "Higiena", Name = "Sampon", Price = 150},
            new ProductModel {Category = "Pijaloci", Name = "Mleko", Price = 50},
            new ProductModel {Category = "Alkoholni Pijaloci", Name = "Pivo", Price = 100},
            new ProductModel {Category = "Higiena", Name = "Pasta za zabi", Price = 70},
            new ProductModel {Category = "Krastavici", Name = "Zelencuk", Price = 45}
        };

        public static List<ProductModel> GetProducts()
        {
            return ProductsList;
        }

        public static List<string> GetProductsForListBox()
        {
            return GetProducts().Select(item => item.Name).ToList();
        }
    }
}