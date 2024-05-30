//HintName: G.Models.BroadcasterSubscriptionTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of subscription. Possible values are:  
    ///   
    /// * 1000 — Tier 1
    /// * 2000 — Tier 2
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

    public static class BroadcasterSubscriptionTierExtensions
    {
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
        public static BroadcasterSubscriptionTier ToEnum(string value)
        {
            return value switch
            {
                "1000" => BroadcasterSubscriptionTier._1000,
                "2000" => BroadcasterSubscriptionTier._2000,
                "3000" => BroadcasterSubscriptionTier._3000,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static BroadcasterSubscriptionTier ToEnum(int value)
        {
            return value switch
            {
                0 => BroadcasterSubscriptionTier._1000,
                1 => BroadcasterSubscriptionTier._2000,
                2 => BroadcasterSubscriptionTier._3000,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}