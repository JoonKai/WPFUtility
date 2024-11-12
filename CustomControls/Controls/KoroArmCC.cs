using System.Windows;
using System.Windows.Controls;

namespace CustomControls.Controls
{
    public class KoroArmCC : Control
    {


        public static readonly DependencyProperty IsRotateProperty = DependencyProperty.Register("IsRotate", typeof(bool), typeof(KoroArmCC), new PropertyMetadata(false));
        public bool IsRotate
        {
            get { return (bool)GetValue(IsRotateProperty); }
            set { SetValue(IsRotateProperty, value); }
        }



        static KoroArmCC()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KoroArmCC), new FrameworkPropertyMetadata(typeof(KoroArmCC)));
        }
    }
}
