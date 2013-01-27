using System;
using System.Windows;
using System.Windows.Controls;

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
                key.OnScreenKeyUp += key_OnScreenKeyUp;
            }
        }

        void key_OnScreenKeyUp(DependencyObject sender, WpfKb.Controls.OnScreenKeyEventArgs e)
        {
            if (e.OnScreenKey.Key.DisplayName == "OK")
            {
                var result = _textBox.GetBindingExpression(TextBox.TextProperty);
                result.UpdateSource();
                this.Close();                
            }           
        }
    }
}
