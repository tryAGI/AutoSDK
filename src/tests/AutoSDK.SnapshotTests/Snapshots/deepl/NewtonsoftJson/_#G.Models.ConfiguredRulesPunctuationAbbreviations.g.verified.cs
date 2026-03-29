//HintName: G.Models.ConfiguredRulesPunctuationAbbreviations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Abbreviations
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationAbbreviations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_separate_abbreviated_words")]
        DoNotSeparateAbbreviatedWords,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="separate_each_abbreviated_word_with_period_and_space")]
        SeparateEachAbbreviatedWordWithPeriodAndSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="separate_each_abbreviated_word_with_period_without_space")]
        SeparateEachAbbreviatedWordWithPeriodWithoutSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="separate_each_abbreviated_word_with_space_without_period")]
        SeparateEachAbbreviatedWordWithSpaceWithoutPeriod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationAbbreviationsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationAbbreviations value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationAbbreviations.DoNotSeparateAbbreviatedWords => "do_not_separate_abbreviated_words",
                ConfiguredRulesPunctuationAbbreviations.SeparateEachAbbreviatedWordWithPeriodAndSpace => "separate_each_abbreviated_word_with_period_and_space",
                ConfiguredRulesPunctuationAbbreviations.SeparateEachAbbreviatedWordWithPeriodWithoutSpace => "separate_each_abbreviated_word_with_period_without_space",
                ConfiguredRulesPunctuationAbbreviations.SeparateEachAbbreviatedWordWithSpaceWithoutPeriod => "separate_each_abbreviated_word_with_space_without_period",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationAbbreviations? ToEnum(string value)
        {
            return value switch
            {
                "do_not_separate_abbreviated_words" => ConfiguredRulesPunctuationAbbreviations.DoNotSeparateAbbreviatedWords,
                "separate_each_abbreviated_word_with_period_and_space" => ConfiguredRulesPunctuationAbbreviations.SeparateEachAbbreviatedWordWithPeriodAndSpace,
                "separate_each_abbreviated_word_with_period_without_space" => ConfiguredRulesPunctuationAbbreviations.SeparateEachAbbreviatedWordWithPeriodWithoutSpace,
                "separate_each_abbreviated_word_with_space_without_period" => ConfiguredRulesPunctuationAbbreviations.SeparateEachAbbreviatedWordWithSpaceWithoutPeriod,
                _ => null,
            };
        }
    }
}