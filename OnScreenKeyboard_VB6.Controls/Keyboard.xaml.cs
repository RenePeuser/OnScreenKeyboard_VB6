using TextBox = System.Windows.Controls.TextBox;

namespace OnScreenKeyboard_VB6.Controls
{   
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

            Functions.SetWindowSize(this);
        }
       
        void key_OnScreenKeyUp(System.Windows.DependencyObject sender, WpfKb.Controls.OnScreenKeyEventArgs e)
        {
            if (e.OnScreenKey.Key.DisplayName == "Enter")
            {
                var result = _textBox.GetBindingExpression(TextBox.TextProperty);
                result.UpdateSource();
                this.Close();                           
            }
        }
    }
}
