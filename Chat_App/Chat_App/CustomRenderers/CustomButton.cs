﻿using Xamarin.Forms;

namespace Chat_App
{
    public class CustomButton : Button
    {
        /// <summary>
        /// AutoCapitalization property
        /// </summary>
        public static readonly BindableProperty AutoCapitalizationProperty = BindableProperty.Create(nameof(AutoCapitalization), typeof(bool), typeof(CustomButton), false);
        public bool AutoCapitalization
        {
            get { return (bool)GetValue(AutoCapitalizationProperty); }
            set { SetValue(AutoCapitalizationProperty, value); }
        }
    }
}