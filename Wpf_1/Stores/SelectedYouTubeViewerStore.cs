using Wpf_1.Models;

namespace Wpf_1.Stores
{
    public class SelectedYouTubeViewerStore
    {
		private YouTubeViewer _selectedYouTubeViewer;
		public YouTubeViewer SelectedYouTubeViewer
        {
			get
			{
				return _selectedYouTubeViewer;
			}
			set
			{
				_selectedYouTubeViewer = value;
				SelectedYouTubeViewerChanged?.Invoke();
			}
		}
		public event Action SelectedYouTubeViewerChanged;

    }
}
