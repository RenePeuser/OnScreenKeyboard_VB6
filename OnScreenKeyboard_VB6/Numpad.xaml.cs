using System.Windows;

namespace OnScreenKeyboard_VB6.Controls
{
    /// <summary>
    /// Interaction logic for Numpad.xaml
    /// </summary>
    public partial class Numpad
    {
        public Numpad()
        {
            InitializeComponent();
            _textBox.Focus();

            foreach (var key in _numpad.Keys)
            {
                key.OnScreenKeyPress += new WpfKb.Controls.OnScreenKeyEventHandler(key_OnScreenKeyPress);
            }
        }

        void key_OnScreenKeyPress(DependencyObject sender, WpfKb.Controls.OnScreenKeyEventArgs e)
        {
            if (e.OnScreenKey.Key.DisplayName == "OK") this.Close();
        }
    }
}
