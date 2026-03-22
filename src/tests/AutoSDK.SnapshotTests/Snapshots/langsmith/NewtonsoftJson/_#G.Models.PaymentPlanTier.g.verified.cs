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
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer_legacy")]
        DeveloperLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise")]
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enterprise_legacy")]
        EnterpriseLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="free")]
        Free,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_plan")]
        NoPlan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partner")]
        Partner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plus")]
        Plus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plus_legacy")]
        PlusLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="premier")]
        Premier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startup")]
        Startup,
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
                PaymentPlanTier.Developer => "developer",
                PaymentPlanTier.DeveloperLegacy => "developer_legacy",
                PaymentPlanTier.Enterprise => "enterprise",
                PaymentPlanTier.EnterpriseLegacy => "enterprise_legacy",
                PaymentPlanTier.Free => "free",
                PaymentPlanTier.NoPlan => "no_plan",
                PaymentPlanTier.Partner => "partner",
                PaymentPlanTier.Plus => "plus",
                PaymentPlanTier.PlusLegacy => "plus_legacy",
                PaymentPlanTier.Premier => "premier",
                PaymentPlanTier.Startup => "startup",
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
                "developer" => PaymentPlanTier.Developer,
                "developer_legacy" => PaymentPlanTier.DeveloperLegacy,
                "enterprise" => PaymentPlanTier.Enterprise,
                "enterprise_legacy" => PaymentPlanTier.EnterpriseLegacy,
                "free" => PaymentPlanTier.Free,
                "no_plan" => PaymentPlanTier.NoPlan,
                "partner" => PaymentPlanTier.Partner,
                "plus" => PaymentPlanTier.Plus,
                "plus_legacy" => PaymentPlanTier.PlusLegacy,
                "premier" => PaymentPlanTier.Premier,
                "startup" => PaymentPlanTier.Startup,
                _ => null,
            };
        }
    }
}