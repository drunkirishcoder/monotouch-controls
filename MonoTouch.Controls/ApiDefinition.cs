using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Controls
{
	[Model, BaseType (typeof (NSObject))]
	public partial interface HPGrowingTextViewDelegate
	{
		[Export ("growingTextViewShouldBeginEditing:")]
		bool ShouldBeginEditing(HPGrowingTextView growingTextView);

		[Export ("growingTextViewShouldEndEditing:")]
		bool ShouldEndEditing(HPGrowingTextView growingTextView);

		[Export ("growingTextViewDidBeginEditing:")]
		void DidBeginEditing(HPGrowingTextView growingTextView);

		[Export ("growingTextViewDidEndEditing:")]
		void DidEndEditing(HPGrowingTextView growingTextView);

		[Export ("growingTextView:shouldChangeTextInRange:replacementText:")]
		bool ShouldChangeTextInRange(HPGrowingTextView growingTextView, NSRange range, string text);

		[Export ("growingTextViewDidChange:")]
		void DidChange(HPGrowingTextView growingTextView);

		[Export ("growingTextView:willChangeHeight:")]
		void WillChangeHeight(HPGrowingTextView growingTextView, float height);

		[Export ("growingTextView:didChangeHeight:")]
		void DidChangeHeight(HPGrowingTextView growingTextView, float height);

		[Export ("growingTextViewDidChangeSelection:")]
		void DidChangeSelection(HPGrowingTextView growingTextView);

		[Export ("growingTextViewShouldReturn:")]
		bool ShouldReturn(HPGrowingTextView growingTextView);
	}

	[BaseType (typeof (UIView))]
	public partial interface HPGrowingTextView //: UITextViewDelegate
	{
		[Export ("maxNumberOfLines")]
		int MaxNumberOfLines { get; set; }

		[Export ("minNumberOfLines")]
		int MinNumberOfLines { get; set; }

		[Export ("maxHeight")]
		int MaxHeight { get; set; }

		[Export ("minHeight")]
		int MinHeight { get; set; }

		[Export ("animateHeightChange")]
		bool AnimateHeightChange { get; set; }

		[Export ("animationDuration")]
		double AnimationDuration { get; set; }

		[Export ("placeholder", ArgumentSemantic.Retain)]
		string Placeholder { get; set; }

		[Export ("placeholderColor", ArgumentSemantic.Retain)]
		UIColor PlaceholderColor { get; set; }

		[Export ("internalTextView", ArgumentSemantic.Retain)]
		UITextView InternalTextView { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		HPGrowingTextViewDelegate Delegate { get; set; }

		[Export ("text", ArgumentSemantic.Retain)]
		string Text { get; set; }

		[Export ("font", ArgumentSemantic.Retain)]
		UIFont Font { get; set; }

		[Export ("textColor", ArgumentSemantic.Retain)]
		UIColor TextColor { get; set; }

		[Export ("textAlignment")]
		UITextAlignment TextAlignment { get; set; }

		[Export ("selectedRange")]
		NSRange SelectedRange { get; set; }

		[Export ("editable")]
		bool Editable { [Bind ("isEditable")] get; set; }

		[Since (3,0), Export ("dataDetectorTypes")]
		UIDataDetectorType DataDetectorTypes { get; set; }

		[Export ("returnKeyType")]
		UIReturnKeyType ReturnKeyType { get; set; }

		[Export ("keyboardType")]
		UIKeyboardType KeyboardType { get; set; }

		[Export ("contentInset", ArgumentSemantic.Assign)]
		UIEdgeInsets ContentInset { get; set; }

		[Export ("isScrollable")]
		bool IsScrollable { get; set; }

		[Export ("enablesReturnKeyAutomatically")]
		bool EnablesReturnKeyAutomatically { get; set; }

//		[Export ("becomeFirstResponder")]
//		bool BecomeFirstResponder();
//
//		[Export ("resignFirstResponder")]
//		bool ResignFirstResponder();
//
//		[Export ("isFirstResponder")]
//		bool IsFirstResponder { get; }

		[Export ("hasText")]
		bool HasText { get; }

		[Export ("scrollRangeToVisible:")]
		void ScrollRangeToVisible(NSRange range);

		[Export ("refreshHeight")]
		void RefreshHeight();
	}
}
