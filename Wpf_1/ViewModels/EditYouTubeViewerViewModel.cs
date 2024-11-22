using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_1.ViewModels
{
    public class EditYouTubeViewerViewModel
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }
        public EditYouTubeViewerViewModel()
        {
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel();
        }
    }
}
