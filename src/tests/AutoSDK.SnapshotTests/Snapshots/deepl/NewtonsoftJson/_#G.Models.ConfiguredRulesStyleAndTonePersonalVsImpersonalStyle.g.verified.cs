//HintName: G.Models.ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Personal Vs Impersonal Style
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_impersonal_style")]
        UseImpersonalStyle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_personal_style")]
        UsePersonalStyle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndTonePersonalVsImpersonalStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle.UseImpersonalStyle => "use_impersonal_style",
                ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle.UsePersonalStyle => "use_personal_style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle? ToEnum(string value)
        {
            return value switch
            {
                "use_impersonal_style" => ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle.UseImpersonalStyle,
                "use_personal_style" => ConfiguredRulesStyleAndTonePersonalVsImpersonalStyle.UsePersonalStyle,
                _ => null,
            };
        }
    }
}