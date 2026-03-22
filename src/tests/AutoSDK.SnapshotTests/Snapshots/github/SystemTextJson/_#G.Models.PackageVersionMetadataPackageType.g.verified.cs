//HintName: G.Models.PackageVersionMetadataPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: docker
    /// </summary>
    public enum PackageVersionMetadataPackageType
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
    public static class PackageVersionMetadataPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackageVersionMetadataPackageType value)
        {
            return value switch
            {
                PackageVersionMetadataPackageType.Container => "container",
                PackageVersionMetadataPackageType.Docker => "docker",
                PackageVersionMetadataPackageType.Maven => "maven",
                PackageVersionMetadataPackageType.Npm => "npm",
                PackageVersionMetadataPackageType.Nuget => "nuget",
                PackageVersionMetadataPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackageVersionMetadataPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackageVersionMetadataPackageType.Container,
                "docker" => PackageVersionMetadataPackageType.Docker,
                "maven" => PackageVersionMetadataPackageType.Maven,
                "npm" => PackageVersionMetadataPackageType.Npm,
                "nuget" => PackageVersionMetadataPackageType.Nuget,
                "rubygems" => PackageVersionMetadataPackageType.Rubygems,
                _ => null,
            };
        }
    }
}