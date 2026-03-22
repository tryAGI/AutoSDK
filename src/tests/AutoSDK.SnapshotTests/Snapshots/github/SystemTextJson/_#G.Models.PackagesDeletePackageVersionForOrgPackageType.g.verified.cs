//HintName: G.Models.PackagesDeletePackageVersionForOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageVersionForOrgPackageType
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
    public static class PackagesDeletePackageVersionForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageVersionForOrgPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageVersionForOrgPackageType.Container => "container",
                PackagesDeletePackageVersionForOrgPackageType.Docker => "docker",
                PackagesDeletePackageVersionForOrgPackageType.Maven => "maven",
                PackagesDeletePackageVersionForOrgPackageType.Npm => "npm",
                PackagesDeletePackageVersionForOrgPackageType.Nuget => "nuget",
                PackagesDeletePackageVersionForOrgPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageVersionForOrgPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesDeletePackageVersionForOrgPackageType.Container,
                "docker" => PackagesDeletePackageVersionForOrgPackageType.Docker,
                "maven" => PackagesDeletePackageVersionForOrgPackageType.Maven,
                "npm" => PackagesDeletePackageVersionForOrgPackageType.Npm,
                "nuget" => PackagesDeletePackageVersionForOrgPackageType.Nuget,
                "rubygems" => PackagesDeletePackageVersionForOrgPackageType.Rubygems,
                _ => null,
            };
        }
    }
}