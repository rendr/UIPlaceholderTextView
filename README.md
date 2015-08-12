# UIPlaceholderTextView
A UITextView that includes support for a placeholder.

I feel like we've written these many times before, so here's a version of one for use in Xamarin.iOS.

Usage:

    MyTextView.Placeholder = "Write about your feelings here...";

If you need to use a UITextViewDelegate, be sure to extend UIPlaceholderTextViewDelegate and preserve the behavior of ShouldBeginEditing and EditingEnded.

