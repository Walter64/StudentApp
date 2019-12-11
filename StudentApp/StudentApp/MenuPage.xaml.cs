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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            AddImages();
		}

        private void AddImages()
        {
            // get a handle to the current assembly
            var assembly = typeof(MenuPage);

            // access the image file within the assembly
            string breakfastImage = "StudentApp.Images.breakfast.jpg";
            string dinnerImage = "StudentApp.Images.dinner.jpg";
            string glutenfreeImage = "StudentApp.Images.glutenfree.jpg";
            string vegetarianImage = "StudentApp.Images.vegetarian.jpg";

            // load the image file into the placeholder in XAML
            BreakfastImage.Source = ImageSource.FromResource(breakfastImage, assembly);
            DinnerImage.Source = ImageSource.FromResource(dinnerImage, assembly);
            GlutenfreeImage.Source = ImageSource.FromResource(glutenfreeImage, assembly);
            VegaterianImage.Source = ImageSource.FromResource(vegetarianImage, assembly);            
        }

        private void BreakfastImage_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.bbcgoodfood.com/recipes/collection/quick-breakfast"));
        }

        private void DinnerImage_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.budgetbytes.com/top-20-recipes-eating-healthy-budget/"));
        }

        private void GlutenfreeImage_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.bbcgoodfood.com/recipes/collection/gluten-free-dinner"));
        }

        private void VegaterianImage_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://hurrythefoodup.com/vegetarian-recipes-for-students/"));
        }

       
    }
}