using System.Collections.ObjectModel;
using System.Text.Json;

namespace Esame  
{
    public static class CartService   
    {
        private static readonly string filePath =
            Path.Combine(FileSystem.AppDataDirectory, "cart.json");

        public static ObservableCollection<Product> Cart { get; private set; }
            = new ObservableCollection<Product>();

        static CartService()
        {
            LoadCart();
        }

        public static void AddToCart(Product product)
        {
            Cart.Add(product);
            SaveCart();
        }

        public static void SaveCart()
        {
            var json = JsonSerializer.Serialize(Cart);
            File.WriteAllText(filePath, json);
        }

        public static void LoadCart()
        {
            if (!File.Exists(filePath))
                return;

            var json = File.ReadAllText(filePath);
            var loaded = JsonSerializer.Deserialize<ObservableCollection<Product>>(json);

            if (loaded != null)
            {
                Cart.Clear();
                foreach (var p in loaded)
                    Cart.Add(p);
            }
        }
    }
}
