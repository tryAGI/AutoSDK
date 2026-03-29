//HintName: G.Models.RetentionRulePublicRetention.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetentionRulePublicRetention
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base_60d")]
        Base60d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="extended_400d")]
        Extended400d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="short_14d")]
        Short14d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unlimited")]
        Unlimited,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionRulePublicRetentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionRulePublicRetention value)
        {
            return value switch
            {
                RetentionRulePublicRetention.Base60d => "base_60d",
                RetentionRulePublicRetention.Extended400d => "extended_400d",
                RetentionRulePublicRetention.Short14d => "short_14d",
                RetentionRulePublicRetention.Unlimited => "unlimited",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionRulePublicRetention? ToEnum(string value)
        {
            return value switch
            {
                "base_60d" => RetentionRulePublicRetention.Base60d,
                "extended_400d" => RetentionRulePublicRetention.Extended400d,
                "short_14d" => RetentionRulePublicRetention.Short14d,
                "unlimited" => RetentionRulePublicRetention.Unlimited,
                _ => null,
            };
        }
    }
}