//HintName: G.Models.ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Gender Unspecified Or Mixed
    /// </summary>
    public enum ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed
    {
        /// <summary>
        /// 
        /// </summary>
        UseBothFeminineAndMasculineForms,
        /// <summary>
        /// 
        /// </summary>
        UseFeminineFormOnly,
        /// <summary>
        /// 
        /// </summary>
        UseInclusiveNounsAndAdjectives,
        /// <summary>
        /// 
        /// </summary>
        UseMasculineFormOnly,
        /// <summary>
        /// 
        /// </summary>
        UseNeutralNounsAndAdjectives,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseBothFeminineAndMasculineForms => "use_both_feminine_and_masculine_forms",
                ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseFeminineFormOnly => "use_feminine_form_only",
                ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseInclusiveNounsAndAdjectives => "use_inclusive_nouns_and_adjectives",
                ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseMasculineFormOnly => "use_masculine_form_only",
                ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseNeutralNounsAndAdjectives => "use_neutral_nouns_and_adjectives",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed? ToEnum(string value)
        {
            return value switch
            {
                "use_both_feminine_and_masculine_forms" => ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseBothFeminineAndMasculineForms,
                "use_feminine_form_only" => ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseFeminineFormOnly,
                "use_inclusive_nouns_and_adjectives" => ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseInclusiveNounsAndAdjectives,
                "use_masculine_form_only" => ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseMasculineFormOnly,
                "use_neutral_nouns_and_adjectives" => ConfiguredRulesStyleAndToneGenderUnspecifiedOrMixed.UseNeutralNounsAndAdjectives,
                _ => null,
            };
        }
    }
}