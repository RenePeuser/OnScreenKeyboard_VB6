using System.EnterpriseServices;
using System.Runtime.InteropServices;
using System.Windows;
using OnScreenKeyboard_VB6.Controls;

namespace OnScreenKeyboard_VB6
{
    [EventTrackingEnabled(true)]
    [Description("Interface Serviced Component")]
    [ComVisible(true)]    
    public class OnScreenKeyboard_Vb6 : IOnScreenKeyboard_VB6
    {
        public string ShowKeyboardDetail(string controlName, string controlDescription, string text, int keyboardType)
        {
            return ShowOnScreenKeyboard(controlName, controlDescription, text, keyboardType);
        }

        public string ShowKeyboard(string text, int keyboardType)
        {
            return ShowOnScreenKeyboard("", "", text, keyboardType);
        }

        private string ShowOnScreenKeyboard(string controlName, string controlDescription, string text, int keyboardType)
        {           
            var viewModel = new KeyboardViewModel(controlName, controlDescription, text);
            Window onScreenKeyboard;

            switch (keyboardType)
            {
                case 0:
                    onScreenKeyboard = new Keyboard { DataContext = viewModel };
                    break;
                case 1:
                    onScreenKeyboard = new Numpad { DataContext = viewModel };
                    break;
                default:
                    onScreenKeyboard = new Keyboard { DataContext = viewModel };
                    break;
            }

            onScreenKeyboard.ShowDialog();
            return viewModel.UserText;
        }
    }
}
