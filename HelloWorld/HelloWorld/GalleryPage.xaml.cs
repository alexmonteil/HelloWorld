using System;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GalleryPage : ContentPage
	{

        private int _imageId = 60;

        public GalleryPage()
        {
            InitializeComponent();
            LoadImage();
        }


        private void PreviousButtonClicked(object sender, EventArgs e)
        {
            _imageId--;
            if (_imageId == 59) _imageId = 80;
            LoadImage();
        }

        private void NextButtonClicked(object sender, EventArgs e)
        {
            _imageId++;
            if (_imageId == 81) _imageId = 60;
            LoadImage();
        }

        private void LoadImage()
        {
            galleryimage.Source = new UriImageSource { Uri = new Uri($"https://picsum.photos/id/{_imageId}/1920/1200.jpg"), CachingEnabled = false };
        }

    }
}