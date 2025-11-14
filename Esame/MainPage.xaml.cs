namespace Esame;

public partial class MainPage : ContentPage
{
    private readonly RestService _restService = new RestService();

    public MainPage()
    {
        InitializeComponent();
        LoadProducts();
    }

    private async void LoadProducts()
    {
        var products = await _restService.GetProductsAsync();
        ProductsCollection.ItemsSource = products;
    }

    private async void ProductsCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Product p)
        {
            await Navigation.PushAsync(new ProductDetailPage(p));
            ProductsCollection.SelectedItem = null;
        }
    }
}
