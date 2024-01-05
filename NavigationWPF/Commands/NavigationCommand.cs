using NavigationWPF.Services;
using NavigationWPF.Store;
using NavigationWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationWPF.Commands
{
    public class NavigationCommand : CommandBase
    {
        private readonly NavigationService navigationService;

        public NavigationCommand(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object? parameter)
        {
            navigationService.Navigate();
        }
    }
}
