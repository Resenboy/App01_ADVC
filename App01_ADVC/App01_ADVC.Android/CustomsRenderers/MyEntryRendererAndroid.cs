using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(App01_ADVC.Customs.MyEntry), typeof(App01_ADVC.Droid.CustomsRenderers.MyEntryRendererAndroid))]
namespace App01_ADVC.Droid.CustomsRenderers
{
    public class MyEntryRendererAndroid : EntryRenderer
    {
        public MyEntryRendererAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                base.OnElementChanged(e);
                if (e.NewElement != null)
                {
                    var view = (Customs.MyEntry)Element;
                    if (view.IsCurvedCornersEnabled)
                    {
                        // creating gradient drawable for the curved background  
                        var _gradientBackground = new GradientDrawable();
                        _gradientBackground.SetShape(ShapeType.Rectangle);
                        _gradientBackground.SetColor(view.BackgroundColor.ToAndroid());

                        // Thickness of the stroke line  
                        _gradientBackground.SetStroke(view.BorderWidth + 1, view.BorderColor.ToAndroid());
                        
                        // Radius for the curves  
                        _gradientBackground.SetCornerRadius(
                            DpToPixels(this.Context, Convert.ToSingle(view.CornerRadius) + 10));

                        // set the background of the   
                        Control.SetBackground(_gradientBackground);
                    }
                    
                    //Set Altura do campo
                    Control.SetHeight(180);

                    Control.SetTextSize(ComplexUnitType.Px, 160);

                    // Set padding for the internal text from border  
                    Control.SetPadding(
                        (int)DpToPixels(this.Context, Convert.ToSingle(5)), Control.PaddingTop - 25,
                        (int)DpToPixels(this.Context, Convert.ToSingle(5)), Control.PaddingBottom - 25);
                }
                //Control.SetBackgroundResource(Resource.Drawable.shape_entry_Rounded);
            }

        }
        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}