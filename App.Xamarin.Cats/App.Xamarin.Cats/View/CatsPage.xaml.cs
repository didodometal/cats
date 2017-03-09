using App.Xamarin.Cats.Model.Entities;
using App.Xamarin.Clientes.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Xamarin.Clientes.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CatsPage : ContentPage
	{
		public CatsPage ()
		{
			InitializeComponent ();
            BindingContext = new CatsViewModel();
            ListViewCats.ItemSelected += CatSelected;
        }

        void CatSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Cat cat = (Cat)e.SelectedItem;
            if (cat == null) return;
            Navigation.PushAsync(new CatsDetailsPage(cat));
            ListViewCats.SelectedItem = null;
        }
    }
}
