//HintName: G.Models.OrganizationTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrganizationTier
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