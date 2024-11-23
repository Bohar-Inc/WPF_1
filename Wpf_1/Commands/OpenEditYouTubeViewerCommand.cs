using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_1.Models;
using Wpf_1.Stores;
using Wpf_1.ViewModels;

namespace Wpf_1.Commands
{
    public class OpenEditYouTubeViewerCommand : CommandBase
    {
        private readonly YouTubeViewer _youTubeViewer;
        private readonly ModalNavigationStore _modalNavigationStore;
        public OpenEditYouTubeViewerCommand(YouTubeViewer youTubeViewer, ModalNavigationStore modalNavigationStore)
        {
            _youTubeViewer = youTubeViewer;
            _modalNavigationStore = modalNavigationStore;
        }
        public override void Execute(object? parameter)
        {
            EditYouTubeViewerViewModel editYouTubeViewerViewModel = new EditYouTubeViewerViewModel(_youTubeViewer, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editYouTubeViewerViewModel;
        }
    }
}
