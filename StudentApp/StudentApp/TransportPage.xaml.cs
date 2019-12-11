using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransportPage : ContentPage
	{        
		public TransportPage ()
		{
			InitializeComponent ();
            addImages();
		}

        private void addImages()
        {
            // get a handle to the current assembly
            var assembly = typeof(TransportPage);            

            // access the image file within the assembly
            string mainImage = "StudentApp.Images.trainImage350.jpg";
            string busImage = "StudentApp.Images.busImage350.jpg";

            // load the image file into the placeholder in XAML
            TrainImage.Source = ImageSource.FromResource(mainImage, assembly);
            BusImage.Source = ImageSource.FromResource(busImage, assembly);
        }        

        private void IarnrodEireann(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.irishrail.ie/train-timetables"));
        }

        private void GalwayCity(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/inner.php?id=459"));
        }

        private void BusEireann(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/inner.php?id=243"));
        }

        private void BusEireannExpress(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.buseireann.ie/inner.php?id=243"));
        }

        private void CityLink(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.citylink.ie/timetables"));
        }

        private void GoBus(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.gobus.ie/"));
        }

        private void BusFeda(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://busfeda.ie/galway-donegal-timetable"));
        }

        private void Burkesbus(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://burkesbus.com/"));
        }

        private void Buslink(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://buslink.ie/BuslinkTimetable.pdf"));
        }

        
    }
}