using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudentApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddImages();
        }

        private void AddImages()
        {
            // get a handle to the current assembly
            var assembly = typeof(MainPage);

            // access the image file within the assembly
            string mainImage = "StudentApp.Images.mainImage_1.jpg";
            string transportImage = "StudentApp.Images.transport_1.jpg";
            string menuImage = "StudentApp.Images.cooking_1.jpg";
            string financeImage = "StudentApp.Images.finance_1.jpg";
            string emergencyImage = "StudentApp.Images.emergency_1.jpg";
            string recreationImage = "StudentApp.Images.recreation_1.jpg";
            string studyImage = "StudentApp.Images.study_1.jpg";

            // load the image file into the placeholder in XAML
            MainImage.Source = ImageSource.FromResource(mainImage, assembly);
            TransportImage.Source = ImageSource.FromResource(transportImage, assembly);
            MenuImage.Source = ImageSource.FromResource(menuImage, assembly);
            FinanceImage.Source = ImageSource.FromResource(financeImage, assembly);
            EmergencyImage.Source = ImageSource.FromResource(emergencyImage, assembly);
            RecreationImage.Source = ImageSource.FromResource(recreationImage, assembly);
            StudyTipsImage.Source = ImageSource.FromResource(studyImage, assembly);

        }

        //navigation to new pages
        private async void TransportImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransportPage());
        }

        private async void MenuImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }

        private async void FinanceImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FinancePage());
        }

        private async void EmergencyImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EmergencyPage());
        }

        private async void RecreationImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecreationPage());
        }

        private async void StudyTipsImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StudyTipsPage());
        }
    }
}
