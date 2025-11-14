namespace Esame;

public partial class ProductDetailPage : ContentPage
{
    public ProductDetailPage(Product product)
    {
        InitializeComponent();

        ProductTitle.Text = product.Title;
        ProductPrice.Text = $"Prezzo: {product.Price}€";
        ProductCategory.Text = $"Categoria: {product.Category}";
        ProductDescription.Text = product.Description;
        ProductImage.Source = product.Image;
    }
}