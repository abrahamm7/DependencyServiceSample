using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace DependencyServiceSample
{
    public interface IDeviceOrientation
    {
        DeviceOrientation GetOrientation();
    }
}
