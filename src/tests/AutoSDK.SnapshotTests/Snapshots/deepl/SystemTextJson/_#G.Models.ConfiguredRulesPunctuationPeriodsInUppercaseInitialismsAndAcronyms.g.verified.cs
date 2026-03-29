//HintName: G.Models.ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Periods In Uppercase Initialisms And Acronyms
    /// </summary>
    public enum ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronymsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms.DoNotUse => "do_not_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationPeriodsInUppercaseInitialismsAndAcronyms.DoNotUse,
                _ => null,
            };
        }
    }
}