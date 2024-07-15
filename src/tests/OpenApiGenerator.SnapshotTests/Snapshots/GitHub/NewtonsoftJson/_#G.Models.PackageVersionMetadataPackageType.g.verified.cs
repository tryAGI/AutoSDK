//HintName: G.Models.PackageVersionMetadataPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: docker
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackageVersionMetadataPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docker")]
        Docker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container")]
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
        public static PackageVersionMetadataPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackageVersionMetadataPackageType.Npm,
                "maven" => PackageVersionMetadataPackageType.Maven,
                "rubygems" => PackageVersionMetadataPackageType.Rubygems,
                "docker" => PackageVersionMetadataPackageType.Docker,
                "nuget" => PackageVersionMetadataPackageType.Nuget,
                "container" => PackageVersionMetadataPackageType.Container,
                _ => null,
            };
        }
    }
}