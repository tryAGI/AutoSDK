//HintName: G.Models.PackagesGetPackageForUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetPackageForUserPackageType
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
    public static class PackagesGetPackageForUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageForUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageForUserPackageType.Container => "container",
                PackagesGetPackageForUserPackageType.Docker => "docker",
                PackagesGetPackageForUserPackageType.Maven => "maven",
                PackagesGetPackageForUserPackageType.Npm => "npm",
                PackagesGetPackageForUserPackageType.Nuget => "nuget",
                PackagesGetPackageForUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageForUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesGetPackageForUserPackageType.Container,
                "docker" => PackagesGetPackageForUserPackageType.Docker,
                "maven" => PackagesGetPackageForUserPackageType.Maven,
                "npm" => PackagesGetPackageForUserPackageType.Npm,
                "nuget" => PackagesGetPackageForUserPackageType.Nuget,
                "rubygems" => PackagesGetPackageForUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}