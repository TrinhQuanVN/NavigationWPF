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
    public class HomeViewModel : ViewModelBase
    {
        private readonly NavigationStore navigationStore;

        public HomeViewModel(NavigationStore navigationStore)
        {
            this.navigationStore = navigationStore;
            var service = new NavigationService(navigationStore, () => new AccountViewModel(navigationStore));
            AccountNavigationCommand = new NavigationCommand(service);
        }

        public ICommand AccountNavigationCommand { get; }
    }
}
