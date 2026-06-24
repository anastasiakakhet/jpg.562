using System;

namespace homewrokk8 {
    class Product {
        public int id;
        public string name;
        public double price;
        public bool nuts;
        public string image;
        public bool vegeterian;
        public int spiciness;
        public string category;

        public Product(int id, string name, double price, bool nuts, string image, bool vegeterian, int spiciness, string category) {
            this.id = id;
            this.name = name;
            this.price = price;
            this.nuts = nuts;
            this.image = image;
            this.vegeterian = vegeterian;
            this.spiciness = spiciness;
            this.category = category;
        }
        public string GetName() {
            return name;
        }
        public double GetPrice() {
            return price;
        }
        public string GetCategory() {
            return category;
        }
        public void SetName(string newName) {
            name = newName;
        }
        public void SetPrice(double newPrice) {
            price = newPrice;
        }
        public void SetCategory(string newCategory) {
            category = newCategory;
        }
        public string ShowInfo() {
            return name + " " + price + " " + category;
        }
    }

    internal class Program {
        public static void Main(string[] args) {
            Product product1 = new Product(1, "Pizza", 20, false, "pizza.jpg", true, 3, "Food");
            Console.WriteLine(product1.GetName());
            Console.WriteLine(product1.GetPrice());
            Console.WriteLine(product1.GetCategory());
            product1.SetName("Burger");
            product1.SetPrice(25);
            product1.SetCategory("Fast Food");
            Console.WriteLine(product1.ShowInfo());
        }
    }
}