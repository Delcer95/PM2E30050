namespace PM2E30050.Views;

public partial class PhotoView : ContentPage
{
	public PhotoView(byte[] f)
    {
		InitializeComponent();
        //
        Stream stream = new MemoryStream(f);
        foto.Source = ImageSource.FromStream(() => stream);
    }
}
