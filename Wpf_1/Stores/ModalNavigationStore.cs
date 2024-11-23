using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_1.ViewModels;

namespace Wpf_1.Stores
{
    public class ModalNavigationStore
    {
		private ViewModelBase _currentViewModel;
        public event Action CurrentViewModelChanged;

        public ViewModelBase CurrentViewModel
        {
			get
			{
				return _currentViewModel;
			}
			set
			{
                _currentViewModel = value;
				CurrentViewModelChanged?.Invoke();
			}
		}

        public bool IsOpen => CurrentViewModel != null;
    }
}
