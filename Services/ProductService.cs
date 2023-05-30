using AppMvc.Net.Models;

namespace AppMvc.Net.Services {
    public class ProductService : List<Product> {
        public ProductService() {
            this.AddRange(new Product[] {
                new Product() {Id = 1, Name = "Iphone X", Price= 2000000},
                new Product() {Id = 2, Name = "SangSung X", Price= 220000},
                new Product() {Id = 3, Name = "Nokia X", Price= 10000},
                new Product() {Id = 4, Name = "Huaway", Price= 3000},
                new Product() {Id = 5, Name = "Intel", Price= 5000},
            });
        }
    }
}