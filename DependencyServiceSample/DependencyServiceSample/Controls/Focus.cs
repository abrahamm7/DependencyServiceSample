using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DependencyServiceSample.Controls
{
    public class Focus: RoutingEffect
    {
        public Focus() : base($"Effect.{nameof(Focus)}")
        {

        }
    }
}
