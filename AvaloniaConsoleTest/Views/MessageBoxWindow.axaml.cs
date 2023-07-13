using Avalonia;
using Avalonia.Controls;
using AvaloniaConsoleTest.ViewModels;
using System;

namespace AvaloniaConsoleTest.Views
{
    public partial class MessageBoxWindow : Window
    {
        public MessageBoxViewModel ViewModel { get; }

        public MessageBoxWindow()
        {
            InitializeComponent();

        }
    }
}
