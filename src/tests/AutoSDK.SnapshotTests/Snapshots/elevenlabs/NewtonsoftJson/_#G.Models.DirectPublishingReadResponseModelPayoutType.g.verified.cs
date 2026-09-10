//HintName: G.Models.DirectPublishingReadResponseModelPayoutType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DirectPublishingReadResponseModelPayoutType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="engagement_based")]
        EngagementBased,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed_payout")]
        FixedPayout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectPublishingReadResponseModelPayoutTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelPayoutType value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelPayoutType.EngagementBased => "engagement_based",
                DirectPublishingReadResponseModelPayoutType.FixedPayout => "fixed_payout",
                DirectPublishingReadResponseModelPayoutType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectPublishingReadResponseModelPayoutType? ToEnum(string value)
        {
            return value switch
            {
                "engagement_based" => DirectPublishingReadResponseModelPayoutType.EngagementBased,
                "fixed_payout" => DirectPublishingReadResponseModelPayoutType.FixedPayout,
                "none" => DirectPublishingReadResponseModelPayoutType.None,
                _ => null,
            };
        }
    }
}