using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace VibraXam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                // Use default vibration length
                Vibration.Vibrate();

                // Or use specified time
                var duration = TimeSpan.FromSeconds(1);
                Vibration.Vibrate(duration);
            }
            catch (FeatureNotSupportedException ex)
            {
                await DisplayAlert("Sorry", "No can do amigo - no device support", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ooops", ex.Message, "Ok");
            }
        }
        
        async void Button_Clicked2(System.Object sender, System.EventArgs e)
        {
            try
            {
                // Haptic
                HapticFeedback.Perform(HapticFeedbackType.Click);
            }
            catch (FeatureNotSupportedException ex)
            {
                await DisplayAlert("Sorry", "No can do amigo - no device support", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ooops", ex.Message, "Ok");
            }
        }
    }
}
