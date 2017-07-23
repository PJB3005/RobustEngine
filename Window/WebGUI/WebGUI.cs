using System;
using RobustEngine.Graphics;
using CefSharp;
using CefSharp.OffScreen;
using System.Threading.Tasks;
namespace RobustEngine
{
	public class WebGUI
	{
		private static ChromiumWebBrowser browser;
		private static Texture2D render;

		public WebGUI()
		{
			Cef.Initialize();
			browser = new ChromiumWebBrowser("https://www.google.com");
		}

		public void close()
		{
			Cef.Shutdown();
		}

		public Texture2D getRender()
		{
			return render;
		}

		private static void start()
		{

		}
	}
}
