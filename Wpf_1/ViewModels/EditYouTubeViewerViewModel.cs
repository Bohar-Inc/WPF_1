using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_1.Commands;
using Wpf_1.Models;
using Wpf_1.Stores;

namespace Wpf_1.ViewModels
{
    public class EditYouTubeViewerViewModel : ViewModelBase
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }
        public EditYouTubeViewerViewModel(YouTubeViewer youTubeViewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(null, cancelCommand)
            {
                Username = youTubeViewer.Username,
                IsSubscribed = youTubeViewer.IsSubscribed,
                IsMember = youTubeViewer.IsMember
            };
        }
    }
}
