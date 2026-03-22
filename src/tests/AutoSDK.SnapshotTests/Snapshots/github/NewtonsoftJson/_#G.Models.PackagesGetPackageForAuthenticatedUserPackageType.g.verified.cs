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
    public static class PackagesGetPackageForAuthenticatedUserPackageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackagesGetPackageForAuthenticatedUserPackageType value)
        {
            return value switch
            {
                PackagesGetPackageForAuthenticatedUserPackageType.Container => "container",
                PackagesGetPackageForAuthenticatedUserPackageType.Docker => "docker",
                PackagesGetPackageForAuthenticatedUserPackageType.Maven => "maven",
                PackagesGetPackageForAuthenticatedUserPackageType.Npm => "npm",
                PackagesGetPackageForAuthenticatedUserPackageType.Nuget => "nuget",
                PackagesGetPackageForAuthenticatedUserPackageType.Rubygems => "rubygems",
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
                "container" => PackagesGetPackageForAuthenticatedUserPackageType.Container,
                "docker" => PackagesGetPackageForAuthenticatedUserPackageType.Docker,
                "maven" => PackagesGetPackageForAuthenticatedUserPackageType.Maven,
                "npm" => PackagesGetPackageForAuthenticatedUserPackageType.Npm,
                "nuget" => PackagesGetPackageForAuthenticatedUserPackageType.Nuget,
                "rubygems" => PackagesGetPackageForAuthenticatedUserPackageType.Rubygems,
                _ => null,
            };
        }
    }
}