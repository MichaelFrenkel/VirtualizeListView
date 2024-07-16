namespace Sample.CrashRepro;

public partial class CrashReproPage
{
    public CrashReproPage()
    {
        BindingContext = new CrashReproViewModel();
        InitializeComponent();
    }
}