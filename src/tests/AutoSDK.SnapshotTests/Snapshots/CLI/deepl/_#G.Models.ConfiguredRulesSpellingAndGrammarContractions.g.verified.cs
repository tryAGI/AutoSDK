//HintName: G.Models.ConfiguredRulesSpellingAndGrammarContractions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Contractions
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarContractions
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseContractions,
        /// <summary>
        /// 
        /// </summary>
        UseContractions,
        /// <summary>
        /// 
        /// </summary>
        UseContractionsButAvoidNegativeContractions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarContractionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarContractions value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarContractions.DoNotUseContractions => "do_not_use_contractions",
                ConfiguredRulesSpellingAndGrammarContractions.UseContractions => "use_contractions",
                ConfiguredRulesSpellingAndGrammarContractions.UseContractionsButAvoidNegativeContractions => "use_contractions_but_avoid_negative_contractions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarContractions? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_contractions" => ConfiguredRulesSpellingAndGrammarContractions.DoNotUseContractions,
                "use_contractions" => ConfiguredRulesSpellingAndGrammarContractions.UseContractions,
                "use_contractions_but_avoid_negative_contractions" => ConfiguredRulesSpellingAndGrammarContractions.UseContractionsButAvoidNegativeContractions,
                _ => null,
            };
        }
    }
}