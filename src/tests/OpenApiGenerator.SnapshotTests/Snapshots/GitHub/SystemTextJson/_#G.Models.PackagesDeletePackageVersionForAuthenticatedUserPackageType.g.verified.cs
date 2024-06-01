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
    public static class PackagesDeletePackageVersionForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageVersionForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Npm => "npm",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Maven => "maven",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Docker => "docker",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageVersionForAuthenticatedUserPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesDeletePackageVersionForAuthenticatedUserPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}