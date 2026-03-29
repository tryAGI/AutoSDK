//HintName: G.Models.ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Default Second Person Pronoun
    /// </summary>
    public enum ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSecondPersonPronouns,
        /// <summary>
        /// 
        /// </summary>
        UseSecondPersonPronouns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneDefaultSecondPersonPronounExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun.DoNotUseSecondPersonPronouns => "do_not_use_second_person_pronouns",
                ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun.UseSecondPersonPronouns => "use_second_person_pronouns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_second_person_pronouns" => ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun.DoNotUseSecondPersonPronouns,
                "use_second_person_pronouns" => ConfiguredRulesStyleAndToneDefaultSecondPersonPronoun.UseSecondPersonPronouns,
                _ => null,
            };
        }
    }
}