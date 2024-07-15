//HintName: G.Models.PackagesGetPackageForOrganizationPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesGetPackageForOrganizationPackageType
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
    public static class PackagesGetPackageForOrganizationPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageForOrganizationPackageType value)
        {
            return value switch
            {
                PackagesGetPackageForOrganizationPackageType.Npm => "npm",
                PackagesGetPackageForOrganizationPackageType.Maven => "maven",
                PackagesGetPackageForOrganizationPackageType.Rubygems => "rubygems",
                PackagesGetPackageForOrganizationPackageType.Docker => "docker",
                PackagesGetPackageForOrganizationPackageType.Nuget => "nuget",
                PackagesGetPackageForOrganizationPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageForOrganizationPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetPackageForOrganizationPackageType.Npm,
                "maven" => PackagesGetPackageForOrganizationPackageType.Maven,
                "rubygems" => PackagesGetPackageForOrganizationPackageType.Rubygems,
                "docker" => PackagesGetPackageForOrganizationPackageType.Docker,
                "nuget" => PackagesGetPackageForOrganizationPackageType.Nuget,
                "container" => PackagesGetPackageForOrganizationPackageType.Container,
                _ => null,
            };
        }
    }
}