using System.Windows;
using Wpf_1.Stores;
using Wpf_1.ViewModels;

namespace Wpf_1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;
        public App()
        {
            _selectedYouTubeViewerStore = new SelectedYouTubeViewerStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewersViewModel(_selectedYouTubeViewerStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
