using SPZ_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_Project.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RellayComand RecoveryViewCommand { get; set; }
        public RecoveryViewModel RecoveryVM { get; set; }

        private object  _currentView;

        public object  CurrentView
        {
            get { return _currentView; }
            set 
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            RecoveryVM = new RecoveryViewModel();

            CurrentView = RecoveryVM;

            RecoveryViewCommand = new RellayComand(o =>
            {
                CurrentView = RecoveryVM;
            });

        }
    }
}
