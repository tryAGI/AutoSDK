//HintName: G.Models.PackageVersionMetadataPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: docker
    /// </summary>
    public enum PackageVersionMetadataPackageType
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
    public static class PackageVersionMetadataPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackageVersionMetadataPackageType value)
        {
            return value switch
            {
                PackageVersionMetadataPackageType.Npm => "npm",
                PackageVersionMetadataPackageType.Maven => "maven",
                PackageVersionMetadataPackageType.Rubygems => "rubygems",
                PackageVersionMetadataPackageType.Docker => "docker",
                PackageVersionMetadataPackageType.Nuget => "nuget",
                PackageVersionMetadataPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackageVersionMetadataPackageType ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackageVersionMetadataPackageType.Npm,
                "maven" => PackageVersionMetadataPackageType.Maven,
                "rubygems" => PackageVersionMetadataPackageType.Rubygems,
                "docker" => PackageVersionMetadataPackageType.Docker,
                "nuget" => PackageVersionMetadataPackageType.Nuget,
                "container" => PackageVersionMetadataPackageType.Container,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}