using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace C8_Exercises.View.Exercise3;

public partial class NewPasswordConfirmedPage : ContentPage
{
	public NewPasswordConfirmedPage()
	{
		InitializeComponent();
	}

    private void ButtonOkay_Clicked(object sender, EventArgs e)
    {
		Toast.Make("New password confirmed successfull",ToastDuration.Short).Show();
    }
}