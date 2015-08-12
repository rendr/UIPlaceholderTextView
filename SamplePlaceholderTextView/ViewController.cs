using System;

using UIKit;

namespace SamplePlaceholderTextView
{
	public partial class ViewController : UIViewController
	{
		private UITapGestureRecognizer _tapGestureRecognizer;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			MyTextView.PlaceHolderText = "Write about your feelings here...";

			InitTapOutside();
		}

		void InitTapOutside ()
		{
			_tapGestureRecognizer = new UITapGestureRecognizer (OnTapOutside);
			this.View.AddGestureRecognizer(_tapGestureRecognizer);
		}

		void OnTapOutside(UIGestureRecognizer recognizer){
			MyTextView.ResignFirstResponder();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

