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
    public static class PackagesGetAllPackageVersionsForPackageOwnedByUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Container => "container",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Rubygems => "rubygems",
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
                "container" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Container,
                "docker" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Docker,
                "maven" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Maven,
                "npm" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Npm,
                "nuget" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Nuget,
                "rubygems" => PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}