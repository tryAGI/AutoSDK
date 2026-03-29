//HintName: G.Models.ConfiguredRulesStyleAndToneMixingStyles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Mixing Styles
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesStyleAndToneMixingStyles
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_mix_desu_masu_style_and_dearu_style")]
        DoNotMixDesuMasuStyleAndDearuStyle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneMixingStylesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneMixingStyles value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneMixingStyles.DoNotMixDesuMasuStyleAndDearuStyle => "do_not_mix_desu_masu_style_and_dearu_style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneMixingStyles? ToEnum(string value)
        {
            return value switch
            {
                "do_not_mix_desu_masu_style_and_dearu_style" => ConfiguredRulesStyleAndToneMixingStyles.DoNotMixDesuMasuStyleAndDearuStyle,
                _ => null,
            };
        }
    }
}