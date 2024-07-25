//HintName: G.Models.PaymentPlanTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PaymentPlanTier
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_plan")]
        NoPlan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plus")]
        Plus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise")]
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer_legacy")]
        DeveloperLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plus_legacy")]
        PlusLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise_legacy")]
        EnterpriseLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup")]
        Startup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partner")]
        Partner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premier")]
        Premier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PaymentPlanTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PaymentPlanTier value)
        {
            return value switch
            {
                PaymentPlanTier.NoPlan => "no_plan",
                PaymentPlanTier.Developer => "developer",
                PaymentPlanTier.Plus => "plus",
                PaymentPlanTier.Enterprise => "enterprise",
                PaymentPlanTier.DeveloperLegacy => "developer_legacy",
                PaymentPlanTier.PlusLegacy => "plus_legacy",
                PaymentPlanTier.Free => "free",
                PaymentPlanTier.EnterpriseLegacy => "enterprise_legacy",
                PaymentPlanTier.Startup => "startup",
                PaymentPlanTier.Partner => "partner",
                PaymentPlanTier.Premier => "premier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PaymentPlanTier? ToEnum(string value)
        {
            return value switch
            {
                "no_plan" => PaymentPlanTier.NoPlan,
                "developer" => PaymentPlanTier.Developer,
                "plus" => PaymentPlanTier.Plus,
                "enterprise" => PaymentPlanTier.Enterprise,
                "developer_legacy" => PaymentPlanTier.DeveloperLegacy,
                "plus_legacy" => PaymentPlanTier.PlusLegacy,
                "free" => PaymentPlanTier.Free,
                "enterprise_legacy" => PaymentPlanTier.EnterpriseLegacy,
                "startup" => PaymentPlanTier.Startup,
                "partner" => PaymentPlanTier.Partner,
                "premier" => PaymentPlanTier.Premier,
                _ => null,
            };
        }
    }
}