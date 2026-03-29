//HintName: G.Models.ConfiguredRulesPunctuationSlash.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Slash
    /// </summary>
    public enum ConfiguredRulesPunctuationSlash
    {
        /// <summary>
        /// 
        /// </summary>
        DoNotUseSpacesBeforeAndAfterSlashes,
        /// <summary>
        /// 
        /// </summary>
        UseSpacesBeforeAndAfterSlashes,
        /// <summary>
        /// 
        /// </summary>
        UseSpacesBeforeAndAfterSlashesIfThereAreMultipleWordsBeforeAndAfterSlash,
        /// <summary>
        /// 
        /// </summary>
        UseSpacesBeforeAndAfterSlashesIfThereAreMultipleWordsBeforeOrAfterSlash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationSlashExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationSlash value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationSlash.DoNotUseSpacesBeforeAndAfterSlashes => "do_not_use_spaces_before_and_after_slashes",
                ConfiguredRulesPunctuationSlash.UseSpacesBeforeAndAfterSlashes => "use_spaces_before_and_after_slashes",
                ConfiguredRulesPunctuationSlash.UseSpacesBeforeAndAfterSlashesIfThereAreMultipleWordsBeforeAndAfterSlash => "use_spaces_before_and_after_slashes_if_there_are_multiple_words_before_and_after_slash",
                ConfiguredRulesPunctuationSlash.UseSpacesBeforeAndAfterSlashesIfThereAreMultipleWordsBeforeOrAfterSlash => "use_spaces_before_and_after_slashes_if_there_are_multiple_words_before_or_after_slash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationSlash? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_spaces_before_and_after_slashes" => ConfiguredRulesPunctuationSlash.DoNotUseSpacesBeforeAndAfterSlashes,
                "use_spaces_before_and_after_slashes" => ConfiguredRulesPunctuationSlash.UseSpacesBeforeAndAfterSlashes,
                "use_spaces_before_and_after_slashes_if_there_are_multiple_words_before_and_after_slash" => ConfiguredRulesPunctuationSlash.UseSpacesBeforeAndAfterSlashesIfThereAreMultipleWordsBeforeAndAfterSlash,
                "use_spaces_before_and_after_slashes_if_there_are_multiple_words_before_or_after_slash" => ConfiguredRulesPunctuationSlash.UseSpacesBeforeAndAfterSlashesIfThereAreMultipleWordsBeforeOrAfterSlash,
                _ => null,
            };
        }
    }
}