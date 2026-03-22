//HintName: G.Models.PackagesDeletePackageVersionForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageVersionForAuthenticatedUserPackageType
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
    public static class PackagesDeletePackageVersionForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageVersionForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Container => "container",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Docker => "docker",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Maven => "maven",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Npm => "npm",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageVersionForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Container,
                "docker" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Docker,
                "maven" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Maven,
                "npm" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Npm,
                "nuget" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Nuget,
                "rubygems" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}