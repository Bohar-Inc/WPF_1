﻿using System.Collections.ObjectModel;

namespace Wpf_1.ViewModels
{
    public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel>? _youTubeViewersListingItemViewModels;

        public IEnumerable<YouTubeViewersListingItemViewModel>? YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels;

        public YouTubeViewersListingViewModel()
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>();
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Mary"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Mary"));
            _youTubeViewersListingItemViewModels.Add(new YouTubeViewersListingItemViewModel("Mary"));
        }
    }
}