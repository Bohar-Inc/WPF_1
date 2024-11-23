using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_1.Commands;
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
                _selectedYouTubeViewerStore.SelectedYouTubeViewer = _selectedYouTubeViewerListingItemViewModel?.YouTubeViewer;
            }
        }
        public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore, ModalNavigationStore modalNavigationStore)
        {
            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();
            AddYouTubeViewer(new YouTubeViewer("Mary",true,false), modalNavigationStore);
            AddYouTubeViewer(new YouTubeViewer("Sean",false,false), modalNavigationStore);
            AddYouTubeViewer(new YouTubeViewer("Alan",true,true), modalNavigationStore);
        }
        private void AddYouTubeViewer(YouTubeViewer youTubeViewer, ModalNavigationStore modalNavigationStore) 
        {
            ICommand editCommand = new OpenEditYouTubeViewerCommand(youTubeViewer, modalNavigationStore);
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel(youTubeViewer, editCommand));
        }
    }
}
