namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void DoNavigate(object sender, EventArgs e)
    {
        (Application.Current as App).Navigate();
    }
}

