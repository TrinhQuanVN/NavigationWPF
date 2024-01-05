using NavigationWPF.Services;
using NavigationWPF.Store;
using NavigationWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace NavigationWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        NavigationStore navigationStore;
        public App()
        {
            navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow view = new MainWindow();
            view.DataContext = new MainViewModel(navigationStore);
            view.Show();
            base.OnStartup(e);
        }

    }
}
