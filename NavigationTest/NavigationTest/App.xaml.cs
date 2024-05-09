namespace NavigationTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TestTabbedPage();
            //MainPage = new MainPage();
        }
    }
}
