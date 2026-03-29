//HintName: G.Models.ConfiguredRulesPunctuationSpacingAndPunctuation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Spacing And Punctuation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationSpacingAndPunctuation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use_space")]
        DoNotUseSpace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use_regular_space")]
        UseRegularSpace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationSpacingAndPunctuationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationSpacingAndPunctuation value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationSpacingAndPunctuation.DoNotUseSpace => "do_not_use_space",
                ConfiguredRulesPunctuationSpacingAndPunctuation.UseRegularSpace => "use_regular_space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationSpacingAndPunctuation? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use_space" => ConfiguredRulesPunctuationSpacingAndPunctuation.DoNotUseSpace,
                "use_regular_space" => ConfiguredRulesPunctuationSpacingAndPunctuation.UseRegularSpace,
                _ => null,
            };
        }
    }
}