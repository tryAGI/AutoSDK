//HintName: G.Models.PackagesGetPackageForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesGetPackageForAuthenticatedUserPackageType
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
    public static class PackagesGetPackageForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageForAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetPackageForAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetPackageForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesGetPackageForAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetPackageForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetPackageForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageForAuthenticatedUserPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetPackageForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesGetPackageForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesGetPackageForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesGetPackageForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesGetPackageForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesGetPackageForAuthenticatedUserPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}