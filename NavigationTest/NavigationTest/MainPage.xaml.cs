using CommunityToolkit.Maui.Views;

namespace NavigationTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await this.ShowPopupAsync(new TestPopup());
        }
    }

}
