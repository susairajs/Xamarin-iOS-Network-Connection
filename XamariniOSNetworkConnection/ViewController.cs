using System;
using UIKit;

using Plugin.Connectivity;

namespace XamariniOSNetworkConnection
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void BtnCheck_TouchUpInside(UIButton sender)
		{
			// Via Xam.Plugin.Connectivity Plugin
			if (CrossConnectivity.Current.IsConnected)
			{
				lblStatus.Text = "Network Available";
			}
			else
			{
				lblStatus.Text = "Network UnAvailable";
			}
			//Via Reachability
			if (Reachability.IsHostReachable("http://google.com"))
			{
				lblCheck.Text = "Available";
			}
			else
			{
				lblCheck.Text = "Unavailable";
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
