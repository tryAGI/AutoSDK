//HintName: G.Models.PaymentPlanTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PaymentPlanTier
    {
        /// <summary>
        /// 
        /// </summary>
        NoPlan,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        DeveloperLegacy,
        /// <summary>
        /// 
        /// </summary>
        PlusLegacy,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseLegacy,
        /// <summary>
        /// 
        /// </summary>
        Startup,
        /// <summary>
        /// 
        /// </summary>
        Partner,
        /// <summary>
        /// 
        /// </summary>
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