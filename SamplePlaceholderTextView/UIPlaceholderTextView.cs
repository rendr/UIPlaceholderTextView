using System;
using UIKit;
using Foundation;


namespace Rendr.UI
{
	[Register ("UIPlaceholderTextView")]
	public class UIPlaceholderTextView : UITextView
	{
		private string placeHolderText;
		public string PlaceHolderText {
			get {
				return placeHolderText;
			}
			set {
				placeHolderText = value;
				if(string.IsNullOrEmpty(Text)){
					Text = placeHolderText;
					TextColor = UIColor.LightGray;
				}
			}
		}

		void Init ()
		{
			this.Delegate = new UIPlaceholderTextViewDelegate ();
		}

		public UIPlaceholderTextView ()
		{
			Init ();
		}

		public UIPlaceholderTextView (IntPtr handle) : base (handle)
		{
			Init();
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			Init();
		}
	}

	public class UIPlaceholderTextViewDelegate : UITextViewDelegate
	{
		public override bool ShouldBeginEditing (UITextView textView)
		{
			textView.TextColor = UIColor.Black;

			if(textView.Text == ((UIPlaceholderTextView)textView).PlaceHolderText) {
				textView.Text = "";
			}

			return true;
		}

		public override void EditingEnded (UITextView textView)
		{
			if(textView.Text == "") {
				textView.Text = ((UIPlaceholderTextView)textView).PlaceHolderText;
				textView.TextColor = UIColor.LightGray;
			}
		}
	}
}

