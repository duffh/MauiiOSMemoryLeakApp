namespace MauiiOSMemoryLeakApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void GCCollectBtn_Clicked(object sender, EventArgs e)
    {
		GC.Collect();
    }

    private async void OpenGeoViewPageShellBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GeoViewPage));
    }

    private void OpenGeoViewPageNavigationBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GeoViewPage());
    }

    private async void OpenMockGeoViewPageShellBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MockGeoViewPage));
    }

    private void OpenMockGeoViewPageNavigationBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MockGeoViewPage());   
    }
}

