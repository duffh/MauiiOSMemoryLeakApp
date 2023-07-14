namespace MauiiOSMemoryLeakApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Initialize();
    }

    private void Initialize()
    {
        Routing.RegisterRoute(nameof(GeoViewPage), typeof(GeoViewPage));
        Routing.RegisterRoute(nameof(MockGeoViewPage), typeof(MockGeoViewPage));

        FlyoutItem geoViewItem = new FlyoutItem();
        geoViewItem.Title = "GeoViewPage";

        ShellContent shellContent = new ShellContent();
        shellContent.Content = new GeoViewPage();
        shellContent.Route = $"{nameof(GeoViewPage)}";

        geoViewItem.Items.Add(shellContent);

        FlyoutItem mockGeoViewItem = new FlyoutItem();
        mockGeoViewItem.Title = "MockGeoViewPage";

        shellContent = new ShellContent();
        shellContent.Content = new MockGeoViewPage();
        shellContent.Route = $"{nameof(MockGeoViewPage)}";

        mockGeoViewItem.Items.Add(shellContent);

        this.Items.Add(geoViewItem);
        this.Items.Add(mockGeoViewItem);
    }
}
