using Plugin.Messaging;
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
	public partial class EmergencyPage : ContentPage
	{
		public EmergencyPage ()
		{
			InitializeComponent ();
            addImages();
		}

        private void addImages()
        {
            // get a handle to the current assembly
            var assembly = typeof(EmergencyPage);

            // access the image file within the assembly
            string tranquilImage = "StudentApp.Images.tranquil.jpg";

            // load the image file into the placeholder in XAML
            Tranquility.Source = ImageSource.FromResource(tranquilImage, assembly);
            
        }

        private void CounsellorsButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("091742118", "Student Services Office");                
            }
        }

        private void StudentsUnionButton(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://gmitsu.ie/welfare/"));
        }

        private void GalwayGardaButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("091538000", "Galway Garda Station");
            }
        }

        private void OranmoreGardaButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("091388030", "Oranmore Garda Station");
            }
        }

        private void FireStationButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("091509070", "Galway City Fire Station");
            }
        }

        private void UniversityHospitalButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("091524222", "University Hospital Galway");
            }
        }

        private void PietaHouseButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("091502921", "Pieta House Galway");
            }
        }

        private void JigSawButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("091549252", "JigSaw Galway");
            }
        }

        private void CitizenInformationButton(object sender, EventArgs e)
        {
            var phoneCallTask = CrossMessaging.Current.PhoneDialer;
            if (phoneCallTask.CanMakePhoneCall)
            {
                phoneCallTask.MakePhoneCall("0761077600", "Citizens Information Galway");
            }
        }

        private void CitizenInformationButtonSite(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://centres.citizensinformation.ie/centre.php?cic=Galway+CIC"));
        }
    }
}