using Android.Webkit;

namespace BVallejoExamen.Views;

public partial class AcercaDe : ContentPage
{
	public AcercaDe()
	{
		InitializeComponent();
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}