using System.Windows;
using Wpf_1.ViewModels;

namespace Wpf_1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new YouTubeViewersViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }

}
