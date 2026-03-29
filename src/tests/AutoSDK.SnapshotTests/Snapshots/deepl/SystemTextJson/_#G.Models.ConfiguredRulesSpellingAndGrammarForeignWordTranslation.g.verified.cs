//HintName: G.Models.ConfiguredRulesSpellingAndGrammarForeignWordTranslation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Foreign Word Translation
    /// </summary>
    public enum ConfiguredRulesSpellingAndGrammarForeignWordTranslation
    {
        /// <summary>
        /// 
        /// </summary>
        UseEquivalentExpressionsInChinese,
        /// <summary>
        /// 
        /// </summary>
        UseForeignFormsOrAbbreviationsForTechnicalTermsOrBrandNames,
        /// <summary>
        /// 
        /// </summary>
        UseLiteralTranslation,
        /// <summary>
        /// 
        /// </summary>
        UseLocalizedNamesForBrandsWithOfficialChineseTranslations,
        /// <summary>
        /// 
        /// </summary>
        UseMixtureOfTransliterationAndTranslation,
        /// <summary>
        /// 
        /// </summary>
        UseTransliteration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarForeignWordTranslationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarForeignWordTranslation value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseEquivalentExpressionsInChinese => "use_equivalent_expressions_in_chinese",
                ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseForeignFormsOrAbbreviationsForTechnicalTermsOrBrandNames => "use_foreign_forms_or_abbreviations_for_technical_terms_or_brand_names",
                ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseLiteralTranslation => "use_literal_translation",
                ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseLocalizedNamesForBrandsWithOfficialChineseTranslations => "use_localized_names_for_brands_with_official_chinese_translations",
                ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseMixtureOfTransliterationAndTranslation => "use_mixture_of_transliteration_and_translation",
                ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseTransliteration => "use_transliteration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarForeignWordTranslation? ToEnum(string value)
        {
            return value switch
            {
                "use_equivalent_expressions_in_chinese" => ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseEquivalentExpressionsInChinese,
                "use_foreign_forms_or_abbreviations_for_technical_terms_or_brand_names" => ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseForeignFormsOrAbbreviationsForTechnicalTermsOrBrandNames,
                "use_literal_translation" => ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseLiteralTranslation,
                "use_localized_names_for_brands_with_official_chinese_translations" => ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseLocalizedNamesForBrandsWithOfficialChineseTranslations,
                "use_mixture_of_transliteration_and_translation" => ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseMixtureOfTransliterationAndTranslation,
                "use_transliteration" => ConfiguredRulesSpellingAndGrammarForeignWordTranslation.UseTransliteration,
                _ => null,
            };
        }
    }
}