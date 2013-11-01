using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Controls
{
	public static partial class FontAwesome
	{
		public const string FamilyName = "FontAwesome";

		public static FAIcon EnumForIconIdentifier(string identifier)
		{
			return ((NSString)null).EnumForFontAwesomeIconIdentifier(identifier);
		}

		public static string IconStringForEnum(FAIcon value)
		{
			return ((NSString)null).IconStringForFontAwesomeEnum(value);
		}

		public static string IconStringForIconIdentifier(string identifier)
		{
			return ((NSString)null).IconStringForFontAwesomeIconIdentifier(identifier);
		}

		public static UIFont FontOfSize(float size)
		{
			return UIFont.FromName(FamilyName, size);
		}
	}
}
