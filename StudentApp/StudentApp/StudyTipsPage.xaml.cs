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
	public partial class StudyTipsPage : ContentPage
	{
		public StudyTipsPage ()
		{
			InitializeComponent ();
            AddImages();
        }

        private void AddImages()
        {
            // get a handle to the current assembly
            var assembly = typeof(StudyTipsPage);

            // access the image file within the assembly
            string noteImage = "StudentApp.Images.noteImage.jpg";
            string openUniversity = "StudentApp.Images.openUniversity.png";
            string studyTips = "StudentApp.Images.studyTips.jpg";
            string trinityCollege = "StudentApp.Images.trinityCollege.png";

            // load the image file into the placeholder in XAML
            MakeNoteImage.Source = ImageSource.FromResource(noteImage, assembly);
            OpenUniversity.Source = ImageSource.FromResource(openUniversity, assembly);
            StudyTips.Source = ImageSource.FromResource(studyTips, assembly);
            TrinityCollege.Source = ImageSource.FromResource(trinityCollege, assembly);
        }

        private async void MakeNoteImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyNotesPage());
        }

        private void OpenUniversity_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.openuniversity.edu/resources/study-skills"));
        }

        private void StudyTips_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://careersportal.ie/studyskills/index.php?ed_sub_cat_id=122"));
        }

        private void TrinityCollege_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://student-learning.tcd.ie/learning-resources/study-skills/"));
        }
    }
}