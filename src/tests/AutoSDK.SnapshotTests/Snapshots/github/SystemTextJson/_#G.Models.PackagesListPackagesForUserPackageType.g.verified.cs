//HintName: G.Models.PackagesListPackagesForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesListPackagesForUserPackageType
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
    public static class PackagesListPackagesForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForUserPackageType value)
        {
            return value switch
            {
                PackagesListPackagesForUserPackageType.Container => "container",
                PackagesListPackagesForUserPackageType.Docker => "docker",
                PackagesListPackagesForUserPackageType.Maven => "maven",
                PackagesListPackagesForUserPackageType.Npm => "npm",
                PackagesListPackagesForUserPackageType.Nuget => "nuget",
                PackagesListPackagesForUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesListPackagesForUserPackageType.Container,
                "docker" => PackagesListPackagesForUserPackageType.Docker,
                "maven" => PackagesListPackagesForUserPackageType.Maven,
                "npm" => PackagesListPackagesForUserPackageType.Npm,
                "nuget" => PackagesListPackagesForUserPackageType.Nuget,
                "rubygems" => PackagesListPackagesForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}