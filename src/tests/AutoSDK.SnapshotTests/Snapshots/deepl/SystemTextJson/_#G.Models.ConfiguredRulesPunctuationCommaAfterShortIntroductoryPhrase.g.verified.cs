//HintName: G.Models.ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Comma After Short Introductory Phrase
    /// </summary>
    public enum ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase
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
    public static class ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhraseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase.DoNotUse => "do_not_use",
                ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase.Use => "use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase.DoNotUse,
                "use" => ConfiguredRulesPunctuationCommaAfterShortIntroductoryPhrase.Use,
                _ => null,
            };
        }
    }
}