//HintName: G.Models.OrganizationInfoTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationInfoTier
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