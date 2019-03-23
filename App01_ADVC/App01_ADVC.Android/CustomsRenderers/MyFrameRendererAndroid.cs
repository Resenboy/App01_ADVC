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

[assembly: ExportRenderer(typeof(App01_ADVC.Customs.MyFrame), typeof(App01_ADVC.Droid.CustomsRenderers.MyFrameRendererAndroid))]
namespace App01_ADVC.Droid.CustomsRenderers
{
    public class MyFrameRendererAndroid : FrameRenderer
    {
        public MyFrameRendererAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null && e.OldElement == null)
            {
                this.SetBackgroundResource(Resource.Drawable.shape_frame_Rounded);
                GradientDrawable drawable = (GradientDrawable)this.Background;
                drawable.SetColor(Android.Graphics.Color.ParseColor("#FFFCD4"));
            }

        }
    }
}