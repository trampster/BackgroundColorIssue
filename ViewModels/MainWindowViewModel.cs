using Avalonia.Media;

namespace BackgroundColorIssue.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";


        public Brush BackgroundColor => new SolidColorBrush(Colors.Red);

    }
}
