//HintName: G.Models.PendingSubscriptionSwitchResponseModelNextTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tier to change to.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PendingSubscriptionSwitchResponseModelNextTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="creator")]
        Creator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise")]
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="grant_tier_1_2025_07_23")]
        GrantTier120250723,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="grant_tier_2_2025_07_23")]
        GrantTier220250723,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="growing_business")]
        GrowingBusiness,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pro")]
        Pro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scale_2024_08_10")]
        Scale20240810,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starter")]
        Starter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trial")]
        Trial,
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
                PendingSubscriptionSwitchResponseModelNextTier.Creator => "creator",
                PendingSubscriptionSwitchResponseModelNextTier.Enterprise => "enterprise",
                PendingSubscriptionSwitchResponseModelNextTier.Free => "free",
                PendingSubscriptionSwitchResponseModelNextTier.GrantTier120250723 => "grant_tier_1_2025_07_23",
                PendingSubscriptionSwitchResponseModelNextTier.GrantTier220250723 => "grant_tier_2_2025_07_23",
                PendingSubscriptionSwitchResponseModelNextTier.GrowingBusiness => "growing_business",
                PendingSubscriptionSwitchResponseModelNextTier.Pro => "pro",
                PendingSubscriptionSwitchResponseModelNextTier.Scale20240810 => "scale_2024_08_10",
                PendingSubscriptionSwitchResponseModelNextTier.Starter => "starter",
                PendingSubscriptionSwitchResponseModelNextTier.Trial => "trial",
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
                "creator" => PendingSubscriptionSwitchResponseModelNextTier.Creator,
                "enterprise" => PendingSubscriptionSwitchResponseModelNextTier.Enterprise,
                "free" => PendingSubscriptionSwitchResponseModelNextTier.Free,
                "grant_tier_1_2025_07_23" => PendingSubscriptionSwitchResponseModelNextTier.GrantTier120250723,
                "grant_tier_2_2025_07_23" => PendingSubscriptionSwitchResponseModelNextTier.GrantTier220250723,
                "growing_business" => PendingSubscriptionSwitchResponseModelNextTier.GrowingBusiness,
                "pro" => PendingSubscriptionSwitchResponseModelNextTier.Pro,
                "scale_2024_08_10" => PendingSubscriptionSwitchResponseModelNextTier.Scale20240810,
                "starter" => PendingSubscriptionSwitchResponseModelNextTier.Starter,
                "trial" => PendingSubscriptionSwitchResponseModelNextTier.Trial,
                _ => null,
            };
        }
    }
}