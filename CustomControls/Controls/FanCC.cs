using System.Windows;
using System.Windows.Controls;

namespace CustomControls.Controls
{
    public class FanCC : Control
    {
        #region Dependency Properties
        public static readonly DependencyProperty FanOnProperty = DependencyProperty.Register("FanOn", typeof(bool), typeof(FanCC), new PropertyMetadata(false));
        public bool FanOn
        {
            get { return (bool)GetValue(FanOnProperty); }
            set { SetValue(FanOnProperty, value); }
        }

        #endregion

        static FanCC()
        {

            DefaultStyleKeyProperty.OverrideMetadata(typeof(FanCC), new FrameworkPropertyMetadata(typeof(FanCC)));
        }
    }
}
