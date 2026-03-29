//HintName: G.Models.ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Default First Person Pronoun
    /// </summary>
    public enum ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseFirstPersonPronouns,
        /// <summary>
        /// 
        /// </summary>
        OmitFirstPersonSubjectWhenClearFromContext,
        /// <summary>
        /// 
        /// </summary>
        UseFirstPersonPronouns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesStyleAndToneDefaultFirstPersonPronounExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun value)
        {
            return value switch
            {
                ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun.DoNotUseFirstPersonPronouns => "do_not_use_first_person_pronouns",
                ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun.OmitFirstPersonSubjectWhenClearFromContext => "omit_first_person_subject_when_clear_from_context",
                ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun.UseFirstPersonPronouns => "use_first_person_pronouns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_first_person_pronouns" => ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun.DoNotUseFirstPersonPronouns,
                "omit_first_person_subject_when_clear_from_context" => ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun.OmitFirstPersonSubjectWhenClearFromContext,
                "use_first_person_pronouns" => ConfiguredRulesStyleAndToneDefaultFirstPersonPronoun.UseFirstPersonPronouns,
                _ => null,
            };
        }
    }
}