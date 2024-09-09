//HintName: G.Models.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType
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
    public static class PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Npm,
                "maven" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Nuget,
                "container" => PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType.Container,
                _ => null,
            };
        }
    }
}