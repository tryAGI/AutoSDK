//HintName: G.Models.ConfiguredRulesStyleAndToneAbbreviations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Abbreviations
    /// </summary>
    public enum ConfiguredRulesStyleAndToneAbbreviations
    {
        /// <summary>
        /// 
        /// </summary>
        AvoidAbbreviationsAndSymbolsThatCanBeSpelledOutEasily,
        /// <summary>
        /// 
        /// </summary>
        UseAbbreviationsAndSymbols,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneAbbreviationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneAbbreviations value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneAbbreviations.AvoidAbbreviationsAndSymbolsThatCanBeSpelledOutEasily => "avoid_abbreviations_and_symbols_that_can_be_spelled_out_easily",
                ConfiguredRulesStyleAndToneAbbreviations.UseAbbreviationsAndSymbols => "use_abbreviations_and_symbols",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneAbbreviations? ToEnum(string value)
        {
            return value switch
            {
                "avoid_abbreviations_and_symbols_that_can_be_spelled_out_easily" => ConfiguredRulesStyleAndToneAbbreviations.AvoidAbbreviationsAndSymbolsThatCanBeSpelledOutEasily,
                "use_abbreviations_and_symbols" => ConfiguredRulesStyleAndToneAbbreviations.UseAbbreviationsAndSymbols,
                _ => null,
            };
        }
    }
}