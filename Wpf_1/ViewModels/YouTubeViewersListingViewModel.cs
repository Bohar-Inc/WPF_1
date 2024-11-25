using System.Collections.ObjectModel;
using Wpf_1.Models;
using Wpf_1.Stores;

namespace Wpf_1.ViewModels
{
    public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels;
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;
        private YouTubeViewersListingItemViewModel _selectedYouTubeViewerListingItemViewModel;
        public YouTubeViewersListingItemViewModel SelectedYouTubeViewerListingItemViewModel
        {
            get
            {
                return _selectedYouTubeViewerListingItemViewModel;
            }
            set
            {
                _selectedYouTubeViewerListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedYouTubeViewerListingItemViewModel));
                _selectedYouTubeViewerStore.SelectedYouTubeViewer = _selectedYouTubeViewerListingItemViewModel.YouTubeViewer; 
            }
        }
        public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {
            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Mary", true, false)));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Sean", false, false)));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(new YouTubeViewer("Alan", true, true)));
        }
    }
}
