using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(App01_ADVC.Customs.MyButton), typeof(App01_ADVC.iOS.CustomsRenderersIOS.MyButtonRendererIOS))]
namespace App01_ADVC.iOS.CustomsRenderersIOS
{
    public class MyButtonRendererIOS : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.Layer.CornerRadius = 10;
                Control.ClipsToBounds = true;
            }
        }
    }
}