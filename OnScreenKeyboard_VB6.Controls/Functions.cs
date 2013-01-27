using System.Windows;
using System.Windows.Forms;

namespace OnScreenKeyboard_VB6.Controls
{
    public static class Functions
    {
        public static void SetWindowSize(Window window)
        {
            //Höhe abhängig von Bildschirmauflösung            
            window.Height = Screen.PrimaryScreen.Bounds.Height * 0.5;

            //Höhe Breite abhängig von Bildschirmauflösung            
            window.Width = Screen.PrimaryScreen.Bounds.Width * 0.75;        
        }
    }
}
