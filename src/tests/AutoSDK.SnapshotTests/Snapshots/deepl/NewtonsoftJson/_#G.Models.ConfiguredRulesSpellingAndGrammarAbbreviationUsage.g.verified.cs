//HintName: G.Models.ConfiguredRulesSpellingAndGrammarAbbreviationUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Abbreviation Usage
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesSpellingAndGrammarAbbreviationUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_abbreviations")]
        DoNotUseAbbreviations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_abbreviations_unless_necessary")]
        DoNotUseAbbreviationsUnlessNecessary,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_abbreviations")]
        UseAbbreviations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_abbreviations_as_needed")]
        UseAbbreviationsAsNeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesSpellingAndGrammarAbbreviationUsageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesSpellingAndGrammarAbbreviationUsage value)
        {
            return value switch
            {
                ConfiguredRulesSpellingAndGrammarAbbreviationUsage.DoNotUseAbbreviations => "do_not_use_abbreviations",
                ConfiguredRulesSpellingAndGrammarAbbreviationUsage.DoNotUseAbbreviationsUnlessNecessary => "do_not_use_abbreviations_unless_necessary",
                ConfiguredRulesSpellingAndGrammarAbbreviationUsage.UseAbbreviations => "use_abbreviations",
                ConfiguredRulesSpellingAndGrammarAbbreviationUsage.UseAbbreviationsAsNeeded => "use_abbreviations_as_needed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesSpellingAndGrammarAbbreviationUsage? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_abbreviations" => ConfiguredRulesSpellingAndGrammarAbbreviationUsage.DoNotUseAbbreviations,
                "do_not_use_abbreviations_unless_necessary" => ConfiguredRulesSpellingAndGrammarAbbreviationUsage.DoNotUseAbbreviationsUnlessNecessary,
                "use_abbreviations" => ConfiguredRulesSpellingAndGrammarAbbreviationUsage.UseAbbreviations,
                "use_abbreviations_as_needed" => ConfiguredRulesSpellingAndGrammarAbbreviationUsage.UseAbbreviationsAsNeeded,
                _ => null,
            };
        }
    }
}