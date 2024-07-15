//HintName: G.Models.PackagesDeletePackageForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageForAuthenticatedUserPackageType
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
    public static class PackagesDeletePackageForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForAuthenticatedUserPackageType.Npm => "npm",
                PackagesDeletePackageForAuthenticatedUserPackageType.Maven => "maven",
                PackagesDeletePackageForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesDeletePackageForAuthenticatedUserPackageType.Docker => "docker",
                PackagesDeletePackageForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesDeletePackageForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesDeletePackageForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesDeletePackageForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesDeletePackageForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesDeletePackageForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesDeletePackageForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesDeletePackageForAuthenticatedUserPackageType.Container,
                _ => null,
            };
        }
    }
}