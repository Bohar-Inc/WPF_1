using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_1.Commands;
using Wpf_1.Stores;

namespace Wpf_1.ViewModels
{
    public class YouTubeViewersViewModel : ViewModelBase
    {
        private ModalNavigationStore modalNavigationStore;

        public YouTubeViewersListingViewModel YouTubeViewersListingViewModel { get; }
        public YouTubeViewersDetailsViewModel YouTubeViewersDetailsViewModel { get; }
        public ICommand AddYouTubeViewersCommand { get; }
        public YouTubeViewersViewModel(SelectedYouTubeViewerStore _selectedYouTubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            YouTubeViewersListingViewModel = new YouTubeViewersListingViewModel(_selectedYouTubeViewerStore);
            YouTubeViewersDetailsViewModel = new YouTubeViewersDetailsViewModel(_selectedYouTubeViewerStore);
            AddYouTubeViewersCommand = new OpenAddYouTubeViewerCommand(modalNavigationStore);
            this.modalNavigationStore = modalNavigationStore;
        }
    }
}
