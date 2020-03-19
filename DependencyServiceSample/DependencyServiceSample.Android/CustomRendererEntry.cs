using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependencyServiceSample.Droid;
using DependencyServiceSample;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DependencyServiceSample.Controls;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(MyEntry), typeof(CustomRendererEntry))]
namespace DependencyServiceSample.Droid
{
    public class CustomRendererEntry: EntryRenderer
    {
        public CustomRendererEntry(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);                
            }
        }
    }
}