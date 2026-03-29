//HintName: G.Models.ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for French Verbs Ending In Eler And Eter
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcribe_open_e_sound_by_doubling_next_consonant")]
        TranscribeOpenESoundByDoublingNextConsonant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcribe_open_e_sound_with_grave_accent")]
        TranscribeOpenESoundWithGraveAccent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter.TranscribeOpenESoundByDoublingNextConsonant => "transcribe_open_e_sound_by_doubling_next_consonant",
                ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter.TranscribeOpenESoundWithGraveAccent => "transcribe_open_e_sound_with_grave_accent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter? ToEnum(string value)
        {
            return value switch
            {
                "transcribe_open_e_sound_by_doubling_next_consonant" => ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter.TranscribeOpenESoundByDoublingNextConsonant,
                "transcribe_open_e_sound_with_grave_accent" => ConfiguredRulesSpellingAndGrammarFrenchVerbsEndingInElerAndEter.TranscribeOpenESoundWithGraveAccent,
                _ => null,
            };
        }
    }
}