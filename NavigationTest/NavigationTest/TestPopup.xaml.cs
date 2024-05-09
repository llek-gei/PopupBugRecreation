namespace NavigationTest;
using CommunityToolkit.Maui.Views;

public partial class TestPopup : Popup
{
	public TestPopup()
	{
		InitializeComponent();
    }
    async void OnClose(object? send, EventArgs e)
    {
        await CloseAsync();
    }
}