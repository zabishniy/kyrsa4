using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсач.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Курсач.ViewModel
{
    class MainWindowViewModel :INotifyPropertyChanged
    {
        public Champ[] Champs { get; private set; }
        Champ selectedChamp;
        public Champ SelectedChamp 
        {
            get { return selectedChamp; }
            set
            {
                selectedChamp=value;
                OnPropertyChanged("SelectedChamp"); 
            }
        }
        public MainWindowViewModel()
        {
            Champs = Champ.GetChamps();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName ="")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
