//HintName: G.Models.OrganizationInfoTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationInfoTier
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
    public static class OrganizationInfoTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationInfoTier value)
        {
            return value switch
            {
                OrganizationInfoTier.NoPlan => "no_plan",
                OrganizationInfoTier.Developer => "developer",
                OrganizationInfoTier.Plus => "plus",
                OrganizationInfoTier.Enterprise => "enterprise",
                OrganizationInfoTier.DeveloperLegacy => "developer_legacy",
                OrganizationInfoTier.PlusLegacy => "plus_legacy",
                OrganizationInfoTier.Free => "free",
                OrganizationInfoTier.EnterpriseLegacy => "enterprise_legacy",
                OrganizationInfoTier.Startup => "startup",
                OrganizationInfoTier.Partner => "partner",
                OrganizationInfoTier.Premier => "premier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationInfoTier? ToEnum(string value)
        {
            return value switch
            {
                "no_plan" => OrganizationInfoTier.NoPlan,
                "developer" => OrganizationInfoTier.Developer,
                "plus" => OrganizationInfoTier.Plus,
                "enterprise" => OrganizationInfoTier.Enterprise,
                "developer_legacy" => OrganizationInfoTier.DeveloperLegacy,
                "plus_legacy" => OrganizationInfoTier.PlusLegacy,
                "free" => OrganizationInfoTier.Free,
                "enterprise_legacy" => OrganizationInfoTier.EnterpriseLegacy,
                "startup" => OrganizationInfoTier.Startup,
                "partner" => OrganizationInfoTier.Partner,
                "premier" => OrganizationInfoTier.Premier,
                _ => null,
            };
        }
    }
}