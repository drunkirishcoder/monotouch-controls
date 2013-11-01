using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Controls
{
	#region GrowingTextView

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

	#endregion

	#region RevealViewController

	[Model, Protocol, BaseType (typeof (NSObject))]
	public partial interface SWRevealViewControllerDelegate
	{
		[Export ("revealController:willMoveToPosition:")]
		void WillMoveToPosition(SWRevealViewController revealController, FrontViewPosition position);

		[Export ("revealController:didMoveToPosition:")]
		void DidMoveToPosition(SWRevealViewController revealController, FrontViewPosition position);

		[Export ("revealController:animateToPosition:")]
		void AnimateToPosition(SWRevealViewController revealController, FrontViewPosition position);

		[Export ("revealControllerPanGestureShouldBegin:")]
		bool PanGestureShouldBegin(SWRevealViewController revealController);

		[Export ("revealControllerPanGestureBegan:")]
		void PanGestureBegan(SWRevealViewController revealController);

		[Export ("revealControllerPanGestureEnded:")]
		void PanGestureEnded(SWRevealViewController revealController);

		[Export ("revealController:panGestureBeganFromLocation:progress:")]
		void PanGestureBeganFromLocation(SWRevealViewController revealController, float location, float progress);

		[Export ("revealController:panGestureMovedToLocation:progress:")]
		void PanGestureMovedToLocation(SWRevealViewController revealController, float location, float progress);

		[Export ("revealController:panGestureEndedToLocation:progress:")]
		void PanGestureEndedToLocation(SWRevealViewController revealController, float location, float progress);
	}

	[BaseType (typeof (UIViewController))]
	public partial interface SWRevealViewController
	{
		[Export ("initWithRearViewController:frontViewController:")]
		IntPtr Constructor(UIViewController rearViewController, UIViewController frontViewController);

		[Export ("rearViewController", ArgumentSemantic.Retain)]
		UIViewController RearViewController { get; set; }

		[Export ("rightViewController", ArgumentSemantic.Retain)]
		UIViewController RightViewController { get; set; }

		[Export ("frontViewController", ArgumentSemantic.Retain)]
		UIViewController FrontViewController { get; set; }

		[Export ("setFrontViewController:animated:")]
		void SetFrontViewController(UIViewController frontViewController, bool animated);

		[Export ("frontViewPosition")]
		FrontViewPosition FrontViewPosition { get; set; }

		[Export ("setFrontViewPosition:animated:")]
		void SetFrontViewPosition(FrontViewPosition frontViewPosition, bool animated);

		[Export ("revealToggleAnimated:")]
		void RevealToggleAnimated(bool animated);

		[Export ("rightRevealToggleAnimated:")]
		void RightRevealToggleAnimated(bool animated);

		[Export ("revealToggle:")]
		void RevealToggle(NSObject sender);

		[Export ("rightRevealToggle:")]
		void RightRevealToggle(NSObject sender);

		[Export ("panGestureRecognizer")]
		UIPanGestureRecognizer PanGestureRecognizer { get; }

		[Export ("rearViewRevealWidth")]
		float RearViewRevealWidth { get; set; }

		[Export ("rightViewRevealWidth")]
		float RightViewRevealWidth { get; set; }

		[Export ("rearViewRevealOverdraw")]
		float RearViewRevealOverdraw { get; set; }

		[Export ("rightViewRevealOverdraw")]
		float RightViewRevealOverdraw { get; set; }

		[Export ("rearViewRevealDisplacement")]
		float RearViewRevealDisplacement { get; set; }

		[Export ("rightViewRevealDisplacement")]
		float RightViewRevealDisplacement { get; set; }

		[Export ("draggableBorderWidth")]
		float DraggableBorderWidth { get; set; }

		[Export ("bounceBackOnOverdraw")]
		bool BounceBackOnOverdraw { get; set; }

		[Export ("bounceBackOnLeftOverdraw")]
		bool BounceBackOnLeftOverdraw { get; set; }

		[Export ("stableDragOnOverdraw")]
		bool StableDragOnOverdraw { get; set; }

		[Export ("stableDragOnLeftOverdraw")]
		bool StableDragOnLeftOverdraw { get; set; }

		[Export ("presentFrontViewHierarchically")]
		bool PresentFrontViewHierarchically { get; set; }

		[Export ("quickFlickVelocity")]
		float QuickFlickVelocity { get; set; }

		[Export ("toggleAnimationDuration")]
		double ToggleAnimationDuration { get; set; }

		[Export ("frontViewShadowRadius")]
		float FrontViewShadowRadius { get; set; }

		[Export ("frontViewShadowOffset", ArgumentSemantic.Assign)]
		SizeF FrontViewShadowOffset { get; set; }

		[Export ("frontViewShadowOpacity")]
		float FrontViewShadowOpacity { get; set; }

		[Wrap ("WeakDelegate")]
		SWRevealViewControllerDelegate Delegate { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }
	}

	[Category, BaseType (typeof (UIViewController))]
	public partial interface SWRevealViewController_UIViewController
	{
		[Export ("revealViewController")]
		SWRevealViewController GetRevealViewController();
	}

	#endregion

	#region FontAwesome

	[Category, Internal, BaseType (typeof (NSString))]
	public partial interface FontAwesome_NSString
	{
		[Static, Export ("fontAwesomeEnumForIconIdentifier:")]
		FAIcon EnumForFontAwesomeIconIdentifier(string identifier);

		[Static, Export ("fontAwesomeIconStringForEnum:")]
		string IconStringForFontAwesomeEnum(FAIcon value);

		[Static, Export ("fontAwesomeIconStringForIconIdentifier:")]
		string IconStringForFontAwesomeIconIdentifier(string identifier);
	}

//	[Category, Internal, BaseType (typeof (UIFont))]
//	public partial interface FontAwesome_UIFont
//	{
//		[Static, Export ("fontAwesomeFontOfSize:")]
//		UIFont FontAwesomeFontOfSize(float size);
//	}

	[BaseType (typeof (UIImageView))]
	public partial interface FAImageView
	{
		[Export ("defaultIconColor", ArgumentSemantic.Retain)]
		UIColor DefaultIconColor { get; set; }

		[Export ("defaultIconIdentifier", ArgumentSemantic.Retain)]
		string DefaultIconIdentifier { get; set; }

		[Export ("defaultIcon")]
		FAIcon DefaultIcon { get; set; }

		[Export ("defaultView", ArgumentSemantic.Retain)]
		UILabel DefaultView { get; set; }
	}

	#endregion
}
