using App.Xamarin.Cats.Model.Entities;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Xamarin.Clientes.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CatsDetailsPage : ContentPage
	{
        public CatsDetailsPage(Cat cat)
        {
            InitializeComponent();
            BindingContext = cat;
        }
    }
}
