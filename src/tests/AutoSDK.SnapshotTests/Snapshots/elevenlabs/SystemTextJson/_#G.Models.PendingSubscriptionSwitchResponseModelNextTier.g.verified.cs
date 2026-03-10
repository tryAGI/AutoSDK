//HintName: G.Models.PendingSubscriptionSwitchResponseModelNextTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tier to change to.
    /// </summary>
    public enum PendingSubscriptionSwitchResponseModelNextTier
    {
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Starter,
        /// <summary>
        /// 
        /// </summary>
        Creator,
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        GrowingBusiness,
        /// <summary>
        /// 
        /// </summary>
        Scale20240810,
        /// <summary>
        /// 
        /// </summary>
        GrantTier120250723,
        /// <summary>
        /// 
        /// </summary>
        GrantTier220250723,
        /// <summary>
        /// 
        /// </summary>
        Trial,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PendingSubscriptionSwitchResponseModelNextTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PendingSubscriptionSwitchResponseModelNextTier value)
        {
            return value switch
            {
                PendingSubscriptionSwitchResponseModelNextTier.Free => "free",
                PendingSubscriptionSwitchResponseModelNextTier.Starter => "starter",
                PendingSubscriptionSwitchResponseModelNextTier.Creator => "creator",
                PendingSubscriptionSwitchResponseModelNextTier.Pro => "pro",
                PendingSubscriptionSwitchResponseModelNextTier.GrowingBusiness => "growing_business",
                PendingSubscriptionSwitchResponseModelNextTier.Scale20240810 => "scale_2024_08_10",
                PendingSubscriptionSwitchResponseModelNextTier.GrantTier120250723 => "grant_tier_1_2025_07_23",
                PendingSubscriptionSwitchResponseModelNextTier.GrantTier220250723 => "grant_tier_2_2025_07_23",
                PendingSubscriptionSwitchResponseModelNextTier.Trial => "trial",
                PendingSubscriptionSwitchResponseModelNextTier.Enterprise => "enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PendingSubscriptionSwitchResponseModelNextTier? ToEnum(string value)
        {
            return value switch
            {
                "free" => PendingSubscriptionSwitchResponseModelNextTier.Free,
                "starter" => PendingSubscriptionSwitchResponseModelNextTier.Starter,
                "creator" => PendingSubscriptionSwitchResponseModelNextTier.Creator,
                "pro" => PendingSubscriptionSwitchResponseModelNextTier.Pro,
                "growing_business" => PendingSubscriptionSwitchResponseModelNextTier.GrowingBusiness,
                "scale_2024_08_10" => PendingSubscriptionSwitchResponseModelNextTier.Scale20240810,
                "grant_tier_1_2025_07_23" => PendingSubscriptionSwitchResponseModelNextTier.GrantTier120250723,
                "grant_tier_2_2025_07_23" => PendingSubscriptionSwitchResponseModelNextTier.GrantTier220250723,
                "trial" => PendingSubscriptionSwitchResponseModelNextTier.Trial,
                "enterprise" => PendingSubscriptionSwitchResponseModelNextTier.Enterprise,
                _ => null,
            };
        }
    }
}