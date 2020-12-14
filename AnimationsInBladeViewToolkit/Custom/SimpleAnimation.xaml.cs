using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace AnimationsInBladeViewToolkit.Custom
{
    public sealed partial class SimpleAnimation : UserControl
    {
        public SimpleAnimation()
        {
            this.InitializeComponent();
        }


        private async void AnimateButton_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            AnimateButton.IsEnabled = false; // Disable the button while the animation is in progress


            Element.Visibility = (Element.Visibility == Visibility.Visible) ? Visibility.Collapsed : Visibility.Visible;


            await Task.Delay( 1000 );
            AnimateButton.Content   = (string)AnimateButton.Content == "Fly In" ? "Fly Out" : "Fly In";
            AnimateButton.IsEnabled = true; // Re-enable the button when the animation is complete
        }
    }
}
