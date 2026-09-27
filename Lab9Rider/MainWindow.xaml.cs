using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab9Rider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplyCodeBasedStyle();
        }
        
        private void ApplyCodeBasedStyle()
        {
            var style = new Style(typeof(Button));
            style.Setters.Add(new Setter(Button.BackgroundProperty, new SolidColorBrush(Color.FromRgb(0x2E, 0x8B, 0x57))));
            style.Setters.Add(new Setter(Button.ForegroundProperty, Brushes.White));
            style.Setters.Add(new Setter(Button.FontWeightProperty, FontWeights.Bold));
            style.Setters.Add(new Setter(Button.PaddingProperty, new Thickness(14, 8, 14, 8)));
 
            CodeStyledButton.Style = style;
        }
    }
}