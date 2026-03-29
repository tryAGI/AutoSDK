//HintName: G.Models.ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Accents With Subject Verb Inversion
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion
    {
        /// <summary>
        /// 
        /// </summary>
        UseAcuteAccent,
        /// <summary>
        /// 
        /// </summary>
        UseGraveAccent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion.UseAcuteAccent => "use_acute_accent",
                ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion.UseGraveAccent => "use_grave_accent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion? ToEnum(string value)
        {
            return value switch
            {
                "use_acute_accent" => ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion.UseAcuteAccent,
                "use_grave_accent" => ConfiguredRulesSpellingAndGrammarAccentsWithSubjectVerbInversion.UseGraveAccent,
                _ => null,
            };
        }
    }
}