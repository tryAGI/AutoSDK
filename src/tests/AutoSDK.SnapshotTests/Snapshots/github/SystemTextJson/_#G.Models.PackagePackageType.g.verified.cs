//HintName: G.Models.PackagePackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: docker
    /// </summary>
    public enum PackagePackageType
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
    public static class PackagePackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagePackageType value)
        {
            return value switch
            {
                PackagePackageType.Container => "container",
                PackagePackageType.Docker => "docker",
                PackagePackageType.Maven => "maven",
                PackagePackageType.Npm => "npm",
                PackagePackageType.Nuget => "nuget",
                PackagePackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagePackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagePackageType.Container,
                "docker" => PackagePackageType.Docker,
                "maven" => PackagePackageType.Maven,
                "npm" => PackagePackageType.Npm,
                "nuget" => PackagePackageType.Nuget,
                "rubygems" => PackagePackageType.Rubygems,
                _ => null,
            };
        }
    }
}