using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Octokit;

namespace GHClient
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		private GitHubClient _gitHubClient;
		private string _login;

		private UIWindow _window;
		private MainController _mainController;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			_login = "rzaitov";
			_gitHubClient = new GitHubClient(new Connection(new ProductHeaderValue("MyApp"))
			{
				Credentials = new Credentials("eb249174ad803cb81a943e758faeac366778a3c4")
			});

			_window = new UIWindow(UIScreen.MainScreen.Bounds);
			_mainController = new MainController(_gitHubClient, _login);

			_window.RootViewController = _mainController;

			_window.MakeKeyAndVisible();

			return true;
		}
	}
}