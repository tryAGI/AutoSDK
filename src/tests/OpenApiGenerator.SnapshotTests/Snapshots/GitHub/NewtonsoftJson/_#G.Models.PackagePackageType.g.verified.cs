//HintName: G.Models.PackagePackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: docker
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagePackageType
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