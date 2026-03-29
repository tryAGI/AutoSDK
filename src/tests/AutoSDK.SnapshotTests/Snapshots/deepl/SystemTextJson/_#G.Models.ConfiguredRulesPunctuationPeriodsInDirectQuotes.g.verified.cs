//HintName: G.Models.ConfiguredRulesPunctuationPeriodsInDirectQuotes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Periods In Direct Quotes
    /// </summary>
    public enum ConfiguredRulesPunctuationPeriodsInDirectQuotes
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUse,
        /// <summary>
        /// 
        /// </summary>
        Use,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationPeriodsInDirectQuotesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationPeriodsInDirectQuotes value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationPeriodsInDirectQuotes.DoNotUse => "do_not_use",
                ConfiguredRulesPunctuationPeriodsInDirectQuotes.Use => "use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationPeriodsInDirectQuotes? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationPeriodsInDirectQuotes.DoNotUse,
                "use" => ConfiguredRulesPunctuationPeriodsInDirectQuotes.Use,
                _ => null,
            };
        }
    }
}