using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecreationPage : ContentPage
	{
		public RecreationPage ()
		{
			InitializeComponent ();
            addImages();
		}

        private void addImages()
        {
            // get a handle to the current assembly
            var assembly = typeof(RecreationPage);

            // access the image file within the assembly
            string anPucan = "StudentApp.Images.anPucan.jpg";
            string skeff = "StudentApp.Images.skeff.png";
            string mcGettigans = "StudentApp.Images.mcGettigans.jpg";
            string dnaImage = "StudentApp.Images.dnaImage.jpg";
            string roisin = "StudentApp.Images.roisin.jpg";

            // load the image file into the placeholder in XAML
            AnPucan.Source = ImageSource.FromResource(anPucan, assembly);
            Skeff.Source = ImageSource.FromResource(skeff, assembly);
            McGettigans.Source = ImageSource.FromResource(mcGettigans, assembly);
            DNA.Source = ImageSource.FromResource(dnaImage, assembly);
            RoisinDubh.Source = ImageSource.FromResource(roisin, assembly);
        }

        private void AnPucanButton(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://anpucan.ie/"));
        }

        private void SkeffBarButton(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.theskeff.ie/"));            
        }

        private void McGettigansButton(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.mcgettigans.com/galway-ireland/"));
        }        

        private void DnaButton(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.dnagalway.com/"));
        }

        private void RoisinDubhButton(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.roisindubh.net/"));
        }

        
    }
}