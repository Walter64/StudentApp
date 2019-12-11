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
	public partial class FinancePage : ContentPage
	{
		public FinancePage ()
		{
			InitializeComponent ();
            AddImages();
		}

        private void AddImages()
        {
            // get a handle to the current assembly
            var assembly = typeof(FinancePage);

            // access the image file within the assembly
            string susiImage = "StudentApp.Images.susi.jpg";
            string studentsUnionImage = "StudentApp.Images.StudentsUnion.png";
            string creditUnionImage = "StudentApp.Images.creditUnion.jpg";
            string aibImage = "StudentApp.Images.aib.jpg";

            string qualifaxImage = "StudentApp.Images.qualifax.png";
            string bankOfIrelandImage = "StudentApp.Images.bankOfIreland.jpg";
            string higherEducationImage = "StudentApp.Images.higherEducation.jpg";

            // load the image file into the placeholder in XAML
            SUSI.Source = ImageSource.FromResource(susiImage, assembly);
            StudentsUnion.Source = ImageSource.FromResource(studentsUnionImage, assembly);
            CreditUnion.Source = ImageSource.FromResource(creditUnionImage, assembly);
            AIB.Source = ImageSource.FromResource(aibImage, assembly);

            Qualifax.Source = ImageSource.FromResource(qualifaxImage, assembly);
            BankOfIreland.Source = ImageSource.FromResource(bankOfIrelandImage, assembly);
            HEA.Source = ImageSource.FromResource(higherEducationImage, assembly);
        }

        private void SUSI_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://susi.ie/"));
        }

        private void StudentsUnion_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://gmitsu.ie/"));
        }

        private void CreditUnion_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.creditunion.ie/"));
        }

        private void AIB_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://aib.ie/"));
        }

        private void Qualifax_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.qualifax.ie/index.php?option=com_content&view=article&id=607&Itemid=34"));
        }

        private void BankOfIreland_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.bankofireland.com/"));
        }

        private void HEA_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://hea.ie/"));
        }
    }
}