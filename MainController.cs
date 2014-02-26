using System;

using MonoTouch.UIKit;

using Octokit;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace GHClient
{
	public class MainController : UIViewController
	{
		private readonly GitHubClient _gitHubClient;
		private readonly string _login;

		public MainController(GitHubClient gitHubClient, string login)
		{
			_gitHubClient = gitHubClient;
			_login = login;
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			View.BackgroundColor = UIColor.White;

			/*
			var tuser = _gitHubClient.User.Get(_login);
			var cont = tuser.ContinueWith(t =>
			{
				Console.WriteLine(t.Result);
			});
			*/

			var tRep = _gitHubClient.Repository.GetAllForUser(_login);
			tRep.ContinueWith(t =>
			{
				Console.WriteLine(t.Result);
			});
		}
	}
}

