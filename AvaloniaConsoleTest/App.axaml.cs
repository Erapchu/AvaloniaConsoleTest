using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaConsoleTest
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
