using System.Windows;
using System.Windows.Controls;

namespace ChessUI
{
    public partial class DrawMenu : UserControl
    {
        public event Action<Option> OptionSelected;
        public DrawMenu()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Draw);
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Continue);
        }
    }
}