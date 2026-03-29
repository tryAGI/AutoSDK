//HintName: G.Models.ConfiguredRulesPunctuationExclamationMarks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Exclamation Marks
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationExclamationMarks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use")]
        DoNotUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationExclamationMarksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationExclamationMarks value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationExclamationMarks.DoNotUse => "do_not_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationExclamationMarks? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationExclamationMarks.DoNotUse,
                _ => null,
            };
        }
    }
}