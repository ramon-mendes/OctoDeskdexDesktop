using System;
using SciterSharp;
using SciterSharp.Interop;

namespace OctoDeskdex
{
	public class Window : SciterWindow
	{
		public Window()
		{
			var wnd = this;
			wnd.CreateMainWindow(979, 504);
			wnd.CenterTopLevelWindow();
			wnd.Title = "OctoDeskdex";
#if WINDOWS
			wnd.Icon = Properties.Resources.IconMain;
#endif
		}
	}
}