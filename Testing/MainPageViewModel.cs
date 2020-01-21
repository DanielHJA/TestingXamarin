using System;
using Xamarin.Forms;

namespace Testing
{
    public class MainPageViewModel: BindableObject
    {

        private int _SliderValue = 0;
        public int SliderValue
        {
            get
            {
                return _SliderValue;
            }
            set
            {
                if (value != _SliderValue)
                {
                    _SliderValue = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainPageViewModel()
        {
        }
    }
}
