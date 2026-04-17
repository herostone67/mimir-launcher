using System.Diagnostics;
using System.Windows.Input;
using Avalonia.Controls;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}