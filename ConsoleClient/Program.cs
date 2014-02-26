using System;

using Octokit;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleClient
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var github = new GitHubClient(new Connection(new ProductHeaderValue("MyApp"))
			{
				Credentials = new Credentials("eb249174ad803cb81a943e758faeac366778a3c4")
			});

			var tuser = github.User.Get("rzaitov");

			var cont = tuser.ContinueWith(t =>
			{
				Console.WriteLine(t.Result);
			});

			Task.WaitAll(tuser, cont);
//
////			tuser.RunSynchronously();
//
			Console.WriteLine("5555");


		}
	}
}
