using PointSized.Toolkit.Tools;

using Xamarin.Forms;

namespace PointSizedText
{
    public partial class PointSizedTextPage : ContentPage
    {
        public PointSizedTextPage()
        {

            // Instantiate sometehing in library so it can be used in XAML.
            var unused = new AltLabel();
            InitializeComponent();
        }
    }
}
