using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XFEPreferencesSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            RandomLabel.Text = Preferences.Get("RandomText", string.Empty);
            RandomSwitch.IsToggled = Preferences.Get("RandomSwitch", false);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Preferences.Set("RandomText", RandomLabel.Text);
            Preferences.Set("RandomSwitch", RandomSwitch.IsToggled);
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Preferences.Clear();
        }
    }
}
