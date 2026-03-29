//HintName: G.Models.ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for I And U With Circumflex Accents
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_circumflex_accents_except_in_verbs_and_to_distinguish_homophones")]
        DoNotUseCircumflexAccentsExceptInVerbsAndToDistinguishHomophones,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_circumflex_accents")]
        UseCircumflexAccents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents.DoNotUseCircumflexAccentsExceptInVerbsAndToDistinguishHomophones => "do_not_use_circumflex_accents_except_in_verbs_and_to_distinguish_homophones",
                ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents.UseCircumflexAccents => "use_circumflex_accents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_circumflex_accents_except_in_verbs_and_to_distinguish_homophones" => ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents.DoNotUseCircumflexAccentsExceptInVerbsAndToDistinguishHomophones,
                "use_circumflex_accents" => ConfiguredRulesSpellingAndGrammarIAndUWithCircumflexAccents.UseCircumflexAccents,
                _ => null,
            };
        }
    }
}