//HintName: G.Models.ConfiguredRulesStyleAndToneRedundantPhrases.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Redundant Phrases
    /// </summary>
    public enum ConfiguredRulesStyleAndToneRedundantPhrases
    {
        /// <summary>
        /// 
        /// </summary>
        AvoidRelativizingAndRedundantPhrases,
        /// <summary>
        /// 
        /// </summary>
        DoNotUseRedundantPhrases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneRedundantPhrasesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneRedundantPhrases value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneRedundantPhrases.AvoidRelativizingAndRedundantPhrases => "avoid_relativizing_and_redundant_phrases",
                ConfiguredRulesStyleAndToneRedundantPhrases.DoNotUseRedundantPhrases => "do_not_use_redundant_phrases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneRedundantPhrases? ToEnum(string value)
        {
            return value switch
            {
                "avoid_relativizing_and_redundant_phrases" => ConfiguredRulesStyleAndToneRedundantPhrases.AvoidRelativizingAndRedundantPhrases,
                "do_not_use_redundant_phrases" => ConfiguredRulesStyleAndToneRedundantPhrases.DoNotUseRedundantPhrases,
                _ => null,
            };
        }
    }
}