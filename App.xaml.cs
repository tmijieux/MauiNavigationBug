using System.Diagnostics;

namespace MauiApp1;

public partial class App : Application
{
    private NavigationPage _nav;
    public App()
    {
        InitializeComponent();
        _nav = new NavigationPage(new MainPage());
        MainPage = _nav;
    }

    public async void Navigate()
    {
        try
        {
            await NavigateImpl();
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"ex={ex}");
        }
    }

    private async Task NavigateImpl()
    {
        var page = new OtherPage();
        _nav.Navigation.InsertPageBefore(page, _nav.RootPage);
        await _nav.PopToRootAsync(false);
    }
}
