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
    public class AddYouTubeViewerViewModel : ViewModelBase
    { 
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }
        public AddYouTubeViewerViewModel(ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(null, cancelCommand);
        }
    }
}
