using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace C8_Exercises.View.Exercise3;

public partial class AddNewPasswordPage : ContentPage
{
    private string _message;
	public AddNewPasswordPage()
	{
		InitializeComponent();
	}

    private async void ButonSave_Clicked(object sender, EventArgs e)
    {
		if(IsValidPassword() && IsValidConfirmPassword())
		{
            await Navigation.PushAsync(new NewPasswordConfirmedPage());
		}
        else if(!IsValidPassword() || !IsValidConfirmPassword())
        {
            await Toast.Make(_message,ToastDuration.Short).Show();
        }
		
    }

    private bool IsValidConfirmPassword()
    {
        if (string.IsNullOrEmpty(entryConfirmPassword.Text))
        {
            _message = "Enter confirm  password";
            return false;
        }
        else if (!entryConfirmPassword.Text.Equals(entryNewPassword.Text))
        {
            _message = "Confirm password doesn't match with new password.";
            return false;
        }
        _message = string.Empty;
        return true;
    }

    private bool IsValidPassword()
    {
        if (string.IsNullOrEmpty(entryNewPassword.Text))
        {
            _message = "Enter password";
            return false;
        }
        else if (entryNewPassword.Text.Length < 8)
        {
            _message = "Password length must be 8";
            return false;
        }
        _message = string.Empty;
        return true;
    }
}