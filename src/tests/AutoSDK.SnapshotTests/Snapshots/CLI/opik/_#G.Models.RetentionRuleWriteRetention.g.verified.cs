//HintName: G.Models.RetentionRuleWriteRetention.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetentionRuleWriteRetention
    {
        /// <summary>
        /// 
        /// </summary>
        Base60d,
        /// <summary>
        /// 
        /// </summary>
        Extended400d,
        /// <summary>
        /// 
        /// </summary>
        Short14d,
        /// <summary>
        /// 
        /// </summary>
        Unlimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionRuleWriteRetentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionRuleWriteRetention value)
        {
            return value switch
            {
                RetentionRuleWriteRetention.Base60d => "base_60d",
                RetentionRuleWriteRetention.Extended400d => "extended_400d",
                RetentionRuleWriteRetention.Short14d => "short_14d",
                RetentionRuleWriteRetention.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionRuleWriteRetention? ToEnum(string value)
        {
            return value switch
            {
                "base_60d" => RetentionRuleWriteRetention.Base60d,
                "extended_400d" => RetentionRuleWriteRetention.Extended400d,
                "short_14d" => RetentionRuleWriteRetention.Short14d,
                "unlimited" => RetentionRuleWriteRetention.Unlimited,
                _ => null,
            };
        }
    }
}