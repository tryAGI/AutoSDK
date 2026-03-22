//HintName: G.Models.PackagesRestorePackageForOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesRestorePackageForOrgPackageType
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
    public static class PackagesRestorePackageForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesRestorePackageForOrgPackageType value)
        {
            return value switch
            {
                PackagesRestorePackageForOrgPackageType.Container => "container",
                PackagesRestorePackageForOrgPackageType.Docker => "docker",
                PackagesRestorePackageForOrgPackageType.Maven => "maven",
                PackagesRestorePackageForOrgPackageType.Npm => "npm",
                PackagesRestorePackageForOrgPackageType.Nuget => "nuget",
                PackagesRestorePackageForOrgPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesRestorePackageForOrgPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesRestorePackageForOrgPackageType.Container,
                "docker" => PackagesRestorePackageForOrgPackageType.Docker,
                "maven" => PackagesRestorePackageForOrgPackageType.Maven,
                "npm" => PackagesRestorePackageForOrgPackageType.Npm,
                "nuget" => PackagesRestorePackageForOrgPackageType.Nuget,
                "rubygems" => PackagesRestorePackageForOrgPackageType.Rubygems,
                _ => null,
            };
        }
    }
}