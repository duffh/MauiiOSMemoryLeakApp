using Esri.ArcGISRuntime.Mapping;

namespace MauiiOSMemoryLeakApp;

public partial class GeoViewPage : ContentPage
{
	public GeoViewPage()
	{
		InitializeComponent();

		Initialize();
	}

	private void Initialize()
	{
        Esri.ArcGISRuntime.ArcGISRuntimeEnvironment.ApiKey = "";

        MyMapView.Map = new Esri.ArcGISRuntime.Mapping.Map(BasemapStyle.ArcGISNavigation);

        MyMapView.SetViewpoint(new Viewpoint(
            latitude: 34.027,
            longitude: -118.805,
            scale: 72223.819286));
    }
}