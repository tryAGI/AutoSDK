//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType
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
    public static class PackagesGetAllPackageVersionsForPackageOwnedByUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Rubygems => "rubygems",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Npm,
                "maven" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Maven,
                "rubygems" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Rubygems,
                "docker" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Docker,
                "nuget" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Nuget,
                "container" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Container,
                _ => null,
            };
        }
    }
}