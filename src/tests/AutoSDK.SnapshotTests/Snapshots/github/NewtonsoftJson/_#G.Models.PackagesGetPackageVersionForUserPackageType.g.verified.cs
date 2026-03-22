//HintName: G.Models.PackagesGetPackageVersionForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetPackageVersionForUserPackageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container")]
        Container,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docker")]
        Docker,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="maven")]
        Maven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="npm")]
        Npm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nuget")]
        Nuget,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rubygems")]
        Rubygems,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PackagesGetPackageVersionForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageVersionForUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageVersionForUserPackageType.Container => "container",
                PackagesGetPackageVersionForUserPackageType.Docker => "docker",
                PackagesGetPackageVersionForUserPackageType.Maven => "maven",
                PackagesGetPackageVersionForUserPackageType.Npm => "npm",
                PackagesGetPackageVersionForUserPackageType.Nuget => "nuget",
                PackagesGetPackageVersionForUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageVersionForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesGetPackageVersionForUserPackageType.Container,
                "docker" => PackagesGetPackageVersionForUserPackageType.Docker,
                "maven" => PackagesGetPackageVersionForUserPackageType.Maven,
                "npm" => PackagesGetPackageVersionForUserPackageType.Npm,
                "nuget" => PackagesGetPackageVersionForUserPackageType.Nuget,
                "rubygems" => PackagesGetPackageVersionForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}