using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_1.ViewModels
{
    public class AddYouTubeViewerViewModel
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }
        public AddYouTubeViewerViewModel()
        {
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel();
        }
    }
}
