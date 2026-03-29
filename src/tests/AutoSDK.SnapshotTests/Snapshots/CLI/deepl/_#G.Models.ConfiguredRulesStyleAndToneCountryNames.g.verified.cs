//HintName: G.Models.ConfiguredRulesStyleAndToneCountryNames.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Country Names
    /// </summary>
    public enum ConfiguredRulesStyleAndToneCountryNames
    {
        /// <summary>
        /// 
        /// </summary>
        UseLongForm,
        /// <summary>
        /// 
        /// </summary>
        UseShortForm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneCountryNamesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneCountryNames value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneCountryNames.UseLongForm => "use_long_form",
                ConfiguredRulesStyleAndToneCountryNames.UseShortForm => "use_short_form",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneCountryNames? ToEnum(string value)
        {
            return value switch
            {
                "use_long_form" => ConfiguredRulesStyleAndToneCountryNames.UseLongForm,
                "use_short_form" => ConfiguredRulesStyleAndToneCountryNames.UseShortForm,
                _ => null,
            };
        }
    }
}