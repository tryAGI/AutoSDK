//HintName: G.Models.PackagesListPackagesForOrganizationPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesListPackagesForOrganizationPackageType
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
    public static class PackagesListPackagesForOrganizationPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForOrganizationPackageType value)
        {
            return value switch
            {
                PackagesListPackagesForOrganizationPackageType.Npm => "npm",
                PackagesListPackagesForOrganizationPackageType.Maven => "maven",
                PackagesListPackagesForOrganizationPackageType.Rubygems => "rubygems",
                PackagesListPackagesForOrganizationPackageType.Docker => "docker",
                PackagesListPackagesForOrganizationPackageType.Nuget => "nuget",
                PackagesListPackagesForOrganizationPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesListPackagesForOrganizationPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesListPackagesForOrganizationPackageType.Npm,
                "maven" => PackagesListPackagesForOrganizationPackageType.Maven,
                "rubygems" => PackagesListPackagesForOrganizationPackageType.Rubygems,
                "docker" => PackagesListPackagesForOrganizationPackageType.Docker,
                "nuget" => PackagesListPackagesForOrganizationPackageType.Nuget,
                "container" => PackagesListPackagesForOrganizationPackageType.Container,
                _ => null,
            };
        }
    }
}