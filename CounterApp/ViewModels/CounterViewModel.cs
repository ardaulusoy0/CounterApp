using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CounterApp.Commands;
using CounterApp.ViewModels.Base;

namespace CounterApp.ViewModels
{
    public class CounterViewModel : BaseViewModel
    {
        private int _counter;
        private string _mesaj;
        public int Counter
        {
            get { return _counter; }
            set
            {
                if (value != _counter)
                {
                    _counter = value;
                    OnPropertyChanged(nameof(Counter));
                    OnPropertyChanged(nameof(MessageBox));
                }
            }
        }

        public ICommand IncreaseCommand { get; }
        public ICommand DecreaseCommand { get; }

        public CounterViewModel()
        {
            Counter = 0;
            IncreaseCommand = new RelayCommand(IncreaseCounter, () => _counter < 10);
            DecreaseCommand = new RelayCommand(DecreaseCounter, () => _counter > 0);
        }

        private void IncreaseCounter() => Counter++;
        private void DecreaseCounter() => Counter--;


        public string MessageBox => _counter == 10 ? "Counter is max" : 
                                    _counter == 0 ? "Counter is min" : 
                                    "Counter is in range";
        
    }
}
