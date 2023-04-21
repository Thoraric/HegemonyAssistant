using Hegemony.Views;
using Hegemony.Models;
using Microsoft.Maui;
using Microsoft.Maui.Graphics;

namespace Hegemony;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();


        MainPage = new AppShell();


    }

}
