using Xamarin.Forms;

namespace PointSized.Toolkit.Tools
{
    // Suppose you’d like an enhanced Label class that lets you specify font sizes in units of points.
    public class AltLabel : Label
    {
        // Generally, a Binda-bleProperty object is assigned in the field definition by using the static BindableProperty.Cre-ate method.
        public static readonly BindableProperty PointSizeProperty =
            BindableProperty.Create("PointSize",        // propertyName
                                    typeof(double),     // returnType
                                    typeof(AltLabel),   // declaringType
                                    8.0,                // defaultValue
                                    propertyChanged: OnPointSizeChanged);

        public AltLabel()
        {
            SetLabelFontSize((double)PointSizeProperty.DefaultValue);
        }

        // The new PointSize property is implemented with a BindableProp-erty object named PointSizeProperty 
        // and a CLR property named PointSize that references PointSizeProperty
        public double PointSize
        {
            set { SetValue(PointSizeProperty, value); }
            get { return (double)GetValue(PointSizeProperty); }
        }

        static void OnPointSizeChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((AltLabel)bindable).OnPointSizeChanged((double)oldValue, (double)newValue);
        }

        void OnPointSizeChanged(double oldValue, double newValue)
        {
            SetLabelFontSize(newValue);
        }

        void SetLabelFontSize(double pointSize)
        {
            FontSize = 160 * pointSize / 72;
        }
    }
}
