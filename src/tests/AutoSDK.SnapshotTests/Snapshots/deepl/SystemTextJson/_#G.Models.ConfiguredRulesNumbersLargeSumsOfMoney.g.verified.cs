//HintName: G.Models.ConfiguredRulesNumbersLargeSumsOfMoney.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Large Sums Of Money
    /// </summary>
    public enum ConfiguredRulesNumbersLargeSumsOfMoney
    {
        /// <summary>
        /// 
        /// </summary>
        SpellOutItalianWordsMilioneAndMiliardo,
        /// <summary>
        /// 
        /// </summary>
        UseItalianWordsMioAndMrdInsteadOfItalianWordsMilioneAndMiliardo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesNumbersLargeSumsOfMoneyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesNumbersLargeSumsOfMoney value)
        {
            return value switch
            {
                ConfiguredRulesNumbersLargeSumsOfMoney.SpellOutItalianWordsMilioneAndMiliardo => "spell_out_italian_words_milione_and_miliardo",
                ConfiguredRulesNumbersLargeSumsOfMoney.UseItalianWordsMioAndMrdInsteadOfItalianWordsMilioneAndMiliardo => "use_italian_words_mio_and_mrd_instead_of_italian_words_milione_and_miliardo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesNumbersLargeSumsOfMoney? ToEnum(string value)
        {
            return value switch
            {
                "spell_out_italian_words_milione_and_miliardo" => ConfiguredRulesNumbersLargeSumsOfMoney.SpellOutItalianWordsMilioneAndMiliardo,
                "use_italian_words_mio_and_mrd_instead_of_italian_words_milione_and_miliardo" => ConfiguredRulesNumbersLargeSumsOfMoney.UseItalianWordsMioAndMrdInsteadOfItalianWordsMilioneAndMiliardo,
                _ => null,
            };
        }
    }
}