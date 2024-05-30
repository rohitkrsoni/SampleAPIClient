using Microsoft.Kiota.Abstractions.Authentication;
using System;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSdk;

namespace SampleAPIClient
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			var authProvider = new AnonymousAuthenticationProvider();
			var requestAdapter = new HttpClientRequestAdapter(authProvider);

			var client = new GraphClient(requestAdapter);
			var x = await client.GetAsGetResponseAsync();
			Console.WriteLine($"Id: {x.Id}");
			Console.WriteLine($"Name: {x.Name}");
		}
	}
}
