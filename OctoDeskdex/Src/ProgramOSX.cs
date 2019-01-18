#if OSX
using System;
using System.Diagnostics;
using AppKit;
using Foundation;
using SciterSharp;
using SciterSharp.Interop;

namespace OctoDeskdex
{
	class Program
	{
		static void Main(string[] args)
		{
			// Default GFX in Sciter v4 is Skia, switch to CoreGraphics (seems more stable)
			SciterX.API.SciterSetOption(IntPtr.Zero, SciterXDef.SCITER_RT_OPTIONS.SCITER_SET_GFX_LAYER, new IntPtr((int) SciterXDef.GFX_LAYER.GFX_LAYER_CG));

			NSApplication.Init();

			using(var p = new NSAutoreleasePool())
			{
				var application = NSApplication.SharedApplication;
				application.Delegate = new AppDelegate();
				application.Run();
			}
		}
	}

	[Register("AppDelegate")]// needed?
	class AppDelegate : NSApplicationDelegate
	{
		public static Window AppWindow { get; private set; }
		public static Host AppHost { get; private set; }

		public override void DidFinishLaunching(NSNotification notification)
		{
			Mono.Setup();
			App.Run();

			// Set our custom menu with Cocoa
			var menu = new NSMenu();
			menu.AddItem(new NSMenuItem("Quit", "q", (sender, e) => NSApplication.SharedApplication.Terminate(menu)));
			var menubar = new NSMenu();
			menubar.AddItem(new NSMenuItem { Submenu = menu });

			NSApplication.SharedApplication.MainMenu = menubar;
		}

		public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender)
		{
			return false;
		}

		public override void WillTerminate(NSNotification notification)
		{
			// Insert code here to tear down your application
		}
	}
}
#endif