using Wpf_1.ViewModels;

namespace Wpf_1.Stores
{
    public class ModalNavigationStore
    {
		private ViewModelBase _currentViewModel;
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

        public event Action CurrentViewModelChanged;

    }
}
