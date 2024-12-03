//HintName: G.Models.PackagesGetPackageForAuthenticatedUserPackageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PackagesGetPackageForAuthenticatedUserPackageType
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
    public static class PackagesGetPackageForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageForAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetPackageForAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetPackageForAuthenticatedUserPackageType.Rubygems => "rubygems",
                PackagesGetPackageForAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetPackageForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetPackageForAuthenticatedUserPackageType.Container => "container",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackagesGetPackageForAuthenticatedUserPackageType? ToEnum(string value)
        {
            return value switch
            {
                "npm" => PackagesGetPackageForAuthenticatedUserPackageType.Npm,
                "maven" => PackagesGetPackageForAuthenticatedUserPackageType.Maven,
                "rubygems" => PackagesGetPackageForAuthenticatedUserPackageType.Rubygems,
                "docker" => PackagesGetPackageForAuthenticatedUserPackageType.Docker,
                "nuget" => PackagesGetPackageForAuthenticatedUserPackageType.Nuget,
                "container" => PackagesGetPackageForAuthenticatedUserPackageType.Container,
                _ => null,
            };
        }
    }
}