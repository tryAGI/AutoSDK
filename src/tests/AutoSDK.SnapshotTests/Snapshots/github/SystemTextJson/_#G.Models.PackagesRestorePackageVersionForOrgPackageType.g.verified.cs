//HintName: G.Models.PackagesRestorePackageVersionForOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesRestorePackageVersionForOrgPackageType
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
    public static class PackagesRestorePackageVersionForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageVersionForOrgPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageVersionForOrgPackageType.Container => "container",
                PackagesRestorePackageVersionForOrgPackageType.Docker => "docker",
                PackagesRestorePackageVersionForOrgPackageType.Maven => "maven",
                PackagesRestorePackageVersionForOrgPackageType.Npm => "npm",
                PackagesRestorePackageVersionForOrgPackageType.Nuget => "nuget",
                PackagesRestorePackageVersionForOrgPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageVersionForOrgPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesRestorePackageVersionForOrgPackageType.Container,
                "docker" => PackagesRestorePackageVersionForOrgPackageType.Docker,
                "maven" => PackagesRestorePackageVersionForOrgPackageType.Maven,
                "npm" => PackagesRestorePackageVersionForOrgPackageType.Npm,
                "nuget" => PackagesRestorePackageVersionForOrgPackageType.Nuget,
                "rubygems" => PackagesRestorePackageVersionForOrgPackageType.Rubygems,
                _ => null,
            };
        }
    }
}