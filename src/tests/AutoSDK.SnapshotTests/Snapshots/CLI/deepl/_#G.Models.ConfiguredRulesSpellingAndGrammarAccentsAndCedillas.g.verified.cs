//HintName: G.Models.ConfiguredRulesSpellingAndGrammarAccentsAndCedillas.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Accents And Cedillas
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarAccentsAndCedillas
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseOnCapitalLetters,
        /// <summary>
        /// 
        /// </summary>
        NeverUse,
        /// <summary>
        /// 
        /// </summary>
        UseEvenOnCapitalLetters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarAccentsAndCedillasExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarAccentsAndCedillas value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarAccentsAndCedillas.DoNotUseOnCapitalLetters => "do_not_use_on_capital_letters",
                ConfiguredRulesSpellingAndGrammarAccentsAndCedillas.NeverUse => "never_use",
                ConfiguredRulesSpellingAndGrammarAccentsAndCedillas.UseEvenOnCapitalLetters => "use_even_on_capital_letters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarAccentsAndCedillas? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_on_capital_letters" => ConfiguredRulesSpellingAndGrammarAccentsAndCedillas.DoNotUseOnCapitalLetters,
                "never_use" => ConfiguredRulesSpellingAndGrammarAccentsAndCedillas.NeverUse,
                "use_even_on_capital_letters" => ConfiguredRulesSpellingAndGrammarAccentsAndCedillas.UseEvenOnCapitalLetters,
                _ => null,
            };
        }
    }
}