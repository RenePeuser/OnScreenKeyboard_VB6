using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using OnScreenKeyboard_VB6;

namespace OnScreenkeyboard_VB6.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            _textbox.MouseDoubleClick += _textbox_MouseDoubleClick;
        }

        void _textbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OnScreenKeyboard_VB6.IOnScreenKeyboard_VB6 test = new OnScreenKeyboard_Vb6();
            _textbox.Text = test.ShowKeyboardDetail("","",_textbox.Text,1);
        }

        private void _textbox_TextChanged(object sender, TextChangedEventArgs e)
        {            
        }
    }
}
