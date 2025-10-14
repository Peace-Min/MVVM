using MVVM.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    public class NewViewModel : INotifyPropertyChanged
    {
        private string _텍스트;

        public event PropertyChangedEventHandler? PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string 텍스트
        {
            get { return _텍스트; }
            set
            {
                _텍스트 = value;
                OnPropertyChanged(nameof(텍스트));
            }
        }

        public Command 화면이동Cmd { get; set; }

        public NewViewModel()
        {
            화면이동Cmd = new Command(화면이동);
        }

        private void 화면이동(object obj)
        {
            Shell.Current.GoToAsync(nameof(NewPage2));
        }
    }
}
