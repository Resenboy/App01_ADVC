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
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(App01_ADVC.Customs.MyListView), typeof(App01_ADVC.Droid.CustomsRenderers.MyListViewRendererAndroid))]
namespace App01_ADVC.Droid.CustomsRenderers
{
    public class MyListViewRendererAndroid : ListViewRenderer
    {
        public MyListViewRendererAndroid(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var listView = this.Control as Android.Widget.ListView;
                listView.NestedScrollingEnabled = true;
            }
        }
    }
}