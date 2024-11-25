using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_1.ViewModels
{
    public class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        public string Username { get; }
        public string IsSubscribedDisplay { get; }
        public string IsMemberDisplay { get; }
        public YouTubeViewersDetailsViewModel()
        {
            Username = "SingletonSean";
            IsSubscribedDisplay = "Yes";
            IsMemberDisplay = "No";
        }
    }
}
