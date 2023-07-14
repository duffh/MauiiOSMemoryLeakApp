namespace MauiiOSMemoryLeakApp;

public partial class MockGeoViewPage : ContentPage
{
	public MockGeoViewPage()
	{
		InitializeComponent();

        Initialize();
	}

	private void Initialize()
	{
		var byteArray = CreatByteArray(1000);
	}

	private byte[] CreatByteArray(int length)
	{
		var byteArray = new byte[length];
        for (int i = 0; i < length; i++)
        {
            byteArray[i] = 0x20;
        }

        return byteArray;
	}
}