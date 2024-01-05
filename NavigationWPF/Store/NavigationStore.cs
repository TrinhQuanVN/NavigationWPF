using NavigationWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationWPF.Store
{
    public class NavigationStore
    {
		private ViewModelBase currentViewModel;

		public event Action CurrentViewModelChange;
		public ViewModelBase CurrentViewModel
		{
			get { return currentViewModel; }
			set { currentViewModel = value; OnCurrentViewModelChange(); }
		}

		private void OnCurrentViewModelChange()
		{
			CurrentViewModelChange?.Invoke();
		}
	}
}
