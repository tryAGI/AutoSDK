//HintName: G.Models.ConfiguredRulesPunctuationAmpersandAbbreviationSpacing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Ampersand Abbreviation Spacing
    /// </summary>
    public enum ConfiguredRulesPunctuationAmpersandAbbreviationSpacing
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpacesBeforeAndAfterAmpersandAsPartOfAbbreviation,
        /// <summary>
        /// 
        /// </summary>
        UseSpacesBeforeAndAfterAmpersandAsPartOfAbbreviation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationAmpersandAbbreviationSpacingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationAmpersandAbbreviationSpacing value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationAmpersandAbbreviationSpacing.DoNotUseSpacesBeforeAndAfterAmpersandAsPartOfAbbreviation => "do_not_use_spaces_before_and_after_ampersand_as_part_of_abbreviation",
                ConfiguredRulesPunctuationAmpersandAbbreviationSpacing.UseSpacesBeforeAndAfterAmpersandAsPartOfAbbreviation => "use_spaces_before_and_after_ampersand_as_part_of_abbreviation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationAmpersandAbbreviationSpacing? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_spaces_before_and_after_ampersand_as_part_of_abbreviation" => ConfiguredRulesPunctuationAmpersandAbbreviationSpacing.DoNotUseSpacesBeforeAndAfterAmpersandAsPartOfAbbreviation,
                "use_spaces_before_and_after_ampersand_as_part_of_abbreviation" => ConfiguredRulesPunctuationAmpersandAbbreviationSpacing.UseSpacesBeforeAndAfterAmpersandAsPartOfAbbreviation,
                _ => null,
            };
        }
    }
}