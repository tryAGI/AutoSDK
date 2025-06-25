//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType
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
    public static class PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm,
                "maven" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget,
                "container" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container,
                _ => null,
            };
        }
    }
}