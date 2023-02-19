using Xamarin.Forms;
using Phone_Book_2._0;

namespace Phone_Book_2._0
{
    public partial class MainPage : ContentPage
    {
        public MainPage(Contact contact = null)
        {
            InitializeComponent();

            this.ListView.ItemsSource = ViewModel.Contacts;

            if (contact is Contact)
            {
                ViewModel.Contacts.Add(contact);
            }
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
        }
    }
}