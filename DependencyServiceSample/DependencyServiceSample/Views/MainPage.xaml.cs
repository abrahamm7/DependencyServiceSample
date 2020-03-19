using DependencyServiceSample.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependencyServiceSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private IDeviceOrientation deviceOrientationSvc;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
            deviceOrientationSvc = DependencyService.Get<IDeviceOrientation>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var initialOrientation = deviceOrientationSvc.GetOrientation();
            ApplyOrientation(initialOrientation);
        }

        private async void ApplyOrientation(DeviceOrientation orientation)
        {
            switch (orientation)
            {
                case DeviceOrientation.Portrait:
                    await DisplayAlert("Message", "Device Portrait", "ok");
                    break;
                case DeviceOrientation.Landscape:
                    await DisplayAlert("Message", "Device Landscape", "ok");
                    break;
                default:
                    break;
            }
        }
    }
    
}
