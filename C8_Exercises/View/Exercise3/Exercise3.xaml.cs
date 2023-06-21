

using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace C8_Exercises.View.Exercise3;

public partial class Exercise3 : ContentPage
{
	public Exercise3()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		if(string.IsNullOrWhiteSpace(entryEmailAddress.Text))
		{
			await Toast.Make("Enter email",ToastDuration.Short).Show();
		}
		else if(!entryEmailAddress.Text.Equals("vedanshi@gmail.com"))
		{
			await Toast.Make("Your email id doesn't match", ToastDuration.Short).Show();
		}
		else if(entryEmailAddress.Text.Equals("vedanshi@gmail.com"))
		{
			await Navigation.PushAsync(new PasswordResetMessagePage());
		}
    }
}