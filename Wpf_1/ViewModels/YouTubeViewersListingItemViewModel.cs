using System.Windows.Input;
using Wpf_1.Models;

namespace Wpf_1.ViewModels
{
    public class YouTubeViewersListingItemViewModel : ViewModelBase
    {
        public YouTubeViewer YouTubeViewer{ get; }

        public string Username => YouTubeViewer.Username;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer)
        {
            YouTubeViewer = youTubeViewer;
        }
    }
}
