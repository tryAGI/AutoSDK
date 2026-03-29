//HintName: G.Models.ConfiguredRulesPunctuationCommaAfterIEAndEG.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Comma After I E And E G
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationCommaAfterIEAndEG
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="do_not_use")]
        DoNotUse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="use")]
        Use,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfiguredRulesPunctuationCommaAfterIEAndEGExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationCommaAfterIEAndEG value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationCommaAfterIEAndEG.DoNotUse => "do_not_use",
                ConfiguredRulesPunctuationCommaAfterIEAndEG.Use => "use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationCommaAfterIEAndEG? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationCommaAfterIEAndEG.DoNotUse,
                "use" => ConfiguredRulesPunctuationCommaAfterIEAndEG.Use,
                _ => null,
            };
        }
    }
}