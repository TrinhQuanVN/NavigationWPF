using NavigationWPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore navigationStore;

        public MainViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            this.navigationStore.CurrentViewModelChange += OnCurrentViewModelChange;
        }

        public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;
        private void OnCurrentViewModelChange()
        {
            OnPropertyChange(nameof(CurrentViewModel));
        }
    }
}
