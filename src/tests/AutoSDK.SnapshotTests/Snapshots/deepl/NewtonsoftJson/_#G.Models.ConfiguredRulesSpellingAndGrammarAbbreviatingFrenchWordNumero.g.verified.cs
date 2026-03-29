//HintName: G.Models.ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Abbreviating French Word Numero
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="abbreviate_as_n_then_degree_symbol")]
        AbbreviateAsNThenDegreeSymbol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="abbreviate_as_n_then_o_in_superscript")]
        AbbreviateAsNThenOInSuperscript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="abbreviate_as_no")]
        AbbreviateAsNo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumeroExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero.AbbreviateAsNThenDegreeSymbol => "abbreviate_as_n_then_degree_symbol",
                ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero.AbbreviateAsNThenOInSuperscript => "abbreviate_as_n_then_o_in_superscript",
                ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero.AbbreviateAsNo => "abbreviate_as_no",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero? ToEnum(string value)
        {
            return value switch
            {
                "abbreviate_as_n_then_degree_symbol" => ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero.AbbreviateAsNThenDegreeSymbol,
                "abbreviate_as_n_then_o_in_superscript" => ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero.AbbreviateAsNThenOInSuperscript,
                "abbreviate_as_no" => ConfiguredRulesSpellingAndGrammarAbbreviatingFrenchWordNumero.AbbreviateAsNo,
                _ => null,
            };
        }
    }
}