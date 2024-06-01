//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        Npm,
        /// <summary>
        /// 
        /// </summary>
        Maven,
        /// <summary>
        /// 
        /// </summary>
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        Docker,
        /// <summary>
        /// 
        /// </summary>
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        Container,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Rubygems => "rubygems",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Npm,
                "maven" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Maven,
                "rubygems" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Rubygems,
                "docker" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Docker,
                "nuget" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Nuget,
                "container" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}