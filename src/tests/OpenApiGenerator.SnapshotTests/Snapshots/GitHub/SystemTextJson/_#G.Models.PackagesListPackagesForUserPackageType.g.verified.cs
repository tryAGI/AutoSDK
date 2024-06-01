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
    public static class PackagesListPackagesForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForUserPackageType value)
        {
            return value switch
            {
                PackagesListPackagesForUserPackageType.Npm => "npm",
                PackagesListPackagesForUserPackageType.Maven => "maven",
                PackagesListPackagesForUserPackageType.Rubygems => "rubygems",
                PackagesListPackagesForUserPackageType.Docker => "docker",
                PackagesListPackagesForUserPackageType.Nuget => "nuget",
                PackagesListPackagesForUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForUserPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesListPackagesForUserPackageType.Npm,
                "maven" => PackagesListPackagesForUserPackageType.Maven,
                "rubygems" => PackagesListPackagesForUserPackageType.Rubygems,
                "docker" => PackagesListPackagesForUserPackageType.Docker,
                "nuget" => PackagesListPackagesForUserPackageType.Nuget,
                "container" => PackagesListPackagesForUserPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}