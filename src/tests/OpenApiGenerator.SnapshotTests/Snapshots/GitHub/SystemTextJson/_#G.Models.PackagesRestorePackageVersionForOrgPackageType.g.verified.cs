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
    public static class PackagesRestorePackageVersionForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageVersionForOrgPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageVersionForOrgPackageType.Npm => "npm",
                PackagesRestorePackageVersionForOrgPackageType.Maven => "maven",
                PackagesRestorePackageVersionForOrgPackageType.Rubygems => "rubygems",
                PackagesRestorePackageVersionForOrgPackageType.Docker => "docker",
                PackagesRestorePackageVersionForOrgPackageType.Nuget => "nuget",
                PackagesRestorePackageVersionForOrgPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageVersionForOrgPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesRestorePackageVersionForOrgPackageType.Npm,
                "maven" => PackagesRestorePackageVersionForOrgPackageType.Maven,
                "rubygems" => PackagesRestorePackageVersionForOrgPackageType.Rubygems,
                "docker" => PackagesRestorePackageVersionForOrgPackageType.Docker,
                "nuget" => PackagesRestorePackageVersionForOrgPackageType.Nuget,
                "container" => PackagesRestorePackageVersionForOrgPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}