//HintName: G.Models.PackagesDeletePackageVersionForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageVersionForUserPackageType
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
    public static class PackagesDeletePackageVersionForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageVersionForUserPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageVersionForUserPackageType.Container => "container",
                PackagesDeletePackageVersionForUserPackageType.Docker => "docker",
                PackagesDeletePackageVersionForUserPackageType.Maven => "maven",
                PackagesDeletePackageVersionForUserPackageType.Npm => "npm",
                PackagesDeletePackageVersionForUserPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageVersionForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesDeletePackageVersionForUserPackageType.Container,
                "docker" => PackagesDeletePackageVersionForUserPackageType.Docker,
                "maven" => PackagesDeletePackageVersionForUserPackageType.Maven,
                "npm" => PackagesDeletePackageVersionForUserPackageType.Npm,
                "nuget" => PackagesDeletePackageVersionForUserPackageType.Nuget,
                "rubygems" => PackagesDeletePackageVersionForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}