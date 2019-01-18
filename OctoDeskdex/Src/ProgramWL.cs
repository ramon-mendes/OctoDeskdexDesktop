#if WINDOWS || GTKMONO
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciterSharp;
using SciterSharp.Interop;

namespace OctoDeskdex
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			if(IntPtr.Size == 4)
			{
				Debug.Assert(false, "sciter.dll that comes bundled in DeveloperArsenal is the x64 version, make sure to change it to the x86 version if building for x86 (Windows only)");
			}

			SciterX.API.SciterSetOption(IntPtr.Zero, SciterXDef.SCITER_RT_OPTIONS.SCITER_SET_GFX_LAYER, (IntPtr) SciterXDef.GFX_LAYER.GFX_LAYER_D2D);

#if WINDOWS
			// Sciter needs this for drag'n'drop support; STAThread is required for OleInitialize succeess
			int oleres = PInvokeWindows.OleInitialize(IntPtr.Zero);
			Debug.Assert(oleres == 0);
#endif
#if GTKMONO
			PInvokeGTK.gtk_init(IntPtr.Zero, IntPtr.Zero);
			Mono.Setup();
#endif

			App.Run();
		}
	}
}
#endif