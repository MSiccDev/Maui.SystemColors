using Microsoft.Maui.Platform;
using UIKit;

namespace Maui.SystemColors
{
#pragma warning disable CA1416
    public static partial class PlatformColors
    {
        //https://developer.apple.com/design/human-interface-guidelines/ios/visual-design/color/
        //https://developer.apple.com/documentation/uikit/uicolor/ui_element_colors
        #region System Colors
        public static Color SystemRed => UIColor.SystemRed.ToColor();
        public static Color SystemOrange => UIColor.SystemOrange.ToColor();
        public static Color SystemYellow => UIColor.SystemYellow.ToColor();
        public static Color SystemGreen => UIColor.SystemGreen.ToColor();

        public static Color SystemMint => UIColor.SystemMint.ToColor();
        public static Color SystemTeal => UIColor.SystemTeal.ToColor();
        public static Color SystemCyan => UIColor.SystemCyan.ToColor();
        public static Color SystemBlue => UIColor.SystemBlue.ToColor();
        public static Color SystemIndigo => UIColor.SystemIndigo.ToColor();
        public static Color SystemPurple => UIColor.SystemPurple.ToColor();
        public static Color SystemPink => UIColor.SystemPink.ToColor();
        public static Color SystemBrown => UIColor.SystemBrown.ToColor();


        public static Color SystemGray => UIColor.SystemGray.ToColor();
        public static Color SystemGray2 => UIColor.SystemGray2.ToColor();
        public static Color SystemGray3 => UIColor.SystemGray3.ToColor();
        public static Color SystemGray4 => UIColor.SystemGray4.ToColor();
        public static Color SystemGray5 => UIColor.SystemGray5.ToColor();
        public static Color SystemGray6 => UIColor.SystemGray6.ToColor();
        #endregion

        #region UI Element Colors
        public static Color SystemLabel => UIColor.Label.ToColor();
        public static Color SecondaryLabel => UIColor.SecondaryLabel.ToColor();
        public static Color TertiaryLabel => UIColor.TertiaryLabel.ToColor();
        public static Color QuaternaryLabel => UIColor.QuaternaryLabel.ToColor();
        public static Color Placeholder => UIColor.PlaceholderText.ToColor();
        public static Color Separator => UIColor.Separator.ToColor();
        public static Color OpaqueSeparator => UIColor.OpaqueSeparator.ToColor();
        public static Color LinkColor => UIColor.Link.ToColor();

        public static Color FillColor => UIColor.SystemFill.ToColor();
        public static Color SecondaryFillColor => UIColor.SecondarySystemFill.ToColor();
        public static Color TertiaryFillColor => UIColor.TertiarySystemFill.ToColor();
        public static Color QuaternaryFillColor => UIColor.QuaternarySystemFill.ToColor();

        public static Color SystemBackgroundColor => UIColor.SystemBackground.ToColor();
        public static Color SecondarySystemBackgroundColor => UIColor.SecondarySystemBackground.ToColor();
        public static Color TertiarySystemBackgroundColor => UIColor.TertiarySystemBackground.ToColor();

        public static Color SystemGroupedBackgroundColor => UIColor.SystemGroupedBackground.ToColor();
        public static Color SecondarySystemGroupedBackgroundColor => UIColor.SecondarySystemGroupedBackground.ToColor();
        public static Color TertiarySystemGroupedBackgroundColor => UIColor.TertiarySystemGroupedBackground.ToColor();

        public static Color DarkTextColor => UIColor.DarkText.ToColor();
        public static Color LightTextColor => UIColor.LightText.ToColor();

        #endregion


    }
#pragma warning restore CA1416

}
