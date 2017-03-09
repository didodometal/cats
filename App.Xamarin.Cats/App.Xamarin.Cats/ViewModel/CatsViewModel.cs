using App.Xamarin.Cats.Model.Entities;
using App.Xamarin.Cats.Storage.Repository;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App.Xamarin.Clientes.ViewModel
{
    public class CatsViewModel : INotifyPropertyChanged
    {
        private bool Busy;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(
         [System.Runtime.CompilerServices.CallerMemberName]
         string propertyName = null) =>
         PropertyChanged?.Invoke(this,
         new PropertyChangedEventArgs(propertyName));
        public bool IsBusy
        {
            get
            {
                return Busy;
            }
            set
            {
                Busy = value;
                OnPropertyChanged();
                GetCatsCommand.ChangeCanExecute();
            }
        }

        public ObservableCollection<Cat> Cats { get; set; }
        public CatsViewModel()
        {
            Cats = new ObservableCollection<Cat>();
            GetCatsCommand = new Command(async () => await GetCats(), () => !IsBusy);        }

        public Command GetCatsCommand { get; set; }
        async Task GetCats()
        {
            if (!IsBusy)
            {
                Exception Error = null;
                try
                {
                    IsBusy = true;
                    var Repository = new CatRepository();
                    var items = await Repository.ObterTodos();                    Cats.Clear();
                    items.ToList().ForEach(Cats.Add);
                }
                catch (Exception ex)
                {
                    Error = ex;

                }
                finally
                {
                    IsBusy = false;
                }
                if (Error != null)
                {
                    await Application.Current.MainPage.DisplayAlert(
                    "Error!", Error.Message, "OK");
                }
            }
            return;
        }
    }
}
