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
    public static class PackagesListPackagesForOrganizationPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesListPackagesForOrganizationPackageType value)
        {
            return value switch
            {
                PackagesListPackagesForOrganizationPackageType.Container => "container",
                PackagesListPackagesForOrganizationPackageType.Docker => "docker",
                PackagesListPackagesForOrganizationPackageType.Maven => "maven",
                PackagesListPackagesForOrganizationPackageType.Npm => "npm",
                PackagesListPackagesForOrganizationPackageType.Nuget => "nuget",
                PackagesListPackagesForOrganizationPackageType.Rubygems => "rubygems",
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
                "container" => PackagesListPackagesForOrganizationPackageType.Container,
                "docker" => PackagesListPackagesForOrganizationPackageType.Docker,
                "maven" => PackagesListPackagesForOrganizationPackageType.Maven,
                "npm" => PackagesListPackagesForOrganizationPackageType.Npm,
                "nuget" => PackagesListPackagesForOrganizationPackageType.Nuget,
                "rubygems" => PackagesListPackagesForOrganizationPackageType.Rubygems,
                _ => null,
            };
        }
    }
}