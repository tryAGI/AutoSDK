//HintName: G.Models.ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting options for Comma After Conjunctive Adverbs
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs
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
    public static class ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs value)
        {
            return value switch
            {
                ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs.DoNotUse => "do_not_use",
                ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs.Use => "use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs? ToEnum(string value)
        {
            return value switch
            {
                "do_not_use" => ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs.DoNotUse,
                "use" => ConfiguredRulesPunctuationCommaAfterConjunctiveAdverbs.Use,
                _ => null,
            };
        }
    }
}