//HintName: G.Models.PackagesGetPackageVersionForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesGetPackageVersionForAuthenticatedUserPackageType
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
    public static class PackagesGetPackageVersionForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageVersionForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageVersionForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Container,
                _ => null,
            };
        }
    }
}