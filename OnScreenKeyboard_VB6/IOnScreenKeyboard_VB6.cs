using System.EnterpriseServices;
using System.Runtime.InteropServices;

[assembly: ApplicationName("OnScreenKeyboard_VB6")]
[assembly: Description("OnScreenKeyboard VB6")]
[assembly: ApplicationActivation(ActivationOption.Server)]
[assembly: ApplicationAccessControl(false)]

namespace OnScreenKeyboard_VB6
{
    /// <summary>
    /// Com Schnittstelle    
    /// </summary>
    [Guid("2ED93A49-C528-4A74-B6F5-3423DA97E012")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    [ComVisible(true)]
    public interface IOnScreenKeyboard_VB6
    {
        //Detail Methode um Infos zum Object anzugeben
        string ShowKeyboardDetail(string control, string controlDescription, string text, int keyboardType);

        //Standard methode nur Tastatur und Rückgabewert
        //Wichtig muss drin bleiben damit diese Version bei Erweiterungen Abwärtskompatibel bleibt.
        string ShowKeyboard(string text, int keyboardType);
    }
}
