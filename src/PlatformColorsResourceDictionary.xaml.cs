namespace Maui.SystemColors
{
    public partial class PlatformColorsResourceDictionary
    {
        public PlatformColorsResourceDictionary()
        {
            InitializeComponent();

#if IOS || MACCATALYST

            this.Add($"Ios_{nameof(PlatformColors.SystemRed)}", PlatformColors.SystemRed);
            this.Add($"Ios_{nameof(PlatformColors.SystemOrange)}", PlatformColors.SystemOrange);
            this.Add($"Ios_{nameof(PlatformColors.SystemYellow)}", PlatformColors.SystemYellow);
            this.Add($"Ios_{nameof(PlatformColors.SystemGreen)}", PlatformColors.SystemGreen);
            this.Add($"Ios_{nameof(PlatformColors.SystemMint)}", PlatformColors.SystemMint);
            this.Add($"Ios_{nameof(PlatformColors.SystemTeal)}", PlatformColors.SystemTeal);
            this.Add($"Ios_{nameof(PlatformColors.SystemCyan)}", PlatformColors.SystemCyan);
            this.Add($"Ios_{nameof(PlatformColors.SystemBlue)}", PlatformColors.SystemBlue);
            this.Add($"Ios_{nameof(PlatformColors.SystemIndigo)}", PlatformColors.SystemIndigo);
            this.Add($"Ios_{nameof(PlatformColors.SystemPurple)}", PlatformColors.SystemPurple);
            this.Add($"Ios_{nameof(PlatformColors.SystemPink)}", PlatformColors.SystemPink);
            this.Add($"Ios_{nameof(PlatformColors.SystemBrown)}", PlatformColors.SystemBrown);
            this.Add($"Ios_{nameof(PlatformColors.SystemGray)}", PlatformColors.SystemGray);
            this.Add($"Ios_{nameof(PlatformColors.SystemGray2)}", PlatformColors.SystemGray2);
            this.Add($"Ios_{nameof(PlatformColors.SystemGray3)}", PlatformColors.SystemGray4);
            this.Add($"Ios_{nameof(PlatformColors.SystemGray4)}", PlatformColors.SystemGray4);
            this.Add($"Ios_{nameof(PlatformColors.SystemGray5)}", PlatformColors.SystemGray5);
            this.Add($"Ios_{nameof(PlatformColors.SystemGray6)}", PlatformColors.SystemGray6);
            this.Add($"Ios_{nameof(PlatformColors.SystemLabel)}", PlatformColors.SystemLabel);
            this.Add($"Ios_{nameof(PlatformColors.SecondaryLabel)}", PlatformColors.SecondaryLabel);
            this.Add($"Ios_{nameof(PlatformColors.TertiaryLabel)}", PlatformColors.TertiaryLabel);
            this.Add($"Ios_{nameof(PlatformColors.QuaternaryLabel)}", PlatformColors.QuaternaryLabel);
            this.Add($"Ios_{nameof(PlatformColors.Placeholder)}", PlatformColors.Placeholder);
            this.Add($"Ios_{nameof(PlatformColors.Separator)}", PlatformColors.Separator);
            this.Add($"Ios_{nameof(PlatformColors.OpaqueSeparator)}", PlatformColors.OpaqueSeparator);
            this.Add($"Ios_{nameof(PlatformColors.LinkColor)}", PlatformColors.LinkColor);
            this.Add($"Ios_{nameof(PlatformColors.FillColor)}", PlatformColors.FillColor);
            this.Add($"Ios_{nameof(PlatformColors.SecondaryFillColor)}", PlatformColors.SecondaryFillColor);
            this.Add($"Ios_{nameof(PlatformColors.TertiaryFillColor)}", PlatformColors.TertiaryFillColor);
            this.Add($"Ios_{nameof(PlatformColors.QuaternaryFillColor)}", PlatformColors.QuaternaryFillColor);
            this.Add($"Ios_{nameof(PlatformColors.SystemBackgroundColor)}", PlatformColors.SystemBackgroundColor);
            this.Add($"Ios_{nameof(PlatformColors.SecondarySystemBackgroundColor)}", PlatformColors.SecondarySystemBackgroundColor);
            this.Add($"Ios_{nameof(PlatformColors.TertiarySystemBackgroundColor)}", PlatformColors.TertiarySystemBackgroundColor);
            this.Add($"Ios_{nameof(PlatformColors.SystemGroupedBackgroundColor)}", PlatformColors.SystemGroupedBackgroundColor);
            this.Add($"Ios_{nameof(PlatformColors.SecondarySystemGroupedBackgroundColor)}", PlatformColors.SecondarySystemGroupedBackgroundColor);
            this.Add($"Ios_{nameof(PlatformColors.TertiarySystemGroupedBackgroundColor)}", PlatformColors.TertiarySystemGroupedBackgroundColor);
            this.Add($"Ios_{nameof(PlatformColors.DarkTextColor)}", PlatformColors.DarkTextColor);
            this.Add($"Ios_{nameof(PlatformColors.LightTextColor)}", PlatformColors.LightTextColor);
#endif
        }
    }
}

