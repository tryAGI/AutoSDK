//HintName: G.Models.PackagesGetPackageVersionForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetPackageVersionForAuthenticatedUserPackageType
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
    public static class PackagesGetPackageVersionForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageVersionForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Container => "container",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetPackageVersionForAuthenticatedUserPackageType.Rubygems => "rubygems",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageVersionForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "container" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Container,
                "docker" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Docker,
                "maven" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Maven,
                "npm" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Npm,
                "nuget" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Nuget,
                "rubygems" => PackagesGetPackageVersionForAuthenticatedUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}