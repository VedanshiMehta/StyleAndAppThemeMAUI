using CommunityToolkit.Maui.Alerts;

namespace C8_Exercises.View.Exercise6;

public partial class Exercise6 : ContentPage
{
    private string _message;
	public Exercise6()
	{
		InitializeComponent();
	}

    private void Login_Clicked(object sender, EventArgs e)
    {
        ValidateUserFields();
		
    }

    private void ValidateUserFields()
    {
        if (IsValidUsername() && IsValidPassword())
        {
            Toast.Make("Login Successful", CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
            
        }
        else if (!IsValidUsername() || !IsValidPassword())
        {
            Toast.Make(_message, CommunityToolkit.Maui.Core.ToastDuration.Short).Show();
           
        }
    }

    private bool IsValidPassword()
    {
        if(string.IsNullOrWhiteSpace(password.Text))
        {
            _message = "Enter Password";
            labelPassword.Style = (Style) Resources["redLabelColorStyle"];
            borderPassword.Style= (Style)Resources["redBorderColorStyle"];
            return false;
        }
        else if(password.Text.Length<8)
        {
            _message = "Password must be atleast 8 characters";
            labelPassword.Style = (Style)Resources["redLabelColorStyle"];
            borderPassword.Style = (Style)Resources["redBorderColorStyle"];
            return false;
        }
        _message = string.Empty;
        labelPassword.Style = (Style)Resources["blackLabelColorStyle"];
        borderPassword.Style = (Style)Resources["blackBorderColorStyle"];
        return true;
    }

    private bool IsValidUsername()
    {
        if (string.IsNullOrWhiteSpace(username.Text))
        {
            _message = "Enter Username";
            labelUserName.Style = (Style)Resources["redLabelColorStyle"];
            borderUserName.Style= (Style)Resources["redBorderColorStyle"];
            return false;
        }
        _message = string.Empty;
        labelUserName.Style = (Style)Resources["blackLabelColorStyle"];
        borderUserName.Style = (Style)Resources["blackBorderColorStyle"];
        return true;
    }
}