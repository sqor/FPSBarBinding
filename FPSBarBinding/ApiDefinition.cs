using System;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace FPSBarBinding
{
    [BaseType (typeof (UIWindow))]
    interface FPSBar 
    {
        [Export ("showsAverage")]
        bool ShowsAverage { get; set; }

        [Export ("desiredChartUpdateInterval")]
        double DesiredChartUpdateInterval { get; set; }

        [Static, Export ("sharedInstance")]
        FPSBar SharedInstance { get; }

    } 
}

