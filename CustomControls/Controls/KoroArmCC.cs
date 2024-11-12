using System.Windows;
using System.Windows.Controls;

namespace CustomControls.Controls
{
    public class KoroArmCC : Control
    {
        static KoroArmCC()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KoroArmCC), new FrameworkPropertyMetadata(typeof(KoroArmCC)));
        }
    }
}
