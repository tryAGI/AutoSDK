//HintName: G.Models.OrganizationTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationTier
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
    public static class OrganizationTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationTier value)
        {
            return value switch
            {
                OrganizationTier.NoPlan => "no_plan",
                OrganizationTier.Developer => "developer",
                OrganizationTier.Plus => "plus",
                OrganizationTier.Enterprise => "enterprise",
                OrganizationTier.DeveloperLegacy => "developer_legacy",
                OrganizationTier.PlusLegacy => "plus_legacy",
                OrganizationTier.Free => "free",
                OrganizationTier.EnterpriseLegacy => "enterprise_legacy",
                OrganizationTier.Startup => "startup",
                OrganizationTier.Partner => "partner",
                OrganizationTier.Premier => "premier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationTier? ToEnum(string value)
        {
            return value switch
            {
                "no_plan" => OrganizationTier.NoPlan,
                "developer" => OrganizationTier.Developer,
                "plus" => OrganizationTier.Plus,
                "enterprise" => OrganizationTier.Enterprise,
                "developer_legacy" => OrganizationTier.DeveloperLegacy,
                "plus_legacy" => OrganizationTier.PlusLegacy,
                "free" => OrganizationTier.Free,
                "enterprise_legacy" => OrganizationTier.EnterpriseLegacy,
                "startup" => OrganizationTier.Startup,
                "partner" => OrganizationTier.Partner,
                "premier" => OrganizationTier.Premier,
                _ => null,
            };
        }
    }
}