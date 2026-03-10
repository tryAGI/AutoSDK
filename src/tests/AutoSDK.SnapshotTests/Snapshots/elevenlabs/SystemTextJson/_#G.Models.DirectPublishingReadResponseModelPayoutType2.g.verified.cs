//HintName: G.Models.DirectPublishingReadResponseModelPayoutType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectPublishingReadResponseModelPayoutType2
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        EngagementBased,
        /// <summary>
        /// 
        /// </summary>
        FixedPayout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectPublishingReadResponseModelPayoutType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectPublishingReadResponseModelPayoutType2 value)
        {
            return value switch
            {
                DirectPublishingReadResponseModelPayoutType2.None => "none",
                DirectPublishingReadResponseModelPayoutType2.EngagementBased => "engagement_based",
                DirectPublishingReadResponseModelPayoutType2.FixedPayout => "fixed_payout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectPublishingReadResponseModelPayoutType2? ToEnum(string value)
        {
            return value switch
            {
                "none" => DirectPublishingReadResponseModelPayoutType2.None,
                "engagement_based" => DirectPublishingReadResponseModelPayoutType2.EngagementBased,
                "fixed_payout" => DirectPublishingReadResponseModelPayoutType2.FixedPayout,
                _ => null,
            };
        }
    }
}