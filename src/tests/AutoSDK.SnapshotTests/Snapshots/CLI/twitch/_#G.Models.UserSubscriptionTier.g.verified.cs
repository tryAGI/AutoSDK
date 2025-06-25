//HintName: G.Models.UserSubscriptionTier.g.cs

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
    public enum UserSubscriptionTier
    {
        /// <summary>
        /// 
        /// </summary>
        x1000,
        /// <summary>
        /// 
        /// </summary>
        x2000,
        /// <summary>
        /// 
        /// </summary>
        x3000,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserSubscriptionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserSubscriptionTier value)
        {
            return value switch
            {
                UserSubscriptionTier.x1000 => "1000",
                UserSubscriptionTier.x2000 => "2000",
                UserSubscriptionTier.x3000 => "3000",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserSubscriptionTier? ToEnum(string value)
        {
            return value switch
            {
                "1000" => UserSubscriptionTier.x1000,
                "2000" => UserSubscriptionTier.x2000,
                "3000" => UserSubscriptionTier.x3000,
                _ => null,
            };
        }
    }
}