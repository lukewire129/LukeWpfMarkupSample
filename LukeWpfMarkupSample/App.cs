using CSharpMarkup.WPF.Support;
using LukeWpfMarkupSample.Pages;

namespace LukeWpfMarkupSample;

public class App : MarkupApplication
{
    public App()
    {
        MainWindow = new MainWindow ();
    }
}
