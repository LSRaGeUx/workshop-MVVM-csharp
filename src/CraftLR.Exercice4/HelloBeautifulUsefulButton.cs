using System;

using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CraftLR.Exercice4;

public partial class HelloBeautifulUsefulButton : Window
{
    public HelloBeautifulUsefulButton()
    {
        InitializeComponent();
    }

    public void Button_OnClick(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("Je suis un boutton qui click");
    }
}