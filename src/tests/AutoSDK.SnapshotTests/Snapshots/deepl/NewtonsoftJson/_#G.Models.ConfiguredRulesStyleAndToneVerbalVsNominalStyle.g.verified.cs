//HintName: G.Models.ConfiguredRulesStyleAndToneVerbalVsNominalStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Verbal Vs Nominal Style
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneVerbalVsNominalStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_nominal_style")]
        UseNominalStyle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_verbal_style")]
        UseVerbalStyle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneVerbalVsNominalStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneVerbalVsNominalStyle value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneVerbalVsNominalStyle.UseNominalStyle => "use_nominal_style",
                ConfiguredRulesStyleAndToneVerbalVsNominalStyle.UseVerbalStyle => "use_verbal_style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneVerbalVsNominalStyle? ToEnum(string value)
        {
            return value switch
            {
                "use_nominal_style" => ConfiguredRulesStyleAndToneVerbalVsNominalStyle.UseNominalStyle,
                "use_verbal_style" => ConfiguredRulesStyleAndToneVerbalVsNominalStyle.UseVerbalStyle,
                _ => null,
            };
        }
    }
}