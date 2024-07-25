//HintName: G.Models.OrganizationBillingInfoTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationBillingInfoTier
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
    public static class OrganizationBillingInfoTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationBillingInfoTier value)
        {
            return value switch
            {
                OrganizationBillingInfoTier.NoPlan => "no_plan",
                OrganizationBillingInfoTier.Developer => "developer",
                OrganizationBillingInfoTier.Plus => "plus",
                OrganizationBillingInfoTier.Enterprise => "enterprise",
                OrganizationBillingInfoTier.DeveloperLegacy => "developer_legacy",
                OrganizationBillingInfoTier.PlusLegacy => "plus_legacy",
                OrganizationBillingInfoTier.Free => "free",
                OrganizationBillingInfoTier.EnterpriseLegacy => "enterprise_legacy",
                OrganizationBillingInfoTier.Startup => "startup",
                OrganizationBillingInfoTier.Partner => "partner",
                OrganizationBillingInfoTier.Premier => "premier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationBillingInfoTier? ToEnum(string value)
        {
            return value switch
            {
                "no_plan" => OrganizationBillingInfoTier.NoPlan,
                "developer" => OrganizationBillingInfoTier.Developer,
                "plus" => OrganizationBillingInfoTier.Plus,
                "enterprise" => OrganizationBillingInfoTier.Enterprise,
                "developer_legacy" => OrganizationBillingInfoTier.DeveloperLegacy,
                "plus_legacy" => OrganizationBillingInfoTier.PlusLegacy,
                "free" => OrganizationBillingInfoTier.Free,
                "enterprise_legacy" => OrganizationBillingInfoTier.EnterpriseLegacy,
                "startup" => OrganizationBillingInfoTier.Startup,
                "partner" => OrganizationBillingInfoTier.Partner,
                "premier" => OrganizationBillingInfoTier.Premier,
                _ => null,
            };
        }
    }
}