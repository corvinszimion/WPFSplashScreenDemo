using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFSplashScreen;

namespace WPFSplashScreenDemo
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			var settings = new SplashScreenSettings(TimeSpan.FromSeconds(5), new CustomSplashScreenA(), new MainWindow());
			this.UseSplashScreen(settings);
		}
	}
}
