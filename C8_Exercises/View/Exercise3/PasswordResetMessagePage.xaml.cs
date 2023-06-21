namespace C8_Exercises.View.Exercise3;

public partial class PasswordResetMessagePage : ContentPage
{
	public PasswordResetMessagePage()
	{
		InitializeComponent();
	}

    private async void ButtonNewPassword_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new AddNewPasswordPage());
    }
}