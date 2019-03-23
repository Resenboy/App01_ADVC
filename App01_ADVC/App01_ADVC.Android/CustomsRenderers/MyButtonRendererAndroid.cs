using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(App01_ADVC.Customs.MyButton), typeof(App01_ADVC.Droid.CustomsRenderers.MyButtonRendererAndroid))]
namespace App01_ADVC.Droid.CustomsRenderers
{
    public class MyButtonRendererAndroid : ButtonRenderer
    {
        public MyButtonRendererAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.shape_button_Rounded);
            }
        }
    }
}