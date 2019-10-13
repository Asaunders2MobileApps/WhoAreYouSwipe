using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SwipeGesture
{
    class Constants
    {

        public static readonly Font TitleFont;
        public static readonly Font Font;
        public static readonly Color Fontcolor = Color.Black;
        public static readonly Color BackgroundColor = Color.Aqua;
        public static readonly Color BackgroundColor2 = Color.PaleVioletRed;
        public static readonly Color BackgroundColor3 = Color.Green;
        public static readonly Color BackgroundColor4 = Color.MediumBlue;


        static Constants()
        {
            Font = Font.SystemFontOfSize(20, FontAttributes.Bold);
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    TitleFont = Font.SystemFontOfSize(20, FontAttributes.Italic);
                    break;

                case Device.Android:
                    TitleFont = Font.SystemFontOfSize(20, FontAttributes.Bold);
                    break;

                case Device.UWP:
                    TitleFont = Font.SystemFontOfSize(20, FontAttributes.None);
                    break;
            }
        }

    }
}
