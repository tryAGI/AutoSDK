//HintName: G.Models.PackagePackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: docker
    /// </summary>
    public enum PackagePackageType
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
    public static class PackagePackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagePackageType value)
        {
            return value switch
            {
                PackagePackageType.Npm => "npm",
                PackagePackageType.Maven => "maven",
                PackagePackageType.Rubygems => "rubygems",
                PackagePackageType.Docker => "docker",
                PackagePackageType.Nuget => "nuget",
                PackagePackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagePackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagePackageType.Npm,
                "maven" => PackagePackageType.Maven,
                "rubygems" => PackagePackageType.Rubygems,
                "docker" => PackagePackageType.Docker,
                "nuget" => PackagePackageType.Nuget,
                "container" => PackagePackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}