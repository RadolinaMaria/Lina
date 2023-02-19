using System;
using Xamarin.Forms;
using Phone_Book_2._0;

namespace Phone_Book_2
{
    public partial class AddPage : ContentPage
{
        public object Picture { get; private set; }
        public object Phone { get; private set; }
        public object Name { get; private set; }
        
        public AddPage()
    {
        InitializeComponent();
    }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
    {
            var contact = new Contact
            (
                picture: new Uri(this.Picture.Text),
                name: this.Name.Text,
                phone: this.Phone.Text
            ) ;

        await Navigation.PushAsync(new MainPage(contact));
    }
}
}