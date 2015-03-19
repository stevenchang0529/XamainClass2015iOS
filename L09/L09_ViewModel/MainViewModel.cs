using STC.Xamarin.MVVMFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L09_ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            this.ButtonText = "Hello! MVVM, Click Me!";
        }
        public string ButtonText
        {
            get { return this.GetProperty(() => this.ButtonText, _buttonText); }
            set { this.SetProperty(() => this.ButtonText, value, ref _buttonText); }
        }

        public BindingCommand DoButtonClick
        {
            get
            {
                if (_doButtonClick == null)
                    _doButtonClick = new BindingCommand(() =>
                    {
                        this.ButtonText = string.Format("你按下了{0}次", _count++);
                    });
                return _doButtonClick;
            }
        
        }
        private int _count = 1;
        private string _buttonText;
        private BindingCommand _doButtonClick;
    }
}
