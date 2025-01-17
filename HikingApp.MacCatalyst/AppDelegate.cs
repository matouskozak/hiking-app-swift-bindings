using System;
using System.Globalization;
using HikingApp.MacCatalyst.ViewControllers;

namespace HikingApp.MacCatalyst;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);
        Window.RootViewController = new LoginViewController();

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;
	}
}
