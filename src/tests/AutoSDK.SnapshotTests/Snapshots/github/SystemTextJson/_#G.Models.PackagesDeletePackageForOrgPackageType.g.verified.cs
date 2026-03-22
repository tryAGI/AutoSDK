//HintName: G.Models.PackagesDeletePackageForOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PackagesDeletePackageForOrgPackageType
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
    public static class PackagesDeletePackageForOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesDeletePackageForOrgPackageType value)
        {
            return value switch
            {
                PackagesDeletePackageForOrgPackageType.Container => "container",
                PackagesDeletePackageForOrgPackageType.Docker => "docker",
                PackagesDeletePackageForOrgPackageType.Maven => "maven",
                PackagesDeletePackageForOrgPackageType.Npm => "npm",
                PackagesDeletePackageForOrgPackageType.Nuget => "nuget",
                PackagesDeletePackageForOrgPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesDeletePackageForOrgPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesDeletePackageForOrgPackageType.Container,
                "docker" => PackagesDeletePackageForOrgPackageType.Docker,
                "maven" => PackagesDeletePackageForOrgPackageType.Maven,
                "npm" => PackagesDeletePackageForOrgPackageType.Npm,
                "nuget" => PackagesDeletePackageForOrgPackageType.Nuget,
                "rubygems" => PackagesDeletePackageForOrgPackageType.Rubygems,
                _ => null,
            };
        }
    }
}