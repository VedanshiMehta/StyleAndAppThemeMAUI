using C8_Exercises.View.Exercise5;
using C8_Exercises.View.Exercise6;

namespace C8_Exercises;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Exercise6();
        //{
        //	BarBackgroundColor = Colors.CadetBlue,
        //	BarTextColor = Colors.White,
        //};
    }
}
