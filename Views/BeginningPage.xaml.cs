namespace Views;

public partial class BeginningPage : ContentPage
{
	public BeginningPage()
	{
		InitializeComponent();
	}
    async void ExploreNow_Clicked(System.Object sender, System.EventArgs e)
        => Application.Current.MainPage = new NavigationPage(new SearchPage());
}