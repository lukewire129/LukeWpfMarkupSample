namespace LukeWpfMarkupSample.Pages;

public class MainWindow : MarkupWindow
{
    public MainWindow()
    {
        this.Build ();
    }
    public override void Build() => Content =
        VStack (
            Button()
        ).Background(Blue);
}
