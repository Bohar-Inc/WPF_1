using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_1.Stores;

namespace Wpf_1.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        public ViewModelBase CurrentModalViewModal => _modalNavigationStore.CurrentViewModel;
        public bool IsModalOpen => _modalNavigationStore.IsOpen;
        public YouTubeViewersViewModel YouTubeViewersViewModel { get; }
        public MainViewModel(ModalNavigationStore modalNavigationStore, YouTubeViewersViewModel youTubeViewersViewModel)
        {
            _modalNavigationStore = modalNavigationStore;
            YouTubeViewersViewModel = youTubeViewersViewModel;
            _modalNavigationStore.CurrentViewModelChanged += ModalNavigationStore_CurrentViewModelChanged; 
            _modalNavigationStore.CurrentViewModel = new EditYouTubeViewerViewModel();
        }
        protected override void Dispose()
        {
            _modalNavigationStore.CurrentViewModelChanged -= ModalNavigationStore_CurrentViewModelChanged;
            base.Dispose();
        }
        private void ModalNavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModal));
            OnPropertyChanged(nameof(IsModalOpen));
        }
    }
}
