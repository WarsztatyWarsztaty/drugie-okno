using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace okno;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, RoutedEventArgs e)
    {
        Background = Brush.Parse("#C8E6C9");
    }
}