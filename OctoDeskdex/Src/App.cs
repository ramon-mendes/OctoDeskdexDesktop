using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciterSharp;
using SciterSharp.Interop;

namespace OctoDeskdex
{
	class SciterMessages : SciterDebugOutputHandler
	{
		protected override void OnOutput(SciterSharp.Interop.SciterXDef.OUTPUT_SUBSYTEM subsystem, SciterSharp.Interop.SciterXDef.OUTPUT_SEVERITY severity, string text)
		{
			Console.WriteLine(text);// so I can see Debug output even if 'native debugging' is off
		}
	}

	static class App
	{
		private static SciterMessages sm = new SciterMessages();
		public static Window AppWnd { get; private set; }
		public static Host AppHost { get; private set; }

		public static void Run()
		{
			Console.WriteLine("Sciter " + SciterX.Version);
			Console.WriteLine("SciterSharp " + LibVersion.AssemblyVersion);

			AppWnd = new Window();
			AppHost = new Host(AppWnd);
			AppWnd.Show();

			/*#if OSX
			AppWnd._nsview.Window.StyleMask = AppKit.NSWindowStyle.Borderless | AppKit.NSWindowStyle.Resizable;
#endif*/
			#if !OSX
						PInvokeUtils.RunMsgLoop();
#endif
		}
	}
}