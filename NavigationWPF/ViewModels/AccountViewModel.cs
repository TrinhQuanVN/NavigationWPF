using NavigationWPF.Commands;
using NavigationWPF.Services;
using NavigationWPF.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationWPF.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public AccountViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            var service = new NavigationService(_navigationStore, () => new HomeViewModel(navigationStore));
            HomeNavigationCommand = new NavigationCommand(service);
        }

        public ICommand HomeNavigationCommand { get; }
    }
}
