//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType
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
    public static class PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Container => "container",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Container,
                "docker" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Docker,
                "maven" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Maven,
                "npm" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Npm,
                "nuget" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Nuget,
                "rubygems" => PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType.Rubygems,
                _ => null,
            };
        }
    }
}