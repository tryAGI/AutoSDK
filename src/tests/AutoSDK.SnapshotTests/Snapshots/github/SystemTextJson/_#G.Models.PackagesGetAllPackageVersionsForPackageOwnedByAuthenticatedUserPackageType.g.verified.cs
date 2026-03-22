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
        Container,
        /// <summary>
        /// 
        /// </summary>
        Docker,
        /// <summary>
        /// 
        /// </summary>
        Maven,
        /// <summary>
        /// 
        /// </summary>
        Npm,
        /// <summary>
        /// 
        /// </summary>
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        Rubygems,
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
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container => "container",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems => "rubygems",
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
                "container" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container,
                "docker" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker,
                "maven" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven,
                "npm" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm,
                "nuget" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget,
                "rubygems" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}