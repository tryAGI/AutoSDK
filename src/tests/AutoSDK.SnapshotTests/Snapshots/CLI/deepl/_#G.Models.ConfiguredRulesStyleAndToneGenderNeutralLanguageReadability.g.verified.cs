//HintName: G.Models.ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Gender Neutral Language Readability
    /// </summary>
    public enum ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability
    {
        /// <summary>
        /// 
        /// </summary>
        UseGenericMasculineForCommonCompoundNounsIfItIncreasesReadability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneGenderNeutralLanguageReadabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability.UseGenericMasculineForCommonCompoundNounsIfItIncreasesReadability => "use_generic_masculine_for_common_compound_nouns_if_it_increases_readability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability? ToEnum(string value)
        {
            return value switch
            {
                "use_generic_masculine_for_common_compound_nouns_if_it_increases_readability" => ConfiguredRulesStyleAndToneGenderNeutralLanguageReadability.UseGenericMasculineForCommonCompoundNounsIfItIncreasesReadability,
                _ => null,
            };
        }
    }
}