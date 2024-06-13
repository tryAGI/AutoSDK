//HintName: G.Models.BroadcasterSubscriptionTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of subscription. Possible values are:  <br/>
    ///   <br/>
    /// * 1000 — Tier 1<br/>
    /// * 2000 — Tier 2<br/>
    /// * 3000 — Tier 3
    /// </summary>
    public enum BroadcasterSubscriptionTier
    {
        /// <summary>
        /// 
        /// </summary>
        _1000,
        /// <summary>
        /// 
        /// </summary>
        _2000,
        /// <summary>
        /// 
        /// </summary>
        _3000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BroadcasterSubscriptionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BroadcasterSubscriptionTier value)
        {
            return value switch
            {
                BroadcasterSubscriptionTier._1000 => "1000",
                BroadcasterSubscriptionTier._2000 => "2000",
                BroadcasterSubscriptionTier._3000 => "3000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BroadcasterSubscriptionTier? ToEnum(string value)
        {
            return value switch
            {
                "1000" => BroadcasterSubscriptionTier._1000,
                "2000" => BroadcasterSubscriptionTier._2000,
                "3000" => BroadcasterSubscriptionTier._3000,
                _ => null,
            };
        }
    }
}