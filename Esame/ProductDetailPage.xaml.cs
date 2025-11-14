namespace Esame
{
    public partial class ProductDetailPage : ContentPage
    {
        private Product _product; 

        public ProductDetailPage(Product product)
        {
            InitializeComponent();
            _product = product;  

            ProductTitle.Text = product.Title;
            ProductPrice.Text = $"Prezzo: {product.Price}€";
            ProductCategory.Text = $"Categoria: {product.Category}";
            ProductDescription.Text = product.Description;
            ProductImage.Source = product.Image;
        }

        private void AddToCart_Clicked(object sender, EventArgs e)
        {
            CartService.AddToCart(_product); 
            DisplayAlert("Successo", "Prodotto aggiunto al carrello!", "OK");
        }
    }
}
