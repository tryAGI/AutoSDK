//HintName: G.Models.PackagesGetPackageVersionForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesGetPackageVersionForUserPackageType
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
    public static class PackagesGetPackageVersionForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageVersionForUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageVersionForUserPackageType.Npm => "npm",
                PackagesGetPackageVersionForUserPackageType.Maven => "maven",
                PackagesGetPackageVersionForUserPackageType.Rubygems => "rubygems",
                PackagesGetPackageVersionForUserPackageType.Docker => "docker",
                PackagesGetPackageVersionForUserPackageType.Nuget => "nuget",
                PackagesGetPackageVersionForUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageVersionForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetPackageVersionForUserPackageType.Npm,
                "maven" => PackagesGetPackageVersionForUserPackageType.Maven,
                "rubygems" => PackagesGetPackageVersionForUserPackageType.Rubygems,
                "docker" => PackagesGetPackageVersionForUserPackageType.Docker,
                "nuget" => PackagesGetPackageVersionForUserPackageType.Nuget,
                "container" => PackagesGetPackageVersionForUserPackageType.Container,
                _ => null,
            };
        }
    }
}