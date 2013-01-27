namespace OnScreenKeyboard_VB6
{
    public class KeyboardViewModel : ViewModelBase
    {

        public KeyboardViewModel(string controlName, string controlDescription,string text)
        {
            base.DisplayName = "KeyboardViewModel";
            _userText = text;
            _controlName = controlName;
            _controlDescription = controlDescription;
        }

        private string _userText;
        public string UserText
        {
            get { return _userText; }
            set
            {
                if (_userText == value) return;
                _userText = value;
                base.OnPropertyChanged("UserText");
            }
        }
        
        private string _controlName;
        public string ControlName
        {
            get { return _controlName; }
            set
            {
                if (_controlName == value) return;
                _controlName = value;
                base.OnPropertyChanged("ControlName");
            }
        }

        private string _controlDescription;
        public string ControlDescription
        {
            get { return _controlDescription; }
            set
            {
                if (_controlDescription == value) return;
                _controlDescription = value;
                base.OnPropertyChanged("ControlDescription");
            }
        }    
    }
}
