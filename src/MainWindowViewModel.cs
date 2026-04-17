using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication1;

using CommunityToolkit.Mvvm.Input;

public partial class MainWindowViewModel
{
    [RelayCommand]
    private void Start()
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "emulator.exe",
            UseShellExecute = true
        });
    }
}