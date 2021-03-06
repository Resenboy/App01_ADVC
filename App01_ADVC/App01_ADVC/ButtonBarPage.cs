﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App01_ADVC
{
    public class BottomBarPage : TabbedPage
    {
        public enum BarThemeTypes { Light, DarkWithAlpha, DarkWithoutAlpha }

        public bool FixedMode { get; set; }
        public BarThemeTypes BarTheme { get; set; }

        public void RaiseCurrentPageChanged()
        {
            OnCurrentPageChanged();
        }
    }
}
