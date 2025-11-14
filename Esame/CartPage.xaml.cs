using Esame; 

namespace Esame
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            BindingContext = CartService.Cart;
        }
    }
}
