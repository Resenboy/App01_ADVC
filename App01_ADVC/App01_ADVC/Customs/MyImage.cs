using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App01_ADVC.Customs
{
    public class MyImage : Image
    {
        public static readonly BindableProperty TintColorProperty = BindableProperty.Create(nameof(TintColor), typeof(Color), typeof(MyImage), Color.Black);

        public Color TintColor
        {
            get { return (Color)GetValue(TintColorProperty); }
            set { SetValue(TintColorProperty, value); }
        }
    }
}
