//HintName: G.Models.ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Redundant Introductory Phrases
    /// </summary>
    public enum ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases
    {
        /// <summary>
        /// 
        /// </summary>
        AvoidRedundantIntroductoryPhrases,
        /// <summary>
        /// 
        /// </summary>
        DoNotUseRedundantPhrasesThatReferToCurrentText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneRedundantIntroductoryPhrasesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases.AvoidRedundantIntroductoryPhrases => "avoid_redundant_introductory_phrases",
                ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases.DoNotUseRedundantPhrasesThatReferToCurrentText => "do_not_use_redundant_phrases_that_refer_to_current_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases? ToEnum(string value)
        {
            return value switch
            {
                "avoid_redundant_introductory_phrases" => ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases.AvoidRedundantIntroductoryPhrases,
                "do_not_use_redundant_phrases_that_refer_to_current_text" => ConfiguredRulesStyleAndToneRedundantIntroductoryPhrases.DoNotUseRedundantPhrasesThatReferToCurrentText,
                _ => null,
            };
        }
    }
}