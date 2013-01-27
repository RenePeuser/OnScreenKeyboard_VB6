namespace OnScreenKeyboard_VB6.Controls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Keyboard
    {
        public Keyboard()
        {
            InitializeComponent();
            _textBox.Focus();

            foreach (var key in _onScreenKeyboard.Keys)
            {               
                key.OnScreenKeyUp += key_OnScreenKeyUp;
            }
        }

        void key_OnScreenKeyUp(System.Windows.DependencyObject sender, WpfKb.Controls.OnScreenKeyEventArgs e)
        {
            if (e.OnScreenKey.Key.DisplayName == "Enter") this.Close();
        }
    }
}
