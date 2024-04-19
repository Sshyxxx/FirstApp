using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace FirstApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Button_Click(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Debug Click!");
    }
    public void Button_Click2(object source, RoutedEventArgs args)
    {
        Debug.WriteLine("Debug Click 2!");
    }

}